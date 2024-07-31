using System;
using System.Windows.Forms;

namespace Tarea_Extraclase_1_2022155662
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                    // Muestra un mensaje de advertencia si alguno de los campos está vacío
                    MessageBox.Show("Por favor, ingrese tanto el puerto como el mensaje.");
                    return; // Sale del método para evitar el envío del mensaje
                }
                // Agregar el texto a txtbox con un salto de línea
                txtbox.AppendText("De: " + "<" + Puerto +  ">" + Environment.NewLine + inputText + Environment.NewLine + Environment.NewLine);
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
            // Verificar si la tecla presionada es Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evitar el sonido de "ding" al presionar Enter
                e.SuppressKeyPress = true;

                // Llamar al método para enviar el mensaje
                btnShowMessage_Click(sender, e);
            }
        }
        private void txtPuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Comprueba si la tecla presionada es un dígito o una tecla de control (como borrar)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un dígito ni una tecla de control, cancela el evento
                e.Handled = true;
            }
        }
    }
}