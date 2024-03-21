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
            txt_Porsiyon = new TextBox();
            txt_kalori = new TextBox();
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
            txt_yiyecekAdi.Location = new Point(297, 98);
            txt_yiyecekAdi.Name = "txt_yiyecekAdi";
            txt_yiyecekAdi.PlaceholderText = " Yiyecek Adı";
            txt_yiyecekAdi.Size = new Size(100, 23);
            txt_yiyecekAdi.TabIndex = 1;
            txt_yiyecekAdi.TextChanged += txt_yiyecekAdi_TextChanged;
            // 
            // txt_Porsiyon
            // 
            txt_Porsiyon.Location = new Point(297, 150);
            txt_Porsiyon.Name = "txt_Porsiyon";
            txt_Porsiyon.PlaceholderText = "Porsiyon";
            txt_Porsiyon.Size = new Size(100, 23);
            txt_Porsiyon.TabIndex = 1;
            txt_Porsiyon.TextChanged += txt_Porsiyon_TextChanged;
            // 
            // txt_kalori
            // 
            txt_kalori.Location = new Point(297, 202);
            txt_kalori.Name = "txt_kalori";
            txt_kalori.PlaceholderText = "Kalori";
            txt_kalori.Size = new Size(100, 23);
            txt_kalori.TabIndex = 1;
            txt_kalori.TextChanged += txt_kalori_TextChanged;
            // 
            // YiyecekEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_kalori);
            Controls.Add(txt_Porsiyon);
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
        private TextBox txt_Porsiyon;
        private TextBox txt_kalori;
    }
}