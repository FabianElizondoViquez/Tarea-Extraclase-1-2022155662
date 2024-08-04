using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Extraclase_1_2022155662
{
    public partial class Form1 : Form
    {
        private string _port;
        private SocketServer _server;
       
        public Form1(string port = null)
        {
            InitializeComponent();
            _port = port;
            this.txtPuerto.Text = _port; // Inicializa el puerto en el campo de texto
            this.txtPuerto.KeyPress += new KeyPressEventHandler(this.txtPuerto_KeyPress);

            if (!string.IsNullOrEmpty(_port))
            {
                StartServer(int.Parse(_port));
            }
        }

        private void StartServer(int port)
        {
            _server = new SocketServer(port, txtbox);
            _server.Start();
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text;
            string puertoDestino = txtPuerto.Text;

            if (!string.IsNullOrEmpty(puertoDestino) && !string.IsNullOrEmpty(inputText))
            {
                SendMessage(puertoDestino, inputText);
                txtbox.AppendText("De: " + puertoDestino + ": " + inputText + Environment.NewLine);
                txtPuerto.Clear();
                txtInput.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese tanto el puerto como el mensaje.");
            }
        }
        private void SendMessage(string port, string message)
        {
            try
            {
                int portNumber = int.Parse(port);
                TcpClient client = new TcpClient("127.0.0.1", portNumber);
                NetworkStream clientStream = client.GetStream();

                byte[] buffer = Encoding.ASCII.GetBytes(message);

                clientStream.Write(buffer, 0, buffer.Length);
                clientStream.Flush();
                client.Close();
                _server.SendMessage(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el mensaje: {ex.Message}");
            }
        }
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnShowMessage_Click(sender, e);
            }
        }

        private void txtPuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
