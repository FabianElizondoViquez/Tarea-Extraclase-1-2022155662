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
            lblMessage.Text = inputText;
        }
    }
}
