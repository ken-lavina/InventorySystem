namespace ICTO_IS
{
    partial class AddStocks
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
            this.qtyRE = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStocks = new System.Windows.Forms.Button();
            this.dtDateIn = new System.Windows.Forms.DateTimePicker();
            this.lblBRFdate2 = new System.Windows.Forms.Label();
            this.dtEPD = new System.Windows.Forms.DateTimePicker();
            this.lblBRFitem = new System.Windows.Forms.Label();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.lblBRFoffice = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.lblBRFname = new System.Windows.Forms.Label();
            this.gbBRF = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.gbBRF.SuspendLayout();
            this.SuspendLayout();
            // 
            // qtyRE
            // 
            this.qtyRE.AutoSize = true;
            this.qtyRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyRE.ForeColor = System.Drawing.Color.Black;
            this.qtyRE.Location = new System.Drawing.Point(105, 209);
            this.qtyRE.Name = "qtyRE";
            this.qtyRE.Size = new System.Drawing.Size(51, 15);
            this.qtyRE.TabIndex = 67;
            this.qtyRE.Text = "Quantity";
            // 
            // numQty
            // 
            this.numQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQty.Location = new System.Drawing.Point(248, 206);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(77, 21);
            this.numQty.TabIndex = 66;
            // 
            // txtEName
            // 
            this.txtEName.Location = new System.Drawing.Point(249, 118);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(198, 21);
            this.txtEName.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(105, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 63;
            this.label1.Text = "Equipment Name";
            // 
            // btnAddStocks
            // 
            this.btnAddStocks.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAddStocks.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStocks.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddStocks.Location = new System.Drawing.Point(456, 335);
            this.btnAddStocks.Name = "btnAddStocks";
            this.btnAddStocks.Size = new System.Drawing.Size(87, 34);
            this.btnAddStocks.TabIndex = 62;
            this.btnAddStocks.Text = "Add to List";
            this.btnAddStocks.UseVisualStyleBackColor = false;
            this.btnAddStocks.Click += new System.EventHandler(this.btnAddStocks_Click);
            // 
            // dtDateIn
            // 
            this.dtDateIn.Location = new System.Drawing.Point(248, 233);
            this.dtDateIn.Name = "dtDateIn";
            this.dtDateIn.Size = new System.Drawing.Size(198, 21);
            this.dtDateIn.TabIndex = 61;
            // 
            // lblBRFdate2
            // 
            this.lblBRFdate2.AutoSize = true;
            this.lblBRFdate2.BackColor = System.Drawing.Color.Transparent;
            this.lblBRFdate2.ForeColor = System.Drawing.Color.Black;
            this.lblBRFdate2.Location = new System.Drawing.Point(105, 238);
            this.lblBRFdate2.Name = "lblBRFdate2";
            this.lblBRFdate2.Size = new System.Drawing.Size(46, 15);
            this.lblBRFdate2.TabIndex = 60;
            this.lblBRFdate2.Text = "Date In";
            // 
            // dtEPD
            // 
            this.dtEPD.Location = new System.Drawing.Point(248, 179);
            this.dtEPD.Name = "dtEPD";
            this.dtEPD.Size = new System.Drawing.Size(198, 21);
            this.dtEPD.TabIndex = 58;
            // 
            // lblBRFitem
            // 
            this.lblBRFitem.AutoSize = true;
            this.lblBRFitem.BackColor = System.Drawing.Color.Transparent;
            this.lblBRFitem.ForeColor = System.Drawing.Color.Black;
            this.lblBRFitem.Location = new System.Drawing.Point(105, 184);
            this.lblBRFitem.Name = "lblBRFitem";
            this.lblBRFitem.Size = new System.Drawing.Size(91, 15);
            this.lblBRFitem.TabIndex = 57;
            this.lblBRFitem.Text = "Expiration Date";
            // 
            // cbCat
            // 
            this.cbCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(249, 148);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(198, 23);
            this.cbCat.TabIndex = 56;
            // 
            // lblBRFoffice
            // 
            this.lblBRFoffice.AutoSize = true;
            this.lblBRFoffice.BackColor = System.Drawing.Color.Transparent;
            this.lblBRFoffice.ForeColor = System.Drawing.Color.Black;
            this.lblBRFoffice.Location = new System.Drawing.Point(105, 151);
            this.lblBRFoffice.Name = "lblBRFoffice";
            this.lblBRFoffice.Size = new System.Drawing.Size(55, 15);
            this.lblBRFoffice.TabIndex = 55;
            this.lblBRFoffice.Text = "Category";
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(249, 89);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(198, 21);
            this.txtSKU.TabIndex = 54;
            // 
            // lblBRFname
            // 
            this.lblBRFname.AutoSize = true;
            this.lblBRFname.BackColor = System.Drawing.Color.Transparent;
            this.lblBRFname.ForeColor = System.Drawing.Color.Black;
            this.lblBRFname.Location = new System.Drawing.Point(105, 89);
            this.lblBRFname.Name = "lblBRFname";
            this.lblBRFname.Size = new System.Drawing.Size(32, 15);
            this.lblBRFname.TabIndex = 53;
            this.lblBRFname.Text = "SKU";
            // 
            // gbBRF
            // 
            this.gbBRF.BackColor = System.Drawing.Color.Transparent;
            this.gbBRF.Controls.Add(this.qtyRE);
            this.gbBRF.Controls.Add(this.numQty);
            this.gbBRF.Controls.Add(this.txtEName);
            this.gbBRF.Controls.Add(this.label1);
            this.gbBRF.Controls.Add(this.btnAddStocks);
            this.gbBRF.Controls.Add(this.dtDateIn);
            this.gbBRF.Controls.Add(this.lblBRFdate2);
            this.gbBRF.Controls.Add(this.dtEPD);
            this.gbBRF.Controls.Add(this.lblBRFitem);
            this.gbBRF.Controls.Add(this.cbCat);
            this.gbBRF.Controls.Add(this.lblBRFoffice);
            this.gbBRF.Controls.Add(this.txtSKU);
            this.gbBRF.Controls.Add(this.lblBRFname);
            this.gbBRF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBRF.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gbBRF.Location = new System.Drawing.Point(12, 12);
            this.gbBRF.Name = "gbBRF";
            this.gbBRF.Size = new System.Drawing.Size(549, 387);
            this.gbBRF.TabIndex = 1;
            this.gbBRF.TabStop = false;
            this.gbBRF.Text = "Borrower\'s Information";
            // 
            // AddStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 411);
            this.Controls.Add(this.gbBRF);
            this.Name = "AddStocks";
            this.Text = "AddStocks";
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.gbBRF.ResumeLayout(false);
            this.gbBRF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label qtyRE;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStocks;
        private System.Windows.Forms.DateTimePicker dtDateIn;
        private System.Windows.Forms.Label lblBRFdate2;
        private System.Windows.Forms.DateTimePicker dtEPD;
        private System.Windows.Forms.Label lblBRFitem;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Label lblBRFoffice;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label lblBRFname;
        private System.Windows.Forms.GroupBox gbBRF;
    }
}