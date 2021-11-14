
namespace WindowsFormsApp1.Vista
{
    partial class LoginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BienvenidoLabel = new System.Windows.Forms.Label();
            this.CorreoLabel = new System.Windows.Forms.Label();
            this.ClaveLabel = new System.Windows.Forms.Label();
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.IngresarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BienvenidoLabel
            // 
            this.BienvenidoLabel.AutoSize = true;
            this.BienvenidoLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BienvenidoLabel.Location = new System.Drawing.Point(225, 82);
            this.BienvenidoLabel.Name = "BienvenidoLabel";
            this.BienvenidoLabel.Size = new System.Drawing.Size(169, 27);
            this.BienvenidoLabel.TabIndex = 0;
            this.BienvenidoLabel.Text = "¡Bienvenido (a)!";
            this.BienvenidoLabel.Click += new System.EventHandler(this.BienvenidoLabel_Click);
            // 
            // CorreoLabel
            // 
            this.CorreoLabel.AutoSize = true;
            this.CorreoLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoLabel.Location = new System.Drawing.Point(110, 148);
            this.CorreoLabel.Name = "CorreoLabel";
            this.CorreoLabel.Size = new System.Drawing.Size(114, 18);
            this.CorreoLabel.TabIndex = 1;
            this.CorreoLabel.Text = "Ingrese su correo";
            this.CorreoLabel.Click += new System.EventHandler(this.CorreoLabel_Click);
            // 
            // ClaveLabel
            // 
            this.ClaveLabel.AutoSize = true;
            this.ClaveLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveLabel.Location = new System.Drawing.Point(118, 181);
            this.ClaveLabel.Name = "ClaveLabel";
            this.ClaveLabel.Size = new System.Drawing.Size(106, 18);
            this.ClaveLabel.TabIndex = 2;
            this.ClaveLabel.Text = "Ingrese su clave";
            this.ClaveLabel.Click += new System.EventHandler(this.ClaveLabel_Click);
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoTextBox.Location = new System.Drawing.Point(230, 148);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(277, 24);
            this.CorreoTextBox.TabIndex = 3;
            this.CorreoTextBox.Text = "franklinmoncada@unah.hn";
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveTextBox.Location = new System.Drawing.Point(230, 181);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.PasswordChar = '*';
            this.ClaveTextBox.Size = new System.Drawing.Size(277, 24);
            this.ClaveTextBox.TabIndex = 4;
            this.ClaveTextBox.Text = "1234";
            // 
            // IngresarButton
            // 
            this.IngresarButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarButton.Location = new System.Drawing.Point(197, 238);
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(92, 36);
            this.IngresarButton.TabIndex = 5;
            this.IngresarButton.Text = "Ingresar";
            this.IngresarButton.UseVisualStyleBackColor = true;
            this.IngresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(322, 238);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(92, 36);
            this.CancelarButton.TabIndex = 6;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 356);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.IngresarButton);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.CorreoTextBox);
            this.Controls.Add(this.ClaveLabel);
            this.Controls.Add(this.CorreoLabel);
            this.Controls.Add(this.BienvenidoLabel);
            this.Name = "LoginView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BienvenidoLabel;
        private System.Windows.Forms.Label CorreoLabel;
        private System.Windows.Forms.Label ClaveLabel;
        public System.Windows.Forms.TextBox CorreoTextBox;
        public System.Windows.Forms.TextBox ClaveTextBox;
        public System.Windows.Forms.Button IngresarButton;
        public System.Windows.Forms.Button CancelarButton;
    }
}