namespace Gaia.Donostia.WinForms.Vista
{
    partial class Form1
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
            this.btnVerListaClientes = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerListaClientes
            // 
            this.btnVerListaClientes.Location = new System.Drawing.Point(22, 50);
            this.btnVerListaClientes.Name = "btnVerListaClientes";
            this.btnVerListaClientes.Size = new System.Drawing.Size(117, 23);
            this.btnVerListaClientes.TabIndex = 0;
            this.btnVerListaClientes.Text = "Ver la lista de clientes";
            this.btnVerListaClientes.UseVisualStyleBackColor = true;
            this.btnVerListaClientes.Click += new System.EventHandler(this.btnVerListaClientes_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoCliente.Location = new System.Drawing.Point(247, 50);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(91, 23);
            this.btnNuevoCliente.TabIndex = 1;
            this.btnNuevoCliente.Text = "Nuevo cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gaia.Donostia.WinForms.Vista.Properties.Resources.persona;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(384, 312);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnVerListaClientes);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerListaClientes;
        private System.Windows.Forms.Button btnNuevoCliente;
    }
}

