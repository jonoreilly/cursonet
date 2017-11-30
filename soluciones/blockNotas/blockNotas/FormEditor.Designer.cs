namespace blockNotas
{
    partial class FormEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuItemCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tbEditorArea = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMenu
            // 
            this.tsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemAbrir,
            this.tsMenuItemGuardar,
            this.toolStripSeparator1,
            this.tsMenuItemCerrar,
            this.tsMenuItemSalir});
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(60, 20);
            this.tsMenu.Text = "&Archivo";
            // 
            // tsMenuItemAbrir
            // 
            this.tsMenuItemAbrir.Name = "tsMenuItemAbrir";
            this.tsMenuItemAbrir.Size = new System.Drawing.Size(152, 22);
            this.tsMenuItemAbrir.Text = "A&brir";
            this.tsMenuItemAbrir.Click += new System.EventHandler(this.tsMenuItemAbrir_Click);
            // 
            // tsMenuItemGuardar
            // 
            this.tsMenuItemGuardar.Name = "tsMenuItemGuardar";
            this.tsMenuItemGuardar.Size = new System.Drawing.Size(152, 22);
            this.tsMenuItemGuardar.Text = "&Guardar";
            this.tsMenuItemGuardar.Click += new System.EventHandler(this.tsMenuItemGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsMenuItemCerrar
            // 
            this.tsMenuItemCerrar.Name = "tsMenuItemCerrar";
            this.tsMenuItemCerrar.Size = new System.Drawing.Size(152, 22);
            this.tsMenuItemCerrar.Text = "&Cerrar";
            // 
            // tsMenuItemSalir
            // 
            this.tsMenuItemSalir.Name = "tsMenuItemSalir";
            this.tsMenuItemSalir.Size = new System.Drawing.Size(152, 22);
            this.tsMenuItemSalir.Text = "&Salir";
            // 
            // tbEditorArea
            // 
            this.tbEditorArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEditorArea.Location = new System.Drawing.Point(0, 24);
            this.tbEditorArea.Multiline = true;
            this.tbEditorArea.Name = "tbEditorArea";
            this.tbEditorArea.Size = new System.Drawing.Size(522, 348);
            this.tbEditorArea.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 372);
            this.Controls.Add(this.tbEditorArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEditor";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemAbrir;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemCerrar;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemSalir;
        private System.Windows.Forms.TextBox tbEditorArea;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

