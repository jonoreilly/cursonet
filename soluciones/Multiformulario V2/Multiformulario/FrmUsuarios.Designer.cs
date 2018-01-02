namespace Multiformulario
{
    partial class FrmUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Contrasenya = new System.Windows.Forms.TextBox();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_agregar = new System.Windows.Forms.ToolStripButton();
            this.tsb_buscar = new System.Windows.Forms.ToolStripButton();
            this.tsb_modificar = new System.Windows.Forms.ToolStripButton();
            this.tsbguardar = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tsb_borrar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "usuario";
            // 
            // txt_IdUsuario
            // 
            this.txt_IdUsuario.Location = new System.Drawing.Point(22, 53);
            this.txt_IdUsuario.Name = "txt_IdUsuario";
            this.txt_IdUsuario.Size = new System.Drawing.Size(136, 20);
            this.txt_IdUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "contraseña";
            // 
            // txt_Contrasenya
            // 
            this.txt_Contrasenya.Location = new System.Drawing.Point(174, 53);
            this.txt_Contrasenya.Name = "txt_Contrasenya";
            this.txt_Contrasenya.Size = new System.Drawing.Size(129, 20);
            this.txt_Contrasenya.TabIndex = 3;
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Location = new System.Drawing.Point(22, 93);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.Size = new System.Drawing.Size(281, 170);
            this.dgv_Usuarios.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_agregar,
            this.tsb_buscar,
            this.tsb_modificar,
            this.tsb_borrar,
            this.tsbguardar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(332, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_agregar
            // 
            this.tsb_agregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_agregar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_agregar.Image")));
            this.tsb_agregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_agregar.Name = "tsb_agregar";
            this.tsb_agregar.Size = new System.Drawing.Size(53, 22);
            this.tsb_agregar.Text = "Agregar";
            this.tsb_agregar.Click += new System.EventHandler(this.tsb_agregar_Click);
            // 
            // tsb_buscar
            // 
            this.tsb_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_buscar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_buscar.Image")));
            this.tsb_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_buscar.Name = "tsb_buscar";
            this.tsb_buscar.Size = new System.Drawing.Size(46, 22);
            this.tsb_buscar.Text = "Buscar";
            this.tsb_buscar.Click += new System.EventHandler(this.tsb_buscar_Click);
            // 
            // tsb_modificar
            // 
            this.tsb_modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_modificar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_modificar.Image")));
            this.tsb_modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_modificar.Name = "tsb_modificar";
            this.tsb_modificar.Size = new System.Drawing.Size(62, 22);
            this.tsb_modificar.Text = "Modificar";
            this.tsb_modificar.Click += new System.EventHandler(this.tsb_modificar_Click);
            // 
            // tsbguardar
            // 
            this.tsbguardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbguardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbguardar.Image")));
            this.tsbguardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbguardar.Name = "tsbguardar";
            this.tsbguardar.Size = new System.Drawing.Size(53, 22);
            this.tsbguardar.Text = "Guardar";
            this.tsbguardar.Click += new System.EventHandler(this.tsbguardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tsb_borrar
            // 
            this.tsb_borrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_borrar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_borrar.Image")));
            this.tsb_borrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_borrar.Name = "tsb_borrar";
            this.tsb_borrar.Size = new System.Drawing.Size(43, 22);
            this.tsb_borrar.Text = "Borrar";
            this.tsb_borrar.Click += new System.EventHandler(this.tsb_borrar_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 279);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.txt_Contrasenya);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_IdUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FrmUsuarios";
            this.Text = "frmUsuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IdUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Contrasenya;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_agregar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton tsb_buscar;
        private System.Windows.Forms.ToolStripButton tsb_modificar;
        private System.Windows.Forms.ToolStripButton tsbguardar;
        private System.Windows.Forms.ToolStripButton tsb_borrar;
    }
}