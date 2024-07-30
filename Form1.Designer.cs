namespace Tarea_Extraclase_1_2022155662
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnShowMessage;
        private TextBox txtInput;
        private TextBox txtbox;
        private Label lbltextbox;
        private Label lblinputbox;
        

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
            this.lbltextbox = new System.Windows.Forms.Label(); 
            this.txtbox = new System.Windows.Forms.TextBox();
            this.lblinputbox = new System.Windows.FormsLabel();
            this.SuspendLayout();
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.Location = new System.Drawing.Point(70, 490);
            this.btnShowMessage.Name = "btnShowMessage";
            this.btnShowMessage.Size = new System.Drawing.Size(200, 50);
            this.btnShowMessage.TabIndex = 0;
            this.btnShowMessage.Text = "Enviar";
            this.btnShowMessage.UseVisualStyleBackColor = true;
            this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
            this.btnShowMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(40, 250);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(270, 200);
            this.txtInput.TabIndex = 1;
            this.txtInput.Multiline = true; // Permitir múltiples líneas
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; // Barra de desplazamiento vertical
            this.txtInput.WordWrap = true; // Asegura que el texto se ajuste al tamaño del TextBox
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown); // Suscribir al evento KeyDown
            // 
            // lbltextbox
            // 
            this.lbltextbox.AutoSize = true; // Ajusta automáticamente el tamaño del Label
            this.lbltextbox.Location = new System.Drawing.Point(350, 110); // Posición encima del TextBox
            this.lbltextbox.Name = "lbltextbox";
            this.lbltextbox.Size = new System.Drawing.Size(150, 13); // Tamaño del Label
            this.lbltextbox.TabIndex = 2;
            this.lbltextbox.Text = "Mensajes Entrantes"; // Texto sobre el TextBox
            this.lbltextbox.BackColor = System.Drawing.Color.Transparent; 
            this.lbltextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(350, 140); // Ajustar ubicación según sea necesario
            this.txtbox.Size = new System.Drawing.Size(400, 400); // Ajustar tamaño según sea necesario
            this.txtbox.Multiline = true; // Permitir múltiples líneas
            this.txtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; // Barra de desplazamiento vertical
            this.txtbox.ReadOnly = true; // Solo lectura
            this.txtbox.BackColor = System.Drawing.Color.LightGreen; // Color de fondo
            this.txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Estilo del borde
            this.txtbox.Name = "txtbox";
            this.txtbox.TabIndex = 4; // Ajustar el índice según el orden deseado
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);

            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnShowMessage);
            this.Controls.Add(this.lbltextbox);
            this.Controls.Add(this.txtbox);
            this.Name = "Form1";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
