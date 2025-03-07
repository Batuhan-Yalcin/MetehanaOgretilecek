namespace RastgeleListBoxV2
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
            this.btnSalla = new System.Windows.Forms.Button();
            this.btnEnBuyuk = new System.Windows.Forms.Button();
            this.btnEnKucuk = new System.Windows.Forms.Button();
            this.btnOnDanBuyuk = new System.Windows.Forms.Button();
            this.btnOnDanKucuk = new System.Windows.Forms.Button();
            this.btnAdetBul = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalla
            // 
            this.btnSalla.BackColor = System.Drawing.Color.Beige;
            this.btnSalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalla.ForeColor = System.Drawing.Color.Black;
            this.btnSalla.Location = new System.Drawing.Point(12, 12);
            this.btnSalla.Name = "btnSalla";
            this.btnSalla.Size = new System.Drawing.Size(243, 58);
            this.btnSalla.TabIndex = 0;
            this.btnSalla.Text = "Rastgele Sayı Üret";
            this.btnSalla.UseVisualStyleBackColor = false;
            this.btnSalla.Click += new System.EventHandler(this.btnSalla_Click);
            // 
            // btnEnBuyuk
            // 
            this.btnEnBuyuk.BackColor = System.Drawing.Color.Beige;
            this.btnEnBuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnBuyuk.ForeColor = System.Drawing.Color.Black;
            this.btnEnBuyuk.Location = new System.Drawing.Point(12, 95);
            this.btnEnBuyuk.Name = "btnEnBuyuk";
            this.btnEnBuyuk.Size = new System.Drawing.Size(243, 58);
            this.btnEnBuyuk.TabIndex = 1;
            this.btnEnBuyuk.Text = "En Büyük Sayıyı Göster";
            this.btnEnBuyuk.UseVisualStyleBackColor = false;
            this.btnEnBuyuk.Click += new System.EventHandler(this.btnEnBuyuk_Click);
            // 
            // btnEnKucuk
            // 
            this.btnEnKucuk.BackColor = System.Drawing.Color.Beige;
            this.btnEnKucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnKucuk.ForeColor = System.Drawing.Color.Black;
            this.btnEnKucuk.Location = new System.Drawing.Point(12, 185);
            this.btnEnKucuk.Name = "btnEnKucuk";
            this.btnEnKucuk.Size = new System.Drawing.Size(243, 58);
            this.btnEnKucuk.TabIndex = 1;
            this.btnEnKucuk.Text = "En Küçük Sayıyı Göster";
            this.btnEnKucuk.UseVisualStyleBackColor = false;
            this.btnEnKucuk.Click += new System.EventHandler(this.btnEnKucuk_Click);
            // 
            // btnOnDanBuyuk
            // 
            this.btnOnDanBuyuk.BackColor = System.Drawing.Color.Beige;
            this.btnOnDanBuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnDanBuyuk.ForeColor = System.Drawing.Color.Black;
            this.btnOnDanBuyuk.Location = new System.Drawing.Point(12, 270);
            this.btnOnDanBuyuk.Name = "btnOnDanBuyuk";
            this.btnOnDanBuyuk.Size = new System.Drawing.Size(243, 58);
            this.btnOnDanBuyuk.TabIndex = 1;
            this.btnOnDanBuyuk.Text = "10dan Büyük Sayılar";
            this.btnOnDanBuyuk.UseVisualStyleBackColor = false;
            this.btnOnDanBuyuk.Click += new System.EventHandler(this.btnOnDanBuyuk_Click);
            // 
            // btnOnDanKucuk
            // 
            this.btnOnDanKucuk.BackColor = System.Drawing.Color.Beige;
            this.btnOnDanKucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnDanKucuk.Location = new System.Drawing.Point(12, 355);
            this.btnOnDanKucuk.Name = "btnOnDanKucuk";
            this.btnOnDanKucuk.Size = new System.Drawing.Size(243, 58);
            this.btnOnDanKucuk.TabIndex = 1;
            this.btnOnDanKucuk.Text = "10dan Küçük Sayılar";
            this.btnOnDanKucuk.UseVisualStyleBackColor = false;
            this.btnOnDanKucuk.Click += new System.EventHandler(this.btnOnDanKucuk_Click);
            // 
            // btnAdetBul
            // 
            this.btnAdetBul.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAdetBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdetBul.Location = new System.Drawing.Point(295, 12);
            this.btnAdetBul.Name = "btnAdetBul";
            this.btnAdetBul.Size = new System.Drawing.Size(264, 53);
            this.btnAdetBul.TabIndex = 1;
            this.btnAdetBul.Text = "Adet Bul";
            this.btnAdetBul.UseVisualStyleBackColor = false;
            this.btnAdetBul.Click += new System.EventHandler(this.btnAdetBul_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Silver;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox.ForeColor = System.Drawing.Color.Black;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(261, 71);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(527, 364);
            this.listBox.TabIndex = 2;
            // 
            // txtAdet
            // 
            this.txtAdet.BackColor = System.Drawing.Color.MistyRose;
            this.txtAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.ForeColor = System.Drawing.Color.Magenta;
            this.txtAdet.Location = new System.Drawing.Point(581, 12);
            this.txtAdet.Multiline = true;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(207, 53);
            this.txtAdet.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnAdetBul);
            this.Controls.Add(this.btnOnDanKucuk);
            this.Controls.Add(this.btnOnDanBuyuk);
            this.Controls.Add(this.btnEnKucuk);
            this.Controls.Add(this.btnEnBuyuk);
            this.Controls.Add(this.btnSalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalla;
        private System.Windows.Forms.Button btnEnBuyuk;
        private System.Windows.Forms.Button btnEnKucuk;
        private System.Windows.Forms.Button btnOnDanBuyuk;
        private System.Windows.Forms.Button btnOnDanKucuk;
        private System.Windows.Forms.Button btnAdetBul;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox txtAdet;
    }
}

