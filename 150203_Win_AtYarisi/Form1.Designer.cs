namespace _150203_Win_AtYarisi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli designer değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        ///Designer desteği için gerekli metottur; bu metodun
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BOZOK = new System.Windows.Forms.PictureBox();
            this.TOMPAK = new System.Windows.Forms.PictureBox();
            this.SAYPAK = new System.Windows.Forms.PictureBox();
            this.KOŞKUN = new System.Windows.Forms.PictureBox();
            this.SÖĞÜŞ = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BOZOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOMPAK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SAYPAK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KOŞKUN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SÖĞÜŞ)).BeginInit();
            this.SuspendLayout();
            // 
            // BOZOK
            // 
            this.BOZOK.Enabled = false;
            this.BOZOK.Image = ((System.Drawing.Image)(resources.GetObject("BOZOK.Image")));
            this.BOZOK.Location = new System.Drawing.Point(12, 44);
            this.BOZOK.Name = "BOZOK";
            this.BOZOK.Size = new System.Drawing.Size(118, 89);
            this.BOZOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BOZOK.TabIndex = 0;
            this.BOZOK.TabStop = false;
            // 
            // TOMPAK
            // 
            this.TOMPAK.Enabled = false;
            this.TOMPAK.Image = ((System.Drawing.Image)(resources.GetObject("TOMPAK.Image")));
            this.TOMPAK.Location = new System.Drawing.Point(12, 140);
            this.TOMPAK.Name = "TOMPAK";
            this.TOMPAK.Size = new System.Drawing.Size(118, 89);
            this.TOMPAK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TOMPAK.TabIndex = 0;
            this.TOMPAK.TabStop = false;
            // 
            // SAYPAK
            // 
            this.SAYPAK.Enabled = false;
            this.SAYPAK.Image = ((System.Drawing.Image)(resources.GetObject("SAYPAK.Image")));
            this.SAYPAK.Location = new System.Drawing.Point(12, 236);
            this.SAYPAK.Name = "SAYPAK";
            this.SAYPAK.Size = new System.Drawing.Size(118, 89);
            this.SAYPAK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SAYPAK.TabIndex = 0;
            this.SAYPAK.TabStop = false;
            // 
            // KOŞKUN
            // 
            this.KOŞKUN.Enabled = false;
            this.KOŞKUN.Image = ((System.Drawing.Image)(resources.GetObject("KOŞKUN.Image")));
            this.KOŞKUN.Location = new System.Drawing.Point(12, 332);
            this.KOŞKUN.Name = "KOŞKUN";
            this.KOŞKUN.Size = new System.Drawing.Size(118, 89);
            this.KOŞKUN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KOŞKUN.TabIndex = 0;
            this.KOŞKUN.TabStop = false;
            // 
            // SÖĞÜŞ
            // 
            this.SÖĞÜŞ.Enabled = false;
            this.SÖĞÜŞ.Image = ((System.Drawing.Image)(resources.GetObject("SÖĞÜŞ.Image")));
            this.SÖĞÜŞ.Location = new System.Drawing.Point(12, 428);
            this.SÖĞÜŞ.Name = "SÖĞÜŞ";
            this.SÖĞÜŞ.Size = new System.Drawing.Size(118, 89);
            this.SÖĞÜŞ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SÖĞÜŞ.TabIndex = 0;
            this.SÖĞÜŞ.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(874, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 471);
            this.label1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "BAŞLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "OZIKOWARE I. Geleneksel E-At Yarışları";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(522, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "BOZOK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(582, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "TOMPAK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(656, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "SAYPAK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(724, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "KOSKUN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(796, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 27);
            this.label7.TabIndex = 4;
            this.label7.Text = "SÖGÜS";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(244, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(376, 121);
            this.button2.TabIndex = 5;
            this.button2.Text = "YENİDEN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 524);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SÖĞÜŞ);
            this.Controls.Add(this.KOŞKUN);
            this.Controls.Add(this.SAYPAK);
            this.Controls.Add(this.TOMPAK);
            this.Controls.Add(this.BOZOK);
            this.Font = new System.Drawing.Font("Old English Text MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sakatat Yarışması Şeysi (OZIKOWARE Şubat 2015)";
            ((System.ComponentModel.ISupportInitialize)(this.BOZOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOMPAK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SAYPAK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KOŞKUN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SÖĞÜŞ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BOZOK;
        private System.Windows.Forms.PictureBox TOMPAK;
        private System.Windows.Forms.PictureBox SAYPAK;
        private System.Windows.Forms.PictureBox KOŞKUN;
        private System.Windows.Forms.PictureBox SÖĞÜŞ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}

