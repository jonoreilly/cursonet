namespace aplicacionEscritorio1WinForms
{
    partial class FormEjemplo1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPulsa = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cbTerminos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnPulsa
            // 
            this.btnPulsa.Location = new System.Drawing.Point(250, 160);
            this.btnPulsa.Name = "btnPulsa";
            this.btnPulsa.Size = new System.Drawing.Size(75, 23);
            this.btnPulsa.TabIndex = 0;
            this.btnPulsa.Text = "Pulsa";
            this.btnPulsa.UseVisualStyleBackColor = true;
            this.btnPulsa.Click += new System.EventHandler(this.btnPulsa_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(76, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(105, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Introduce tu  nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(210, 61);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // cbTerminos
            // 
            this.cbTerminos.AutoSize = true;
            this.cbTerminos.Location = new System.Drawing.Point(38, 164);
            this.cbTerminos.Name = "cbTerminos";
            this.cbTerminos.Size = new System.Drawing.Size(153, 17);
            this.cbTerminos.TabIndex = 4;
            this.cbTerminos.Text = "Acepto los terminos de uso";
            this.cbTerminos.UseVisualStyleBackColor = true;
            // 
            // FormEjemplo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(376, 298);
            this.Controls.Add(this.cbTerminos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnPulsa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEjemplo1";
            this.Text = "Ejemplo1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPulsa;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.CheckBox cbTerminos;
    }
}

