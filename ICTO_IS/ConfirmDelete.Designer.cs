namespace ICTO_IS
{
    partial class ConfirmDelete
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
            this.lblCDpw = new System.Windows.Forms.Label();
            this.txtCDpw = new System.Windows.Forms.TextBox();
            this.btnCDsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCDpw
            // 
            this.lblCDpw.AutoSize = true;
            this.lblCDpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDpw.Location = new System.Drawing.Point(157, 45);
            this.lblCDpw.Name = "lblCDpw";
            this.lblCDpw.Size = new System.Drawing.Size(130, 16);
            this.lblCDpw.TabIndex = 77;
            this.lblCDpw.Text = "Enter your password";
            // 
            // txtCDpw
            // 
            this.txtCDpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCDpw.Location = new System.Drawing.Point(137, 77);
            this.txtCDpw.Name = "txtCDpw";
            this.txtCDpw.PasswordChar = '*';
            this.txtCDpw.Size = new System.Drawing.Size(169, 22);
            this.txtCDpw.TabIndex = 76;
            // 
            // btnCDsubmit
            // 
            this.btnCDsubmit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCDsubmit.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnCDsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCDsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCDsubmit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCDsubmit.Location = new System.Drawing.Point(178, 144);
            this.btnCDsubmit.Name = "btnCDsubmit";
            this.btnCDsubmit.Size = new System.Drawing.Size(89, 31);
            this.btnCDsubmit.TabIndex = 78;
            this.btnCDsubmit.Text = "Submit";
            this.btnCDsubmit.UseVisualStyleBackColor = false;
            this.btnCDsubmit.Click += new System.EventHandler(this.btnCDsubmit_Click);
            // 
            // ConfirmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(434, 196);
            this.Controls.Add(this.btnCDsubmit);
            this.Controls.Add(this.lblCDpw);
            this.Controls.Add(this.txtCDpw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConfirmDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConfirmDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCDpw;
        private System.Windows.Forms.TextBox txtCDpw;
        private System.Windows.Forms.Button btnCDsubmit;
    }
}