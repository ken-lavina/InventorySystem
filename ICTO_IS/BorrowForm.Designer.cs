namespace ICTO_IS
{
    partial class BorrowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowForm));
            this.gbBRF = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qtyRE = new System.Windows.Forms.Label();
            this.numREqty = new System.Windows.Forms.NumericUpDown();
            this.cbBRFeqp = new System.Windows.Forms.ComboBox();
            this.txtBRFid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBRFadd = new System.Windows.Forms.Button();
            this.dtpBRF2 = new System.Windows.Forms.DateTimePicker();
            this.lblBRFdate2 = new System.Windows.Forms.Label();
            this.lblBRFdate1 = new System.Windows.Forms.Label();
            this.dtpBRF1 = new System.Windows.Forms.DateTimePicker();
            this.lblBRFitem = new System.Windows.Forms.Label();
            this.cbBRFoffice = new System.Windows.Forms.ComboBox();
            this.lblBRFoffice = new System.Windows.Forms.Label();
            this.txtBRFname = new System.Windows.Forms.TextBox();
            this.lblBRFname = new System.Windows.Forms.Label();
            this.gbBRF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numREqty)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBRF
            // 
            this.gbBRF.BackColor = System.Drawing.Color.Transparent;
            this.gbBRF.Controls.Add(this.label3);
            this.gbBRF.Controls.Add(this.label2);
            this.gbBRF.Controls.Add(this.qtyRE);
            this.gbBRF.Controls.Add(this.numREqty);
            this.gbBRF.Controls.Add(this.cbBRFeqp);
            this.gbBRF.Controls.Add(this.txtBRFid);
            this.gbBRF.Controls.Add(this.label1);
            this.gbBRF.Controls.Add(this.btnBRFadd);
            this.gbBRF.Controls.Add(this.dtpBRF2);
            this.gbBRF.Controls.Add(this.lblBRFdate2);
            this.gbBRF.Controls.Add(this.lblBRFdate1);
            this.gbBRF.Controls.Add(this.dtpBRF1);
            this.gbBRF.Controls.Add(this.lblBRFitem);
            this.gbBRF.Controls.Add(this.cbBRFoffice);
            this.gbBRF.Controls.Add(this.lblBRFoffice);
            this.gbBRF.Controls.Add(this.txtBRFname);
            this.gbBRF.Controls.Add(this.lblBRFname);
            this.gbBRF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBRF.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gbBRF.Location = new System.Drawing.Point(12, 12);
            this.gbBRF.Name = "gbBRF";
            this.gbBRF.Size = new System.Drawing.Size(549, 387);
            this.gbBRF.TabIndex = 0;
            this.gbBRF.TabStop = false;
            this.gbBRF.Text = "Borrower\'s Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(249, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 69;
            this.label3.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 68;
            this.label2.Text = "Issued by";
            // 
            // qtyRE
            // 
            this.qtyRE.AutoSize = true;
            this.qtyRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyRE.ForeColor = System.Drawing.Color.White;
            this.qtyRE.Location = new System.Drawing.Point(108, 175);
            this.qtyRE.Name = "qtyRE";
            this.qtyRE.Size = new System.Drawing.Size(51, 15);
            this.qtyRE.TabIndex = 67;
            this.qtyRE.Text = "Quantity";
            this.qtyRE.Visible = false;
            // 
            // numREqty
            // 
            this.numREqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numREqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numREqty.Location = new System.Drawing.Point(251, 172);
            this.numREqty.Name = "numREqty";
            this.numREqty.Size = new System.Drawing.Size(77, 21);
            this.numREqty.TabIndex = 66;
            this.numREqty.Visible = false;
            // 
            // cbBRFeqp
            // 
            this.cbBRFeqp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBRFeqp.FormattingEnabled = true;
            this.cbBRFeqp.Location = new System.Drawing.Point(252, 139);
            this.cbBRFeqp.Name = "cbBRFeqp";
            this.cbBRFeqp.Size = new System.Drawing.Size(198, 23);
            this.cbBRFeqp.TabIndex = 65;
            // 
            // txtBRFid
            // 
            this.txtBRFid.Location = new System.Drawing.Point(252, 76);
            this.txtBRFid.Name = "txtBRFid";
            this.txtBRFid.Size = new System.Drawing.Size(198, 21);
            this.txtBRFid.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 63;
            this.label1.Text = "Employee Number";
            // 
            // btnBRFadd
            // 
            this.btnBRFadd.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBRFadd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBRFadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBRFadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBRFadd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBRFadd.Location = new System.Drawing.Point(447, 337);
            this.btnBRFadd.Name = "btnBRFadd";
            this.btnBRFadd.Size = new System.Drawing.Size(87, 34);
            this.btnBRFadd.TabIndex = 62;
            this.btnBRFadd.Text = "Add to List";
            this.btnBRFadd.UseVisualStyleBackColor = false;
            this.btnBRFadd.Click += new System.EventHandler(this.btnBRFadd_Click_1);
            // 
            // dtpBRF2
            // 
            this.dtpBRF2.Location = new System.Drawing.Point(251, 260);
            this.dtpBRF2.Name = "dtpBRF2";
            this.dtpBRF2.Size = new System.Drawing.Size(198, 21);
            this.dtpBRF2.TabIndex = 61;
            // 
            // lblBRFdate2
            // 
            this.lblBRFdate2.AutoSize = true;
            this.lblBRFdate2.BackColor = System.Drawing.Color.Transparent;
            this.lblBRFdate2.ForeColor = System.Drawing.Color.White;
            this.lblBRFdate2.Location = new System.Drawing.Point(107, 262);
            this.lblBRFdate2.Name = "lblBRFdate2";
            this.lblBRFdate2.Size = new System.Drawing.Size(87, 15);
            this.lblBRFdate2.TabIndex = 60;
            this.lblBRFdate2.Text = "Date Returned";
            // 
            // lblBRFdate1
            // 
            this.lblBRFdate1.AutoSize = true;
            this.lblBRFdate1.BackColor = System.Drawing.Color.Transparent;
            this.lblBRFdate1.ForeColor = System.Drawing.Color.White;
            this.lblBRFdate1.Location = new System.Drawing.Point(107, 233);
            this.lblBRFdate1.Name = "lblBRFdate1";
            this.lblBRFdate1.Size = new System.Drawing.Size(98, 15);
            this.lblBRFdate1.TabIndex = 59;
            this.lblBRFdate1.Text = "Date of Issuance";
            this.lblBRFdate1.Click += new System.EventHandler(this.lblBRFdate1_Click);
            // 
            // dtpBRF1
            // 
            this.dtpBRF1.Location = new System.Drawing.Point(251, 228);
            this.dtpBRF1.Name = "dtpBRF1";
            this.dtpBRF1.Size = new System.Drawing.Size(198, 21);
            this.dtpBRF1.TabIndex = 58;
            // 
            // lblBRFitem
            // 
            this.lblBRFitem.AutoSize = true;
            this.lblBRFitem.BackColor = System.Drawing.Color.Transparent;
            this.lblBRFitem.ForeColor = System.Drawing.Color.White;
            this.lblBRFitem.Location = new System.Drawing.Point(108, 142);
            this.lblBRFitem.Name = "lblBRFitem";
            this.lblBRFitem.Size = new System.Drawing.Size(131, 15);
            this.lblBRFitem.TabIndex = 57;
            this.lblBRFitem.Text = "Item/Equipment Name";
            // 
            // cbBRFoffice
            // 
            this.cbBRFoffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBRFoffice.FormattingEnabled = true;
            this.cbBRFoffice.Location = new System.Drawing.Point(252, 106);
            this.cbBRFoffice.Name = "cbBRFoffice";
            this.cbBRFoffice.Size = new System.Drawing.Size(198, 23);
            this.cbBRFoffice.TabIndex = 56;
            // 
            // lblBRFoffice
            // 
            this.lblBRFoffice.AutoSize = true;
            this.lblBRFoffice.BackColor = System.Drawing.Color.Transparent;
            this.lblBRFoffice.ForeColor = System.Drawing.Color.White;
            this.lblBRFoffice.Location = new System.Drawing.Point(108, 109);
            this.lblBRFoffice.Name = "lblBRFoffice";
            this.lblBRFoffice.Size = new System.Drawing.Size(106, 15);
            this.lblBRFoffice.TabIndex = 55;
            this.lblBRFoffice.Text = "Department/Office";
            // 
            // txtBRFname
            // 
            this.txtBRFname.Location = new System.Drawing.Point(252, 47);
            this.txtBRFname.Name = "txtBRFname";
            this.txtBRFname.Size = new System.Drawing.Size(198, 21);
            this.txtBRFname.TabIndex = 54;
            // 
            // lblBRFname
            // 
            this.lblBRFname.AutoSize = true;
            this.lblBRFname.BackColor = System.Drawing.Color.Transparent;
            this.lblBRFname.ForeColor = System.Drawing.Color.White;
            this.lblBRFname.Location = new System.Drawing.Point(108, 47);
            this.lblBRFname.Name = "lblBRFname";
            this.lblBRFname.Size = new System.Drawing.Size(41, 15);
            this.lblBRFname.TabIndex = 53;
            this.lblBRFname.Text = "Name";
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(573, 411);
            this.Controls.Add(this.gbBRF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BorrowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbBRF.ResumeLayout(false);
            this.gbBRF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numREqty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBRF;
        private System.Windows.Forms.ComboBox cbBRFeqp;
        private System.Windows.Forms.TextBox txtBRFid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBRFadd;
        private System.Windows.Forms.DateTimePicker dtpBRF2;
        private System.Windows.Forms.Label lblBRFdate2;
        private System.Windows.Forms.Label lblBRFdate1;
        private System.Windows.Forms.DateTimePicker dtpBRF1;
        private System.Windows.Forms.Label lblBRFitem;
        private System.Windows.Forms.ComboBox cbBRFoffice;
        private System.Windows.Forms.Label lblBRFoffice;
        private System.Windows.Forms.TextBox txtBRFname;
        private System.Windows.Forms.Label lblBRFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label qtyRE;
        private System.Windows.Forms.NumericUpDown numREqty;
    }
}