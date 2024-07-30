using System;
using System.Windows.Forms;

namespace Tarea_Extraclase_1_2022155662
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text;
            if (!string.IsNullOrEmpty(inputText))
            {
                // Agregar el texto a txtbox con un salto de línea
                txtbox.AppendText(inputText + Environment.NewLine);
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
    }
}