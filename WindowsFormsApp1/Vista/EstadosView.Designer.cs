
namespace WindowsFormsApp1.Vista
{
    partial class EstadosView
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
            this.label1 = new System.Windows.Forms.Label();
            this.EstadosdataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.EstadosComboBox = new System.Windows.Forms.ComboBox();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EstadosdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escoja el cliente que desee modificar su estado de ticket";
            // 
            // EstadosdataGridView1
            // 
            this.EstadosdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstadosdataGridView1.Location = new System.Drawing.Point(2, 80);
            this.EstadosdataGridView1.Name = "EstadosdataGridView1";
            this.EstadosdataGridView1.Size = new System.Drawing.Size(795, 161);
            this.EstadosdataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ahora, escoja el nuevo estado que está el ticket";
            // 
            // EstadosComboBox
            // 
            this.EstadosComboBox.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadosComboBox.FormattingEnabled = true;
            this.EstadosComboBox.Items.AddRange(new object[] {
            "Sin Resolver",
            "Abierto",
            "En espera",
            "Cerrado"});
            this.EstadosComboBox.Location = new System.Drawing.Point(334, 290);
            this.EstadosComboBox.Name = "EstadosComboBox";
            this.EstadosComboBox.Size = new System.Drawing.Size(121, 27);
            this.EstadosComboBox.TabIndex = 3;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.Location = new System.Drawing.Point(204, 368);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(143, 51);
            this.ModificarButton.TabIndex = 4;
            this.ModificarButton.Text = "MODIFICAR";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(443, 368);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(143, 51);
            this.GuardarButton.TabIndex = 5;
            this.GuardarButton.Text = "GUARDAR";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // EstadosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.EstadosComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EstadosdataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "EstadosView";
            this.Text = "EstadosView";
            ((System.ComponentModel.ISupportInitialize)(this.EstadosdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView EstadosdataGridView1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button ModificarButton;
        public System.Windows.Forms.ComboBox EstadosComboBox;
        public System.Windows.Forms.Button GuardarButton;
    }
}