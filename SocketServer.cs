using System;
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
                // Bloquea hasta que llegue un cliente
                TcpClient client = _listener.AcceptTcpClient();

                // Crea un hilo separado para manejar la comunicación con este cliente
                Thread clientThread = new Thread(HandleClientComm);
                clientThread.IsBackground = true;
                clientThread.Start(client);
            }
        }

        private void HandleClientComm(object clientObj)
        {
            TcpClient tcpClient = (TcpClient)clientObj;
            NetworkStream clientStream = tcpClient.GetStream();
            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    // Bloquea hasta que se reciba un mensaje
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    // Un error ha ocurrido en la lectura
                    break;
                }

                if (bytesRead == 0)
                {
                    // El cliente se ha desconectado
                    break;
                }

                // Traduce los datos recibidos en un mensaje ASCII
                string msg = Encoding.ASCII.GetString(message, 0, bytesRead);

                // Muestra el mensaje en el TextBox
                _outputTextBox.Invoke(new Action(() =>
                {
                    _outputTextBox.AppendText($"Mensaje recibido: {msg}{Environment.NewLine}");
                }));
            }

            tcpClient.Close();
        }
    }
}
