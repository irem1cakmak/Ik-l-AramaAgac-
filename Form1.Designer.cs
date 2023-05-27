
namespace Arama_ağacı
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
            this.btn_DugumEkle = new System.Windows.Forms.Button();
            this.tb_dugumEkle = new System.Windows.Forms.TextBox();
            this.lb_dugumEkle = new System.Windows.Forms.Label();
            this.lb_dugumSil = new System.Windows.Forms.Label();
            this.tb_dugumSil = new System.Windows.Forms.TextBox();
            this.btn_DugumSil = new System.Windows.Forms.Button();
            this.lb_dugumBul = new System.Windows.Forms.Label();
            this.tb_dugumBul = new System.Windows.Forms.TextBox();
            this.btn_DugumBul = new System.Windows.Forms.Button();
            this.btn_dugumGoster = new System.Windows.Forms.Button();
            this.rtb_dugumGoster = new System.Windows.Forms.RichTextBox();
            this.btn_agacBilgiGoster = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lb_yapraklar = new System.Windows.Forms.Label();
            this.tb_Yapraklar = new System.Windows.Forms.TextBox();
            this.lb_agacYuksekligi = new System.Windows.Forms.Label();
            this.tb_AgacYuksekligi = new System.Windows.Forms.TextBox();
            this.lb_dugumSayisi = new System.Windows.Forms.Label();
            this.tb_DugumSayisi = new System.Windows.Forms.TextBox();
            this.lb_postorder = new System.Windows.Forms.Label();
            this.tb_Postorder = new System.Windows.Forms.TextBox();
            this.lb_inorder = new System.Windows.Forms.Label();
            this.tb_Inorder = new System.Windows.Forms.TextBox();
            this.lb_preorder = new System.Windows.Forms.Label();
            this.tb_Preorder = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DugumEkle
            // 
            this.btn_DugumEkle.Location = new System.Drawing.Point(310, 22);
            this.btn_DugumEkle.Name = "btn_DugumEkle";
            this.btn_DugumEkle.Size = new System.Drawing.Size(132, 32);
            this.btn_DugumEkle.TabIndex = 0;
            this.btn_DugumEkle.Text = "Düğümü Ekle";
            this.btn_DugumEkle.UseVisualStyleBackColor = true;
            this.btn_DugumEkle.Click += new System.EventHandler(this.btn_DugumEkle_Click);
            // 
            // tb_dugumEkle
            // 
            this.tb_dugumEkle.Location = new System.Drawing.Point(153, 29);
            this.tb_dugumEkle.Name = "tb_dugumEkle";
            this.tb_dugumEkle.Size = new System.Drawing.Size(151, 22);
            this.tb_dugumEkle.TabIndex = 1;
            // 
            // lb_dugumEkle
            // 
            this.lb_dugumEkle.AutoSize = true;
            this.lb_dugumEkle.Location = new System.Drawing.Point(12, 29);
            this.lb_dugumEkle.Name = "lb_dugumEkle";
            this.lb_dugumEkle.Size = new System.Drawing.Size(110, 17);
            this.lb_dugumEkle.TabIndex = 2;
            this.lb_dugumEkle.Text = "Düğümü eklendi";
            // 
            // lb_dugumSil
            // 
            this.lb_dugumSil.AutoSize = true;
            this.lb_dugumSil.Location = new System.Drawing.Point(12, 65);
            this.lb_dugumSil.Name = "lb_dugumSil";
            this.lb_dugumSil.Size = new System.Drawing.Size(110, 17);
            this.lb_dugumSil.TabIndex = 5;
            this.lb_dugumSil.Text = "Düğümü eklendi";
            // 
            // tb_dugumSil
            // 
            this.tb_dugumSil.Location = new System.Drawing.Point(153, 62);
            this.tb_dugumSil.Name = "tb_dugumSil";
            this.tb_dugumSil.Size = new System.Drawing.Size(151, 22);
            this.tb_dugumSil.TabIndex = 4;
            // 
            // btn_DugumSil
            // 
            this.btn_DugumSil.Location = new System.Drawing.Point(310, 57);
            this.btn_DugumSil.Name = "btn_DugumSil";
            this.btn_DugumSil.Size = new System.Drawing.Size(132, 32);
            this.btn_DugumSil.TabIndex = 3;
            this.btn_DugumSil.Text = "Düğümü Sil";
            this.btn_DugumSil.UseVisualStyleBackColor = true;
            this.btn_DugumSil.Click += new System.EventHandler(this.btn_DugumSil_Click);
            // 
            // lb_dugumBul
            // 
            this.lb_dugumBul.AutoSize = true;
            this.lb_dugumBul.Location = new System.Drawing.Point(12, 101);
            this.lb_dugumBul.Name = "lb_dugumBul";
            this.lb_dugumBul.Size = new System.Drawing.Size(116, 17);
            this.lb_dugumBul.TabIndex = 8;
            this.lb_dugumBul.Text = "Düğümün Düzeyi";
            // 
            // tb_dugumBul
            // 
            this.tb_dugumBul.Location = new System.Drawing.Point(153, 98);
            this.tb_dugumBul.Name = "tb_dugumBul";
            this.tb_dugumBul.Size = new System.Drawing.Size(151, 22);
            this.tb_dugumBul.TabIndex = 7;
            // 
            // btn_DugumBul
            // 
            this.btn_DugumBul.Location = new System.Drawing.Point(310, 93);
            this.btn_DugumBul.Name = "btn_DugumBul";
            this.btn_DugumBul.Size = new System.Drawing.Size(132, 32);
            this.btn_DugumBul.TabIndex = 6;
            this.btn_DugumBul.Text = "Düğümü Bul";
            this.btn_DugumBul.UseVisualStyleBackColor = true;
            this.btn_DugumBul.Click += new System.EventHandler(this.btn_DugumBul_Click);
            // 
            // btn_dugumGoster
            // 
            this.btn_dugumGoster.Location = new System.Drawing.Point(15, 145);
            this.btn_dugumGoster.Name = "btn_dugumGoster";
            this.btn_dugumGoster.Size = new System.Drawing.Size(427, 35);
            this.btn_dugumGoster.TabIndex = 9;
            this.btn_dugumGoster.Text = "Düğümleri Göster";
            this.btn_dugumGoster.UseVisualStyleBackColor = true;
            this.btn_dugumGoster.Click += new System.EventHandler(this.btn_dugumGoster_Click);
            // 
            // rtb_dugumGoster
            // 
            this.rtb_dugumGoster.Location = new System.Drawing.Point(15, 186);
            this.rtb_dugumGoster.Name = "rtb_dugumGoster";
            this.rtb_dugumGoster.Size = new System.Drawing.Size(427, 252);
            this.rtb_dugumGoster.TabIndex = 10;
            this.rtb_dugumGoster.Text = "";
            // 
            // btn_agacBilgiGoster
            // 
            this.btn_agacBilgiGoster.Location = new System.Drawing.Point(487, 22);
            this.btn_agacBilgiGoster.Name = "btn_agacBilgiGoster";
            this.btn_agacBilgiGoster.Size = new System.Drawing.Size(452, 35);
            this.btn_agacBilgiGoster.TabIndex = 11;
            this.btn_agacBilgiGoster.Text = "Eklenen Bilgileri Göster";
            this.btn_agacBilgiGoster.UseVisualStyleBackColor = true;
            this.btn_agacBilgiGoster.Click += new System.EventHandler(this.btn_agacBilgiGoster_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lb_yapraklar);
            this.groupBox.Controls.Add(this.tb_Yapraklar);
            this.groupBox.Controls.Add(this.lb_agacYuksekligi);
            this.groupBox.Controls.Add(this.tb_AgacYuksekligi);
            this.groupBox.Controls.Add(this.lb_dugumSayisi);
            this.groupBox.Controls.Add(this.tb_DugumSayisi);
            this.groupBox.Controls.Add(this.lb_postorder);
            this.groupBox.Controls.Add(this.tb_Postorder);
            this.groupBox.Controls.Add(this.lb_inorder);
            this.groupBox.Controls.Add(this.tb_Inorder);
            this.groupBox.Controls.Add(this.lb_preorder);
            this.groupBox.Controls.Add(this.tb_Preorder);
            this.groupBox.Location = new System.Drawing.Point(487, 65);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(452, 373);
            this.groupBox.TabIndex = 12;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Ağaç Bilgileri";
            // 
            // lb_yapraklar
            // 
            this.lb_yapraklar.AutoSize = true;
            this.lb_yapraklar.Location = new System.Drawing.Point(6, 183);
            this.lb_yapraklar.Name = "lb_yapraklar";
            this.lb_yapraklar.Size = new System.Drawing.Size(69, 17);
            this.lb_yapraklar.TabIndex = 22;
            this.lb_yapraklar.Text = "Yapraklar";
            // 
            // tb_Yapraklar
            // 
            this.tb_Yapraklar.Location = new System.Drawing.Point(132, 180);
            this.tb_Yapraklar.Name = "tb_Yapraklar";
            this.tb_Yapraklar.Size = new System.Drawing.Size(314, 22);
            this.tb_Yapraklar.TabIndex = 23;
            // 
            // lb_agacYuksekligi
            // 
            this.lb_agacYuksekligi.AutoSize = true;
            this.lb_agacYuksekligi.Location = new System.Drawing.Point(6, 155);
            this.lb_agacYuksekligi.Name = "lb_agacYuksekligi";
            this.lb_agacYuksekligi.Size = new System.Drawing.Size(118, 17);
            this.lb_agacYuksekligi.TabIndex = 20;
            this.lb_agacYuksekligi.Text = "Ağacın Yüksekliği";
            // 
            // tb_AgacYuksekligi
            // 
            this.tb_AgacYuksekligi.Location = new System.Drawing.Point(132, 152);
            this.tb_AgacYuksekligi.Name = "tb_AgacYuksekligi";
            this.tb_AgacYuksekligi.Size = new System.Drawing.Size(314, 22);
            this.tb_AgacYuksekligi.TabIndex = 21;
            // 
            // lb_dugumSayisi
            // 
            this.lb_dugumSayisi.AutoSize = true;
            this.lb_dugumSayisi.Location = new System.Drawing.Point(6, 127);
            this.lb_dugumSayisi.Name = "lb_dugumSayisi";
            this.lb_dugumSayisi.Size = new System.Drawing.Size(145, 17);
            this.lb_dugumSayisi.TabIndex = 18;
            this.lb_dugumSayisi.Text = "Toplam Düğüm Sayısı";
            // 
            // tb_DugumSayisi
            // 
            this.tb_DugumSayisi.Location = new System.Drawing.Point(219, 124);
            this.tb_DugumSayisi.Name = "tb_DugumSayisi";
            this.tb_DugumSayisi.Size = new System.Drawing.Size(227, 22);
            this.tb_DugumSayisi.TabIndex = 19;
            // 
            // lb_postorder
            // 
            this.lb_postorder.AutoSize = true;
            this.lb_postorder.Location = new System.Drawing.Point(6, 99);
            this.lb_postorder.Name = "lb_postorder";
            this.lb_postorder.Size = new System.Drawing.Size(70, 17);
            this.lb_postorder.TabIndex = 16;
            this.lb_postorder.Text = "Postorder";
            // 
            // tb_Postorder
            // 
            this.tb_Postorder.Location = new System.Drawing.Point(132, 96);
            this.tb_Postorder.Name = "tb_Postorder";
            this.tb_Postorder.Size = new System.Drawing.Size(314, 22);
            this.tb_Postorder.TabIndex = 17;
            // 
            // lb_inorder
            // 
            this.lb_inorder.AutoSize = true;
            this.lb_inorder.Location = new System.Drawing.Point(6, 71);
            this.lb_inorder.Name = "lb_inorder";
            this.lb_inorder.Size = new System.Drawing.Size(53, 17);
            this.lb_inorder.TabIndex = 14;
            this.lb_inorder.Text = "Inorder";
            // 
            // tb_Inorder
            // 
            this.tb_Inorder.Location = new System.Drawing.Point(132, 68);
            this.tb_Inorder.Name = "tb_Inorder";
            this.tb_Inorder.Size = new System.Drawing.Size(314, 22);
            this.tb_Inorder.TabIndex = 15;
            // 
            // lb_preorder
            // 
            this.lb_preorder.AutoSize = true;
            this.lb_preorder.Location = new System.Drawing.Point(6, 43);
            this.lb_preorder.Name = "lb_preorder";
            this.lb_preorder.Size = new System.Drawing.Size(64, 17);
            this.lb_preorder.TabIndex = 13;
            this.lb_preorder.Text = "Preorder";
            // 
            // tb_Preorder
            // 
            this.tb_Preorder.Location = new System.Drawing.Point(132, 40);
            this.tb_Preorder.Name = "tb_Preorder";
            this.tb_Preorder.Size = new System.Drawing.Size(314, 22);
            this.tb_Preorder.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btn_agacBilgiGoster);
            this.Controls.Add(this.rtb_dugumGoster);
            this.Controls.Add(this.btn_dugumGoster);
            this.Controls.Add(this.lb_dugumBul);
            this.Controls.Add(this.tb_dugumBul);
            this.Controls.Add(this.btn_DugumBul);
            this.Controls.Add(this.lb_dugumSil);
            this.Controls.Add(this.tb_dugumSil);
            this.Controls.Add(this.btn_DugumSil);
            this.Controls.Add(this.lb_dugumEkle);
            this.Controls.Add(this.tb_dugumEkle);
            this.Controls.Add(this.btn_DugumEkle);
            this.Name = "Form1";
            this.Text = "İkili Arama Ağacı";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DugumEkle;
        private System.Windows.Forms.TextBox tb_dugumEkle;
        private System.Windows.Forms.Label lb_dugumEkle;
        private System.Windows.Forms.Label lb_dugumSil;
        private System.Windows.Forms.TextBox tb_dugumSil;
        private System.Windows.Forms.Button btn_DugumSil;
        private System.Windows.Forms.Label lb_dugumBul;
        private System.Windows.Forms.TextBox tb_dugumBul;
        private System.Windows.Forms.Button btn_DugumBul;
        private System.Windows.Forms.Button btn_dugumGoster;
        private System.Windows.Forms.RichTextBox rtb_dugumGoster;
        private System.Windows.Forms.Button btn_agacBilgiGoster;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lb_yapraklar;
        private System.Windows.Forms.TextBox tb_Yapraklar;
        private System.Windows.Forms.Label lb_agacYuksekligi;
        private System.Windows.Forms.TextBox tb_AgacYuksekligi;
        private System.Windows.Forms.Label lb_dugumSayisi;
        private System.Windows.Forms.TextBox tb_DugumSayisi;
        private System.Windows.Forms.Label lb_postorder;
        private System.Windows.Forms.TextBox tb_Postorder;
        private System.Windows.Forms.Label lb_inorder;
        private System.Windows.Forms.TextBox tb_Inorder;
        private System.Windows.Forms.Label lb_preorder;
        private System.Windows.Forms.TextBox tb_Preorder;
    }
}

