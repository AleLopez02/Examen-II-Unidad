
namespace WindowsFormsApp1.Vista
{
    partial class ClienteView
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
            this.RegistraLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.CorreoLabel = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.RegistrarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ServicioComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RegistraLabel
            // 
            this.RegistraLabel.AutoSize = true;
            this.RegistraLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistraLabel.Location = new System.Drawing.Point(264, 35);
            this.RegistraLabel.Name = "RegistraLabel";
            this.RegistraLabel.Size = new System.Drawing.Size(255, 26);
            this.RegistraLabel.TabIndex = 0;
            this.RegistraLabel.Text = "Registra un nuevo cliente";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(166, 90);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(62, 18);
            this.NombreLabel.TabIndex = 2;
            this.NombreLabel.Text = "Nombre";
            // 
            // CorreoLabel
            // 
            this.CorreoLabel.AutoSize = true;
            this.CorreoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoLabel.Location = new System.Drawing.Point(166, 129);
            this.CorreoLabel.Name = "CorreoLabel";
            this.CorreoLabel.Size = new System.Drawing.Size(55, 18);
            this.CorreoLabel.TabIndex = 3;
            this.CorreoLabel.Text = "Correo";
            this.CorreoLabel.Click += new System.EventHandler(this.CorreoLabel_Click);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.Location = new System.Drawing.Point(234, 88);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(378, 24);
            this.NombreTextBox.TabIndex = 6;
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoTextBox.Location = new System.Drawing.Point(234, 126);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(378, 24);
            this.CorreoTextBox.TabIndex = 7;
            // 
            // RegistrarButton
            // 
            this.RegistrarButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarButton.Location = new System.Drawing.Point(320, 244);
            this.RegistrarButton.Name = "RegistrarButton";
            this.RegistrarButton.Size = new System.Drawing.Size(123, 49);
            this.RegistrarButton.TabIndex = 9;
            this.RegistrarButton.Text = "GENERAR TICKET";
            this.RegistrarButton.UseVisualStyleBackColor = true;
            this.RegistrarButton.Click += new System.EventHandler(this.RegistrarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(478, 243);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(123, 49);
            this.CancelarButton.TabIndex = 10;
            this.CancelarButton.Text = "CANCELAR";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Location = new System.Drawing.Point(162, 243);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(123, 49);
            this.NuevoButton.TabIndex = 11;
            this.NuevoButton.Text = "NUEVO";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tipo de Servicio";
            // 
            // ServicioComboBox
            // 
            this.ServicioComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicioComboBox.FormattingEnabled = true;
            this.ServicioComboBox.Items.AddRange(new object[] {
            "Reparación",
            "Mantenimiento",
            "Limpieza"});
            this.ServicioComboBox.Location = new System.Drawing.Point(234, 167);
            this.ServicioComboBox.Name = "ServicioComboBox";
            this.ServicioComboBox.Size = new System.Drawing.Size(378, 26);
            this.ServicioComboBox.TabIndex = 13;
            this.ServicioComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 425);
            this.Controls.Add(this.ServicioComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.RegistrarButton);
            this.Controls.Add(this.CorreoTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.CorreoLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.RegistraLabel);
            this.Name = "ClienteView";
            this.Text = "ClienteView";
            this.Load += new System.EventHandler(this.ClienteView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegistraLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label CorreoLabel;
        public System.Windows.Forms.TextBox NombreTextBox;
        public System.Windows.Forms.TextBox CorreoTextBox;
        public System.Windows.Forms.Button RegistrarButton;
        public System.Windows.Forms.Button CancelarButton;
        public System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox ServicioComboBox;
    }
}