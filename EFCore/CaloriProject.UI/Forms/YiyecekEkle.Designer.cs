namespace CaloriProject.UI
{
    partial class YiyecekEkle
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
            btn_yiyecekEkle = new Button();
            txt_yiyecekAdi = new TextBox();
            txt_kalori = new TextBox();
            anaSayfa_buton = new Button();
            kategori_combobox = new ComboBox();
            SuspendLayout();
            // 
            // btn_yiyecekEkle
            // 
            btn_yiyecekEkle.Location = new Point(328, 369);
            btn_yiyecekEkle.Margin = new Padding(3, 4, 3, 4);
            btn_yiyecekEkle.Name = "btn_yiyecekEkle";
            btn_yiyecekEkle.Size = new Size(141, 51);
            btn_yiyecekEkle.TabIndex = 0;
            btn_yiyecekEkle.Text = "Yiyecek Ekle";
            btn_yiyecekEkle.UseVisualStyleBackColor = true;
            btn_yiyecekEkle.Click += btn_yiyecekEkle_Click;
            // 
            // txt_yiyecekAdi
            // 
            txt_yiyecekAdi.Location = new Point(318, 131);
            txt_yiyecekAdi.Margin = new Padding(3, 4, 3, 4);
            txt_yiyecekAdi.Name = "txt_yiyecekAdi";
            txt_yiyecekAdi.PlaceholderText = " Yiyecek Adı";
            txt_yiyecekAdi.Size = new Size(151, 27);
            txt_yiyecekAdi.TabIndex = 1;
            txt_yiyecekAdi.TextChanged += txt_yiyecekAdi_TextChanged;
            // 
            // txt_kalori
            // 
            txt_kalori.Location = new Point(318, 269);
            txt_kalori.Margin = new Padding(3, 4, 3, 4);
            txt_kalori.Name = "txt_kalori";
            txt_kalori.PlaceholderText = "Kalori";
            txt_kalori.Size = new Size(151, 27);
            txt_kalori.TabIndex = 1;
            txt_kalori.TextChanged += txt_kalori_TextChanged;
            // 
            // anaSayfa_buton
            // 
            anaSayfa_buton.Location = new Point(328, 448);
            anaSayfa_buton.Margin = new Padding(3, 4, 3, 4);
            anaSayfa_buton.Name = "anaSayfa_buton";
            anaSayfa_buton.Size = new Size(141, 51);
            anaSayfa_buton.TabIndex = 2;
            anaSayfa_buton.Text = "ANA SAYFA";
            anaSayfa_buton.UseVisualStyleBackColor = true;
            anaSayfa_buton.Click += anaSayfa_buton_Click;
            // 
            // kategori_combobox
            // 
            kategori_combobox.FormattingEnabled = true;
            kategori_combobox.Location = new Point(318, 208);
            kategori_combobox.Name = "kategori_combobox";
            kategori_combobox.Size = new Size(151, 28);
            kategori_combobox.TabIndex = 3;
            // 
            // YiyecekEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pexels_ksenia_chernaya_3952050;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(785, 820);
            Controls.Add(kategori_combobox);
            Controls.Add(anaSayfa_buton);
            Controls.Add(txt_kalori);
            Controls.Add(txt_yiyecekAdi);
            Controls.Add(btn_yiyecekEkle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "YiyecekEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YiyecekEkle";
            Load += YiyecekEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_yiyecekEkle;
        private TextBox txt_yiyecekAdi;
        private TextBox txt_kalori;
        private Button anaSayfa_buton;
        private ComboBox kategori_combobox;
    }
}