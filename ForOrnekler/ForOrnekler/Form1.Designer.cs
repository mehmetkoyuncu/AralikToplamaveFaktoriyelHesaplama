namespace ForOrnekler
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
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
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.lblFirstResult = new System.Windows.Forms.Label();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblFactResult = new System.Windows.Forms.Label();
            this.btnFaktoriyel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSecondResult = new System.Windows.Forms.Label();
            this.txtFaktoriyelSayi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(30, 33);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(81, 166);
            this.listBox1.TabIndex = 0;
            // 
            // btnTopla
            // 
            this.btnTopla.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopla.Location = new System.Drawing.Point(191, 149);
            this.btnTopla.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(50, 34);
            this.btnTopla.TabIndex = 1;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // lblFirstResult
            // 
            this.lblFirstResult.AutoSize = true;
            this.lblFirstResult.BackColor = System.Drawing.Color.Maroon;
            this.lblFirstResult.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFirstResult.Location = new System.Drawing.Point(214, 191);
            this.lblFirstResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstResult.Name = "lblFirstResult";
            this.lblFirstResult.Size = new System.Drawing.Size(0, 18);
            this.lblFirstResult.TabIndex = 2;
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirstNumber.Location = new System.Drawing.Point(133, 59);
            this.txtFirstNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(108, 26);
            this.txtFirstNumber.TabIndex = 3;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSecondNumber.Location = new System.Drawing.Point(133, 115);
            this.txtSecondNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(107, 26);
            this.txtSecondNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(130, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitiş Sayısını Giriniz..";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(131, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Başlangıç Sayısını Giriniz..";
            // 
            // lblSumResult
            // 
            this.lblSumResult.AutoSize = true;
            this.lblSumResult.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSumResult.Location = new System.Drawing.Point(141, 191);
            this.lblSumResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSumResult.Name = "lblSumResult";
            this.lblSumResult.Size = new System.Drawing.Size(46, 18);
            this.lblSumResult.TabIndex = 5;
            this.lblSumResult.Text = "SONUÇ : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.lblSumResult);
            this.groupBox1.Controls.Add(this.btnTopla);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblFirstResult);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFirstNumber);
            this.groupBox1.Controls.Add(this.txtSecondNumber);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 231);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toplam Aralık";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.lblFactResult);
            this.groupBox2.Controls.Add(this.btnFaktoriyel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblSecondResult);
            this.groupBox2.Controls.Add(this.txtFaktoriyelSayi);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(312, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 231);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faktoriyel";
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(30, 33);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(81, 166);
            this.listBox2.TabIndex = 0;
            // 
            // lblFactResult
            // 
            this.lblFactResult.AutoSize = true;
            this.lblFactResult.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFactResult.Location = new System.Drawing.Point(137, 147);
            this.lblFactResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFactResult.Name = "lblFactResult";
            this.lblFactResult.Size = new System.Drawing.Size(46, 18);
            this.lblFactResult.TabIndex = 5;
            this.lblFactResult.Text = "SONUÇ : ";
            // 
            // btnFaktoriyel
            // 
            this.btnFaktoriyel.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaktoriyel.Location = new System.Drawing.Point(168, 84);
            this.btnFaktoriyel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFaktoriyel.Name = "btnFaktoriyel";
            this.btnFaktoriyel.Size = new System.Drawing.Size(54, 34);
            this.btnFaktoriyel.TabIndex = 1;
            this.btnFaktoriyel.Text = "Hesapla";
            this.btnFaktoriyel.UseVisualStyleBackColor = true;
            this.btnFaktoriyel.Click += new System.EventHandler(this.btnFaktoriyel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(112, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sayiyi Giriniz..";
            // 
            // lblSecondResult
            // 
            this.lblSecondResult.AutoSize = true;
            this.lblSecondResult.BackColor = System.Drawing.Color.Maroon;
            this.lblSecondResult.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecondResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSecondResult.Location = new System.Drawing.Point(201, 147);
            this.lblSecondResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecondResult.Name = "lblSecondResult";
            this.lblSecondResult.Size = new System.Drawing.Size(0, 18);
            this.lblSecondResult.TabIndex = 2;
            // 
            // txtFaktoriyelSayi
            // 
            this.txtFaktoriyelSayi.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFaktoriyelSayi.Location = new System.Drawing.Point(114, 49);
            this.txtFaktoriyelSayi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFaktoriyelSayi.Name = "txtFaktoriyelSayi";
            this.txtFaktoriyelSayi.Size = new System.Drawing.Size(108, 26);
            this.txtFaktoriyelSayi.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 260);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Label lblFirstResult;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblFactResult;
        private System.Windows.Forms.Button btnFaktoriyel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSecondResult;
        private System.Windows.Forms.TextBox txtFaktoriyelSayi;
    }
}

