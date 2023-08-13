namespace ElemanGorutuleme
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
            this.ElemanListesi = new System.Windows.Forms.ListView();
            this.verileriGetirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ElemanListesi
            // 
            this.ElemanListesi.HideSelection = false;
            this.ElemanListesi.Location = new System.Drawing.Point(12, 12);
            this.ElemanListesi.Name = "ElemanListesi";
            this.ElemanListesi.Size = new System.Drawing.Size(603, 261);
            this.ElemanListesi.TabIndex = 0;
            this.ElemanListesi.UseCompatibleStateImageBehavior = false;
            // 
            // verileriGetirButton
            // 
            this.verileriGetirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.verileriGetirButton.Location = new System.Drawing.Point(249, 308);
            this.verileriGetirButton.Name = "verileriGetirButton";
            this.verileriGetirButton.Size = new System.Drawing.Size(121, 45);
            this.verileriGetirButton.TabIndex = 1;
            this.verileriGetirButton.Text = "Verileri Getir";
            this.verileriGetirButton.UseVisualStyleBackColor = true;
            this.verileriGetirButton.Click += new System.EventHandler(this.verileriGetirButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 412);
            this.Controls.Add(this.verileriGetirButton);
            this.Controls.Add(this.ElemanListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eleman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ElemanListesi;
        private System.Windows.Forms.Button verileriGetirButton;
    }
}

