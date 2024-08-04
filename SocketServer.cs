using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Tarea_Extraclase_1_2022155662
{
    public class SocketServer
    {
        private readonly int _port;
        private Thread _listenerThread;
        private TcpListener _listener;
        private TextBox _outputTextBox;
        private List<TcpClient> _clients = new List<TcpClient>();
        private readonly object _lock = new object();

        public SocketServer(int port, TextBox outputTextBox)
        {
            _port = port;
            _outputTextBox = outputTextBox;
        }

        public void Start()
        {
            _listenerThread = new Thread(ListenForClients);
            _listenerThread.IsBackground = true;
            _listenerThread.Start();
        }

        private void ListenForClients()
        {
            _listener = new TcpListener(IPAddress.Any, _port);
            _listener.Start();

            while (true)
            {
                try
                {
                    TcpClient client = _listener.AcceptTcpClient();
                    lock (_lock)
                    {
                        _clients.Add(client);
                    }

                    Thread clientThread = new Thread(HandleClientComm);
                    clientThread.IsBackground = true;
                    clientThread.Start(client);
                }
                catch (SocketException ex)
                {
                    Console.WriteLine($"Error al aceptar cliente: {ex.Message}");
                }
            }
        }

        private void HandleClientComm(object clientObj)
        {
            TcpClient tcpClient = (TcpClient)clientObj;
            NetworkStream clientStream = tcpClient.GetStream();
            byte[] message = new byte[4096];
            int bytesRead;

            try
            {
                while (true)
                {
                    bytesRead = clientStream.Read(message, 0, 4096);

                    if (bytesRead == 0)
                    {
                        // La conexión ha sido cerrada por el cliente
                        break;
                    }

                    string msg = Encoding.ASCII.GetString(message, 0, bytesRead);

                    _outputTextBox.Invoke(new Action(() =>
                    {
                        _outputTextBox.AppendText($"Mensaje recibido: {msg}{Environment.NewLine}");
                    }));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al manejar cliente: {ex.Message}");
            }
            finally
            {
                lock (_lock)
                {
                    _clients.Remove(tcpClient);
                }
                tcpClient.Close();
            }
        }

        public void SendMessage(string message)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            List<TcpClient> disconnectedClients = new List<TcpClient>();

            lock (_lock)
            {
                foreach (var client in _clients)
                {
                    try
                    {
                        if (client.Connected)
                        {
                            NetworkStream clientStream = client.GetStream();
                            clientStream.Write(buffer, 0, buffer.Length);
                            clientStream.Flush();
                        }
                        else
                        {
                            disconnectedClients.Add(client);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al enviar mensaje: {ex.Message}");
                        disconnectedClients.Add(client);
                    }
                }

                foreach (var client in disconnectedClients)
                {
                    _clients.Remove(client);
                    client.Close();
                }
            }
        }
    }
}
