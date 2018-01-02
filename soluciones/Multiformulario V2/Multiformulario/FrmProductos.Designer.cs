namespace Multiformulario
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.txt_numfact = new System.Windows.Forms.TextBox();
            this.txt_IdProducto = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_nombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Productos = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_agregar = new System.Windows.Forms.ToolStripButton();
            this.tsb_buscar = new System.Windows.Forms.ToolStripButton();
            this.tsb_modificar = new System.Windows.Forms.ToolStripButton();
            this.tsb_borrar = new System.Windows.Forms.ToolStripButton();
            this.tsbguardar = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_numfact
            // 
            this.txt_numfact.Location = new System.Drawing.Point(483, 319);
            this.txt_numfact.Name = "txt_numfact";
            this.txt_numfact.Size = new System.Drawing.Size(100, 20);
            this.txt_numfact.TabIndex = 0;
            // 
            // txt_IdProducto
            // 
            this.txt_IdProducto.Location = new System.Drawing.Point(26, 83);
            this.txt_IdProducto.Name = "txt_IdProducto";
            this.txt_IdProducto.Size = new System.Drawing.Size(68, 20);
            this.txt_IdProducto.TabIndex = 1;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(483, 83);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 3;
            // 
            // txt_nombreProducto
            // 
            this.txt_nombreProducto.Location = new System.Drawing.Point(101, 83);
            this.txt_nombreProducto.Name = "txt_nombreProducto";
            this.txt_nombreProducto.Size = new System.Drawing.Size(376, 20);
            this.txt_nombreProducto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IdProducto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            // 
            // dgv_Productos
            // 
            this.dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productos.Location = new System.Drawing.Point(29, 125);
            this.dgv_Productos.Name = "dgv_Productos";
            this.dgv_Productos.Size = new System.Drawing.Size(554, 188);
            this.dgv_Productos.TabIndex = 8;
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
            this.toolStrip1.Size = new System.Drawing.Size(616, 25);
            this.toolStrip1.TabIndex = 9;
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
            // tsb_borrar
            // 
            this.tsb_borrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_borrar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_borrar.Image")));
            this.tsb_borrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_borrar.Name = "tsb_borrar";
            this.tsb_borrar.Size = new System.Drawing.Size(89, 22);
            this.tsb_borrar.Text = "Borrar Registro";
            this.tsb_borrar.Click += new System.EventHandler(this.tsb_borrar_Click);
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
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 364);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_Productos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombreProducto);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_IdProducto);
            this.Controls.Add(this.txt_numfact);
            this.Name = "FrmProductos";
            this.Text = "Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProductos_FormClosing);
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numfact;
        private System.Windows.Forms.TextBox txt_IdProducto;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_nombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Productos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_agregar;
        private System.Windows.Forms.ToolStripButton tsb_buscar;
        private System.Windows.Forms.ToolStripButton tsb_modificar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton tsb_borrar;
        private System.Windows.Forms.ToolStripButton tsbguardar;
    }
}