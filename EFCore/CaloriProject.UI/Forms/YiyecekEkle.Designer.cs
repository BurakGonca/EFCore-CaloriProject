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
			btn_yiyecekEkle.Location = new Point(287, 277);
			btn_yiyecekEkle.Name = "btn_yiyecekEkle";
			btn_yiyecekEkle.Size = new Size(123, 38);
			btn_yiyecekEkle.TabIndex = 0;
			btn_yiyecekEkle.Text = "Yiyecek Ekle";
			btn_yiyecekEkle.UseVisualStyleBackColor = true;
			btn_yiyecekEkle.Click += btn_yiyecekEkle_Click;
			// 
			// txt_yiyecekAdi
			// 
			txt_yiyecekAdi.Location = new Point(278, 98);
			txt_yiyecekAdi.Name = "txt_yiyecekAdi";
			txt_yiyecekAdi.PlaceholderText = " Yiyecek Adı";
			txt_yiyecekAdi.Size = new Size(133, 23);
			txt_yiyecekAdi.TabIndex = 1;
			txt_yiyecekAdi.TextChanged += txt_yiyecekAdi_TextChanged;
			// 
			// txt_kalori
			// 
			txt_kalori.Location = new Point(278, 202);
			txt_kalori.Name = "txt_kalori";
			txt_kalori.PlaceholderText = "Kalori";
			txt_kalori.Size = new Size(133, 23);
			txt_kalori.TabIndex = 1;
			txt_kalori.TextChanged += txt_kalori_TextChanged;
			// 
			// anaSayfa_buton
			// 
			anaSayfa_buton.Location = new Point(287, 336);
			anaSayfa_buton.Name = "anaSayfa_buton";
			anaSayfa_buton.Size = new Size(123, 38);
			anaSayfa_buton.TabIndex = 2;
			anaSayfa_buton.Text = "ANA SAYFA";
			anaSayfa_buton.UseVisualStyleBackColor = true;
			anaSayfa_buton.Click += anaSayfa_buton_Click;
			// 
			// kategori_combobox
			// 
			kategori_combobox.FormattingEnabled = true;
			kategori_combobox.Location = new Point(278, 156);
			kategori_combobox.Margin = new Padding(3, 2, 3, 2);
			kategori_combobox.Name = "kategori_combobox";
			kategori_combobox.Size = new Size(133, 23);
			kategori_combobox.TabIndex = 3;
			// 
			// YiyecekEkle
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.pexels_ksenia_chernaya_3952050;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(687, 615);
			Controls.Add(kategori_combobox);
			Controls.Add(anaSayfa_buton);
			Controls.Add(txt_kalori);
			Controls.Add(txt_yiyecekAdi);
			Controls.Add(btn_yiyecekEkle);
			Name = "YiyecekEkle";
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