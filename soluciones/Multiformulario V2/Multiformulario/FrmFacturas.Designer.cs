namespace Multiformulario
{
    partial class FrmFacturas
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_IdCliente = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_IVA = new System.Windows.Forms.TextBox();
            this.txt_baseImponible = new System.Windows.Forms.TextBox();
            this.txt_Totfact = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nup_cntd = new System.Windows.Forms.NumericUpDown();
            this.btn_nuProd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_totlin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ivalin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_preciolinea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmb_IdProducto = new System.Windows.Forms.ComboBox();
            this.txt_linea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_lineas = new System.Windows.Forms.DataGridView();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_cntd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lineas)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtp_fecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_idFactura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_IdCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificación de la Factura:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fecha factura";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(211, 38);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IdFactura";
            // 
            // txt_idFactura
            // 
            this.txt_idFactura.Location = new System.Drawing.Point(6, 38);
            this.txt_idFactura.Name = "txt_idFactura";
            this.txt_idFactura.Size = new System.Drawing.Size(48, 20);
            this.txt_idFactura.TabIndex = 3;
            this.txt_idFactura.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // cmb_IdCliente
            // 
            this.cmb_IdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_IdCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb_IdCliente.FormattingEnabled = true;
            this.cmb_IdCliente.Location = new System.Drawing.Point(71, 37);
            this.cmb_IdCliente.Name = "cmb_IdCliente";
            this.cmb_IdCliente.Size = new System.Drawing.Size(125, 21);
            this.cmb_IdCliente.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_IVA);
            this.groupBox2.Controls.Add(this.txt_baseImponible);
            this.groupBox2.Controls.Add(this.txt_Totfact);
            this.groupBox2.Location = new System.Drawing.Point(449, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 73);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totales";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(197, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Total Factura";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "IVA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Base Imponible";
            // 
            // txt_IVA
            // 
            this.txt_IVA.Location = new System.Drawing.Point(110, 37);
            this.txt_IVA.Name = "txt_IVA";
            this.txt_IVA.Size = new System.Drawing.Size(81, 20);
            this.txt_IVA.TabIndex = 2;
            // 
            // txt_baseImponible
            // 
            this.txt_baseImponible.Location = new System.Drawing.Point(23, 37);
            this.txt_baseImponible.Name = "txt_baseImponible";
            this.txt_baseImponible.Size = new System.Drawing.Size(81, 20);
            this.txt_baseImponible.TabIndex = 1;
            // 
            // txt_Totfact
            // 
            this.txt_Totfact.Location = new System.Drawing.Point(197, 37);
            this.txt_Totfact.Name = "txt_Totfact";
            this.txt_Totfact.Size = new System.Drawing.Size(81, 20);
            this.txt_Totfact.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox3.Controls.Add(this.nup_cntd);
            this.groupBox3.Controls.Add(this.btn_nuProd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_totlin);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_ivalin);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_preciolinea);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblProducto);
            this.groupBox3.Controls.Add(this.cmb_IdProducto);
            this.groupBox3.Controls.Add(this.txt_linea);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(744, 71);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Añadir Producto";
            // 
            // nup_cntd
            // 
            this.nup_cntd.Location = new System.Drawing.Point(283, 35);
            this.nup_cntd.Name = "nup_cntd";
            this.nup_cntd.Size = new System.Drawing.Size(82, 20);
            this.nup_cntd.TabIndex = 22;
            this.nup_cntd.ValueChanged += new System.EventHandler(this.nup_cntd_ValueChanged);
            // 
            // btn_nuProd
            // 
            this.btn_nuProd.Location = new System.Drawing.Point(371, 19);
            this.btn_nuProd.Name = "btn_nuProd";
            this.btn_nuProd.Size = new System.Drawing.Size(75, 37);
            this.btn_nuProd.TabIndex = 21;
            this.btn_nuProd.Text = "Añdir al pedido";
            this.btn_nuProd.UseVisualStyleBackColor = true;
            this.btn_nuProd.Click += new System.EventHandler(this.btn_nuProd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(629, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total Linea";
            // 
            // txt_totlin
            // 
            this.txt_totlin.Location = new System.Drawing.Point(632, 34);
            this.txt_totlin.Name = "txt_totlin";
            this.txt_totlin.Size = new System.Drawing.Size(81, 20);
            this.txt_totlin.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(542, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "IvaLinea";
            // 
            // txt_ivalin
            // 
            this.txt_ivalin.Location = new System.Drawing.Point(545, 33);
            this.txt_ivalin.Name = "txt_ivalin";
            this.txt_ivalin.Size = new System.Drawing.Size(81, 20);
            this.txt_ivalin.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(455, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "PrecioLinea";
            // 
            // txt_preciolinea
            // 
            this.txt_preciolinea.Location = new System.Drawing.Point(458, 34);
            this.txt_preciolinea.Name = "txt_preciolinea";
            this.txt_preciolinea.Size = new System.Drawing.Size(81, 20);
            this.txt_preciolinea.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(279, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cantidad";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProducto.Location = new System.Drawing.Point(60, 15);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(73, 20);
            this.lblProducto.TabIndex = 12;
            this.lblProducto.Text = "Producto";
            // 
            // cmb_IdProducto
            // 
            this.cmb_IdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_IdProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb_IdProducto.DisplayMember = "1";
            this.cmb_IdProducto.FormattingEnabled = true;
            this.cmb_IdProducto.Location = new System.Drawing.Point(60, 33);
            this.cmb_IdProducto.Name = "cmb_IdProducto";
            this.cmb_IdProducto.Size = new System.Drawing.Size(216, 21);
            this.cmb_IdProducto.TabIndex = 11;
            this.cmb_IdProducto.SelectedIndexChanged += new System.EventHandler(this.cmb_IdProducto_SelectedIndexChanged);
            // 
            // txt_linea
            // 
            this.txt_linea.Location = new System.Drawing.Point(9, 33);
            this.txt_linea.Name = "txt_linea";
            this.txt_linea.Size = new System.Drawing.Size(46, 20);
            this.txt_linea.TabIndex = 10;
            this.txt_linea.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Línea";
            // 
            // dgv_lineas
            // 
            this.dgv_lineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lineas.Location = new System.Drawing.Point(12, 180);
            this.dgv_lineas.Name = "dgv_lineas";
            this.dgv_lineas.Size = new System.Drawing.Size(744, 150);
            this.dgv_lineas.TabIndex = 4;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(386, 337);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(370, 23);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.Text = "Validar todo y terminar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(370, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancelar y salir sin grabar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 387);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.dgv_lineas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFacturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.FrmFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_cntd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lineas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_IdCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_nuProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_totlin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ivalin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_preciolinea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmb_IdProducto;
        private System.Windows.Forms.TextBox txt_linea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_IVA;
        private System.Windows.Forms.TextBox txt_baseImponible;
        private System.Windows.Forms.TextBox txt_Totfact;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.DataGridView dgv_lineas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nup_cntd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}