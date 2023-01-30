namespace md5
{
    partial class frmmd5
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
            this.lblmetin = new System.Windows.Forms.Label();
            this.lblSifrelenen = new System.Windows.Forms.Label();
            this.lblCozulen = new System.Windows.Forms.Label();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.txtSifrelenen = new System.Windows.Forms.TextBox();
            this.txtCozulen = new System.Windows.Forms.TextBox();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmetin
            // 
            this.lblmetin.AutoSize = true;
            this.lblmetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmetin.Location = new System.Drawing.Point(28, 16);
            this.lblmetin.Name = "lblmetin";
            this.lblmetin.Size = new System.Drawing.Size(49, 18);
            this.lblmetin.TabIndex = 0;
            this.lblmetin.Text = "Metin";
            // 
            // lblSifrelenen
            // 
            this.lblSifrelenen.AutoSize = true;
            this.lblSifrelenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifrelenen.Location = new System.Drawing.Point(28, 61);
            this.lblSifrelenen.Name = "lblSifrelenen";
            this.lblSifrelenen.Size = new System.Drawing.Size(83, 18);
            this.lblSifrelenen.TabIndex = 1;
            this.lblSifrelenen.Text = "Şifrelenen";
            // 
            // lblCozulen
            // 
            this.lblCozulen.AutoSize = true;
            this.lblCozulen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCozulen.Location = new System.Drawing.Point(28, 104);
            this.lblCozulen.Name = "lblCozulen";
            this.lblCozulen.Size = new System.Drawing.Size(70, 18);
            this.lblCozulen.TabIndex = 2;
            this.lblCozulen.Text = "Çözülen";
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(148, 17);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(241, 20);
            this.txtMetin.TabIndex = 3;
            this.txtMetin.TextChanged += new System.EventHandler(this.txtMetin_TextChanged);
            // 
            // txtSifrelenen
            // 
            this.txtSifrelenen.Location = new System.Drawing.Point(148, 61);
            this.txtSifrelenen.Name = "txtSifrelenen";
            this.txtSifrelenen.Size = new System.Drawing.Size(241, 20);
            this.txtSifrelenen.TabIndex = 4;
            // 
            // txtCozulen
            // 
            this.txtCozulen.Location = new System.Drawing.Point(148, 104);
            this.txtCozulen.Name = "txtCozulen";
            this.txtCozulen.Size = new System.Drawing.Size(241, 20);
            this.txtCozulen.TabIndex = 5;
            // 
            // btnSifrele
            // 
            this.btnSifrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifrele.Location = new System.Drawing.Point(250, 146);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(139, 37);
            this.btnSifrele.TabIndex = 6;
            this.btnSifrele.Text = "Şifrele/Çöz";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmmd5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 207);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.txtCozulen);
            this.Controls.Add(this.txtSifrelenen);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.lblCozulen);
            this.Controls.Add(this.lblSifrelenen);
            this.Controls.Add(this.lblmetin);
            this.Name = "frmmd5";
            this.Text = "MD5 ile Şifreleme";
            this.Load += new System.EventHandler(this.frmmd5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmetin;
        private System.Windows.Forms.Label lblSifrelenen;
        private System.Windows.Forms.Label lblCozulen;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.TextBox txtSifrelenen;
        private System.Windows.Forms.TextBox txtCozulen;
        private System.Windows.Forms.Button btnSifrele;
    }
}

