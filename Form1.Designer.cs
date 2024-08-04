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
        private TextBox txtPuerto;
        private Label lblpuerto;
        private Label lblredactar;
        

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
            this.lblinputbox = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.lblpuerto = new System.Windows.Forms.Label(); 
            this.lblredactar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.Location = new System.Drawing.Point(70, 410);
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
            this.txtInput.Location = new System.Drawing.Point(40, 140);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(270, 240);
            this.txtInput.TabIndex = 1;
            this.txtInput.Multiline = true; // Permitir múltiples líneas
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; // Barra de desplazamiento vertical
            this.txtInput.WordWrap = true; // Asegura que el texto se ajuste al tamaño del TextBox
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown); // Suscribir al evento KeyDown
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lbltextbox
            // 
            this.lbltextbox.AutoSize = true; // Ajusta automáticamente el tamaño del Label
            this.lbltextbox.Location = new System.Drawing.Point(350, 20); // Posición encima del TextBox
            this.lbltextbox.Name = "lbltextbox";
            this.lbltextbox.Size = new System.Drawing.Size(150, 13); // Tamaño del Label
            this.lbltextbox.TabIndex = 2;
            this.lbltextbox.Text = "Mensajes Entrantes"; // Texto sobre el TextBox
            this.lbltextbox.BackColor = System.Drawing.Color.Transparent; 
            this.lbltextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(350, 60); // Ajustar ubicación según sea necesario
            this.txtbox.Size = new System.Drawing.Size(350, 400); // Ajustar tamaño según sea necesario
            this.txtbox.Multiline = true; // Permitir múltiples líneas
            this.txtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; // Barra de desplazamiento vertical
            this.txtbox.ReadOnly = true; // Solo lectura
            this.txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Estilo del borde
            this.txtbox.Name = "txtbox";
            this.txtbox.TabIndex = 4; // Ajustar el índice según el orden deseado
            this.txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(160, 80);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(150, 30);
            this.txtPuerto.TabIndex = 1;
            this.txtPuerto.Multiline = true; // Permitir múltiples líneas
            this.txtPuerto.WordWrap = true; // Asegura que el texto se ajuste al tamaño del TextBox
            this.txtPuerto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown); // Suscribir al evento KeyDown
            this.txtPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuerto.TextAlign = HorizontalAlignment.Center;
            // 
            // lblpuerto
            // 
            this.lblpuerto.AutoSize = true; // Ajusta automáticamente el tamaño del Label
            this.lblpuerto.Location = new System.Drawing.Point(40, 85); // Posición encima del TextBox
            this.lblpuerto.Name = "lblpuerto";
            this.lblpuerto.Size = new System.Drawing.Size(150, 13); // Tamaño del Label
            this.lblpuerto.TabIndex = 2;
            this.lblpuerto.Text = "Puerto destino:"; // Texto sobre el TextBox
            this.lblpuerto.BackColor = System.Drawing.Color.Transparent; 
            this.lblpuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblredactar
            // 

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnShowMessage);
            this.Controls.Add(this.lbltextbox);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.lblpuerto);
            this.Controls.Add(this.lblredactar);
            this.Name = "Form1";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();
        } 
    }
}
