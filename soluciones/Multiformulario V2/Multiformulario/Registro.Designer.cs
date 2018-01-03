namespace Multiformulario
{
    partial class Registro
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbContraseña2 = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblAlertaUsEx = new System.Windows.Forms.Label();
            this.lblAlertaContraseña = new System.Windows.Forms.Label();
            this.lblAlertaHueco = new System.Windows.Forms.Label();
            this.lblAlertaSinContraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(172, 34);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbUsuario.TabIndex = 2;
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(172, 87);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.PasswordChar = '*';
            this.tbContraseña.Size = new System.Drawing.Size(100, 20);
            this.tbContraseña.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repite Contraseña";
            // 
            // tbContraseña2
            // 
            this.tbContraseña2.Location = new System.Drawing.Point(172, 136);
            this.tbContraseña2.Name = "tbContraseña2";
            this.tbContraseña2.PasswordChar = '*';
            this.tbContraseña2.Size = new System.Drawing.Size(100, 20);
            this.tbContraseña2.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(111, 197);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblAlertaUsEx
            // 
            this.lblAlertaUsEx.AutoSize = true;
            this.lblAlertaUsEx.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaUsEx.Location = new System.Drawing.Point(70, 60);
            this.lblAlertaUsEx.Name = "lblAlertaUsEx";
            this.lblAlertaUsEx.Size = new System.Drawing.Size(109, 13);
            this.lblAlertaUsEx.TabIndex = 7;
            this.lblAlertaUsEx.Text = "Este usuario ya existe";
            // 
            // lblAlertaContraseña
            // 
            this.lblAlertaContraseña.AutoSize = true;
            this.lblAlertaContraseña.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaContraseña.Location = new System.Drawing.Point(70, 172);
            this.lblAlertaContraseña.Name = "lblAlertaContraseña";
            this.lblAlertaContraseña.Size = new System.Drawing.Size(133, 13);
            this.lblAlertaContraseña.TabIndex = 8;
            this.lblAlertaContraseña.Text = "La contraseña no coincide";
            // 
            // lblAlertaHueco
            // 
            this.lblAlertaHueco.AutoSize = true;
            this.lblAlertaHueco.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaHueco.Location = new System.Drawing.Point(66, 60);
            this.lblAlertaHueco.Name = "lblAlertaHueco";
            this.lblAlertaHueco.Size = new System.Drawing.Size(113, 13);
            this.lblAlertaHueco.TabIndex = 9;
            this.lblAlertaHueco.Text = "Pero mete algo, Melón";
            // 
            // lblAlertaSinContraseña
            // 
            this.lblAlertaSinContraseña.AutoSize = true;
            this.lblAlertaSinContraseña.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaSinContraseña.Location = new System.Drawing.Point(73, 171);
            this.lblAlertaSinContraseña.Name = "lblAlertaSinContraseña";
            this.lblAlertaSinContraseña.Size = new System.Drawing.Size(150, 13);
            this.lblAlertaSinContraseña.TabIndex = 10;
            this.lblAlertaSinContraseña.Text = "Sin contraseña? Va a ser q no";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblAlertaSinContraseña);
            this.Controls.Add(this.lblAlertaHueco);
            this.Controls.Add(this.lblAlertaContraseña);
            this.Controls.Add(this.lblAlertaUsEx);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbContraseña2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbContraseña2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblAlertaUsEx;
        private System.Windows.Forms.Label lblAlertaContraseña;
        private System.Windows.Forms.Label lblAlertaHueco;
        private System.Windows.Forms.Label lblAlertaSinContraseña;
    }
}