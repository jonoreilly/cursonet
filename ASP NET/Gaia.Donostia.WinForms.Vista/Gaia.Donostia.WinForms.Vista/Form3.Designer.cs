namespace Gaia.Donostia.WinForms.Vista
{
    partial class Form3
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
            this.tbPersonID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStoreID = new System.Windows.Forms.TextBox();
            this.tbTerritoryID = new System.Windows.Forms.TextBox();
            this.tbAccountNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbModifiedDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPersonID
            // 
            this.tbPersonID.Location = new System.Drawing.Point(138, 30);
            this.tbPersonID.Name = "tbPersonID";
            this.tbPersonID.Size = new System.Drawing.Size(100, 20);
            this.tbPersonID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PersonID";
            // 
            // tbStoreID
            // 
            this.tbStoreID.Location = new System.Drawing.Point(138, 66);
            this.tbStoreID.Name = "tbStoreID";
            this.tbStoreID.Size = new System.Drawing.Size(100, 20);
            this.tbStoreID.TabIndex = 2;
            // 
            // tbTerritoryID
            // 
            this.tbTerritoryID.Location = new System.Drawing.Point(138, 102);
            this.tbTerritoryID.Name = "tbTerritoryID";
            this.tbTerritoryID.Size = new System.Drawing.Size(100, 20);
            this.tbTerritoryID.TabIndex = 3;
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.Location = new System.Drawing.Point(138, 138);
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.tbAccountNumber.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "StoreID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TerritoryID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "AccountNumber";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(93, 203);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ModifiedDate";
            // 
            // tbModifiedDate
            // 
            this.tbModifiedDate.Location = new System.Drawing.Point(138, 170);
            this.tbModifiedDate.Name = "tbModifiedDate";
            this.tbModifiedDate.Size = new System.Drawing.Size(100, 20);
            this.tbModifiedDate.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 238);
            this.Controls.Add(this.tbModifiedDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAccountNumber);
            this.Controls.Add(this.tbTerritoryID);
            this.Controls.Add(this.tbStoreID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPersonID);
            this.MaximumSize = new System.Drawing.Size(286, 276);
            this.MinimumSize = new System.Drawing.Size(286, 276);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPersonID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStoreID;
        private System.Windows.Forms.TextBox tbTerritoryID;
        private System.Windows.Forms.TextBox tbAccountNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbModifiedDate;
    }
}