namespace LİNQproje
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSayilarTam = new System.Windows.Forms.Button();
            this.btnNegatif = new System.Windows.Forms.Button();
            this.btnPozitif = new System.Windows.Forms.Button();
            this.ciftBtn = new System.Windows.Forms.Button();
            this.btnTek = new System.Windows.Forms.Button();
            this.AdetBtn = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.Alfabetik = new System.Windows.Forms.Button();
            this.btnBulunan = new System.Windows.Forms.Button();
            this.Uzunluk = new System.Windows.Forms.Button();
            this.Ters = new System.Windows.Forms.Button();
            this.Son5 = new System.Windows.Forms.Button();
            this.Top5 = new System.Windows.Forms.Button();
            this.SadeceTarih = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.YangWang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(28, 316);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 274);
            this.listBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 274);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnSayilarTam
            // 
            this.btnSayilarTam.Location = new System.Drawing.Point(12, 22);
            this.btnSayilarTam.Name = "btnSayilarTam";
            this.btnSayilarTam.Size = new System.Drawing.Size(129, 63);
            this.btnSayilarTam.TabIndex = 2;
            this.btnSayilarTam.Text = "Sayilar";
            this.btnSayilarTam.UseVisualStyleBackColor = true;
            this.btnSayilarTam.Click += new System.EventHandler(this.btnSayilarTam_Click);
            // 
            // btnNegatif
            // 
            this.btnNegatif.Location = new System.Drawing.Point(147, 22);
            this.btnNegatif.Name = "btnNegatif";
            this.btnNegatif.Size = new System.Drawing.Size(129, 63);
            this.btnNegatif.TabIndex = 3;
            this.btnNegatif.Text = "Negatif Sayilar";
            this.btnNegatif.UseVisualStyleBackColor = true;
            this.btnNegatif.Click += new System.EventHandler(this.btnNegatif_Click);
            // 
            // btnPozitif
            // 
            this.btnPozitif.Location = new System.Drawing.Point(282, 22);
            this.btnPozitif.Name = "btnPozitif";
            this.btnPozitif.Size = new System.Drawing.Size(129, 63);
            this.btnPozitif.TabIndex = 4;
            this.btnPozitif.Text = "Pozitif Sayilar";
            this.btnPozitif.UseVisualStyleBackColor = true;
            this.btnPozitif.Click += new System.EventHandler(this.btnPozitif_Click);
            // 
            // ciftBtn
            // 
            this.ciftBtn.Location = new System.Drawing.Point(417, 22);
            this.ciftBtn.Name = "ciftBtn";
            this.ciftBtn.Size = new System.Drawing.Size(129, 63);
            this.ciftBtn.TabIndex = 5;
            this.ciftBtn.Text = "Cift Sayilar";
            this.ciftBtn.UseVisualStyleBackColor = true;
            this.ciftBtn.Click += new System.EventHandler(this.ciftBtn_Click);
            // 
            // btnTek
            // 
            this.btnTek.Location = new System.Drawing.Point(564, 22);
            this.btnTek.Name = "btnTek";
            this.btnTek.Size = new System.Drawing.Size(129, 63);
            this.btnTek.TabIndex = 6;
            this.btnTek.Text = "Tek Sayilar";
            this.btnTek.UseVisualStyleBackColor = true;
            this.btnTek.Click += new System.EventHandler(this.btnTek_Click);
            // 
            // AdetBtn
            // 
            this.AdetBtn.Location = new System.Drawing.Point(969, 22);
            this.AdetBtn.Name = "AdetBtn";
            this.AdetBtn.Size = new System.Drawing.Size(129, 63);
            this.AdetBtn.TabIndex = 7;
            this.AdetBtn.Text = "Adet";
            this.AdetBtn.UseVisualStyleBackColor = true;
            this.AdetBtn.Click += new System.EventHandler(this.AdetBtn_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(834, 22);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(129, 63);
            this.btnMin.TabIndex = 8;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(699, 22);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(129, 63);
            this.btnMax.TabIndex = 9;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.button3_Click);
            // 
            // Alfabetik
            // 
            this.Alfabetik.Location = new System.Drawing.Point(282, 113);
            this.Alfabetik.Name = "Alfabetik";
            this.Alfabetik.Size = new System.Drawing.Size(129, 63);
            this.Alfabetik.TabIndex = 10;
            this.Alfabetik.Text = "Alfabetik";
            this.Alfabetik.UseVisualStyleBackColor = true;
            this.Alfabetik.Click += new System.EventHandler(this.Alfabetik_Click);
            // 
            // btnBulunan
            // 
            this.btnBulunan.Location = new System.Drawing.Point(699, 113);
            this.btnBulunan.Name = "btnBulunan";
            this.btnBulunan.Size = new System.Drawing.Size(129, 63);
            this.btnBulunan.TabIndex = 11;
            this.btnBulunan.Text = "M Bulunan";
            this.btnBulunan.UseVisualStyleBackColor = true;
            this.btnBulunan.Click += new System.EventHandler(this.btnBulunan_Click);
            // 
            // Uzunluk
            // 
            this.Uzunluk.Location = new System.Drawing.Point(564, 113);
            this.Uzunluk.Name = "Uzunluk";
            this.Uzunluk.Size = new System.Drawing.Size(129, 63);
            this.Uzunluk.TabIndex = 12;
            this.Uzunluk.Text = "Uzunluk";
            this.Uzunluk.UseVisualStyleBackColor = true;
            this.Uzunluk.Click += new System.EventHandler(this.Uzunluk_Click);
            // 
            // Ters
            // 
            this.Ters.Location = new System.Drawing.Point(417, 113);
            this.Ters.Name = "Ters";
            this.Ters.Size = new System.Drawing.Size(129, 63);
            this.Ters.TabIndex = 13;
            this.Ters.Text = "Tersten Alfabetik";
            this.Ters.UseVisualStyleBackColor = true;
            this.Ters.Click += new System.EventHandler(this.Ters_Click);
            // 
            // Son5
            // 
            this.Son5.Location = new System.Drawing.Point(564, 217);
            this.Son5.Name = "Son5";
            this.Son5.Size = new System.Drawing.Size(129, 63);
            this.Son5.TabIndex = 14;
            this.Son5.Text = "Son5";
            this.Son5.UseVisualStyleBackColor = true;
            this.Son5.Click += new System.EventHandler(this.Son5_Click);
            // 
            // Top5
            // 
            this.Top5.Location = new System.Drawing.Point(429, 217);
            this.Top5.Name = "Top5";
            this.Top5.Size = new System.Drawing.Size(129, 63);
            this.Top5.TabIndex = 15;
            this.Top5.Text = "Top5";
            this.Top5.UseVisualStyleBackColor = true;
            this.Top5.Click += new System.EventHandler(this.Top5_Click);
            // 
            // SadeceTarih
            // 
            this.SadeceTarih.Location = new System.Drawing.Point(282, 217);
            this.SadeceTarih.Name = "SadeceTarih";
            this.SadeceTarih.Size = new System.Drawing.Size(129, 63);
            this.SadeceTarih.TabIndex = 16;
            this.SadeceTarih.Text = "SadeceTarih";
            this.SadeceTarih.UseVisualStyleBackColor = true;
            this.SadeceTarih.Click += new System.EventHandler(this.SadeceTarih_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.Location = new System.Drawing.Point(147, 217);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(129, 63);
            this.btnSiparis.TabIndex = 17;
            this.btnSiparis.Text = "Sipariş Bilgi";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // YangWang
            // 
            this.YangWang.Location = new System.Drawing.Point(715, 217);
            this.YangWang.Name = "YangWang";
            this.YangWang.Size = new System.Drawing.Size(129, 63);
            this.YangWang.TabIndex = 18;
            this.YangWang.Text = "YangWang";
            this.YangWang.UseVisualStyleBackColor = true;
            this.YangWang.Click += new System.EventHandler(this.YangWang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 651);
            this.Controls.Add(this.YangWang);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.SadeceTarih);
            this.Controls.Add(this.Top5);
            this.Controls.Add(this.Son5);
            this.Controls.Add(this.Ters);
            this.Controls.Add(this.Uzunluk);
            this.Controls.Add(this.btnBulunan);
            this.Controls.Add(this.Alfabetik);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.AdetBtn);
            this.Controls.Add(this.btnTek);
            this.Controls.Add(this.ciftBtn);
            this.Controls.Add(this.btnPozitif);
            this.Controls.Add(this.btnNegatif);
            this.Controls.Add(this.btnSayilarTam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSayilarTam;
        private System.Windows.Forms.Button btnNegatif;
        private System.Windows.Forms.Button btnPozitif;
        private System.Windows.Forms.Button ciftBtn;
        private System.Windows.Forms.Button btnTek;
        private System.Windows.Forms.Button AdetBtn;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button Alfabetik;
        private System.Windows.Forms.Button btnBulunan;
        private System.Windows.Forms.Button Uzunluk;
        private System.Windows.Forms.Button Ters;
        private System.Windows.Forms.Button Son5;
        private System.Windows.Forms.Button Top5;
        private System.Windows.Forms.Button SadeceTarih;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button YangWang;
    }
}

