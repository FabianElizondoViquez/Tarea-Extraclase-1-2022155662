using System;
using System.Windows.Forms;

namespace Tarea_Extraclase_1_2022155662
{
    public partial class Form1 : Form
    {
        private string _port;

        public Form1(string port = null)
        {
            InitializeComponent();
            _port = port;
            this.txtPuerto.Text = _port; // Inicializa el puerto en el campo de texto
            this.txtPuerto.KeyPress += new KeyPressEventHandler(this.txtPuerto_KeyPress);
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text;
            string Puerto = txtPuerto.Text;
            if (!string.IsNullOrEmpty(Puerto + inputText))
            {
                if (string.IsNullOrEmpty(Puerto) || string.IsNullOrEmpty(inputText))
                {
                    MessageBox.Show("Por favor, ingrese tanto el puerto como el mensaje.");
                    return;
                }
                txtbox.AppendText("De: " + "<" + Puerto + ">" + Environment.NewLine + inputText + Environment.NewLine + Environment.NewLine);
                txtPuerto.Clear();
                txtInput.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un mensaje.");
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
