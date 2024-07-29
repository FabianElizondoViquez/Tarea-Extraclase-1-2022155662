namespace Tarea_Extraclase_1_2022155662
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnShowMessage;
        private TextBox txtInput;
        private Label lblMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnShowMessage = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.Location = new System.Drawing.Point(100, 100);
            this.btnShowMessage.Name = "btnShowMessage";
            this.btnShowMessage.Size = new System.Drawing.Size(75, 23);
            this.btnShowMessage.TabIndex = 0;
            this.btnShowMessage.Text = "Mostrar mensaje";
            this.btnShowMessage.UseVisualStyleBackColor = true;
            this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(100, 50);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(100, 150);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnShowMessage);
            this.Name = "Form1";
            this.Text = "Mi Aplicación";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
