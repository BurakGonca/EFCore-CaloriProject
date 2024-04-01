namespace CaloriProject.UI.Forms
{
    partial class AyarlarSayfasi
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
            button1 = new Button();
            label1 = new Label();
            txt_Ad = new TextBox();
            txt_Soyad = new TextBox();
            txt_Kilo = new TextBox();
            txt_Boy = new TextBox();
            txt_Sifre = new TextBox();
            dogumTarihiPicker = new DateTimePicker();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label17 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btn_Kaydet = new Button();
            btn_Sil = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(375, 668);
            button1.Name = "button1";
            button1.Size = new Size(123, 67);
            button1.TabIndex = 0;
            button1.Text = "ANA SAYFAYA DÖN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(375, 48);
            label1.Name = "label1";
            label1.Size = new Size(167, 52);
            label1.TabIndex = 1;
            label1.Text = "Ayarlar";
            // 
            // txt_Ad
            // 
            txt_Ad.BackColor = SystemColors.Window;
            txt_Ad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txt_Ad.Location = new Point(312, 159);
            txt_Ad.Margin = new Padding(3, 4, 3, 4);
            txt_Ad.Name = "txt_Ad";
            txt_Ad.Size = new Size(302, 32);
            txt_Ad.TabIndex = 46;
            // 
            // txt_Soyad
            // 
            txt_Soyad.BackColor = SystemColors.Window;
            txt_Soyad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txt_Soyad.Location = new Point(312, 221);
            txt_Soyad.Margin = new Padding(3, 4, 3, 4);
            txt_Soyad.Name = "txt_Soyad";
            txt_Soyad.Size = new Size(302, 32);
            txt_Soyad.TabIndex = 47;
            // 
            // txt_Kilo
            // 
            txt_Kilo.BackColor = SystemColors.Window;
            txt_Kilo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txt_Kilo.Location = new Point(312, 347);
            txt_Kilo.Margin = new Padding(3, 4, 3, 4);
            txt_Kilo.Name = "txt_Kilo";
            txt_Kilo.Size = new Size(302, 32);
            txt_Kilo.TabIndex = 48;
            // 
            // txt_Boy
            // 
            txt_Boy.BackColor = SystemColors.Window;
            txt_Boy.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txt_Boy.Location = new Point(312, 411);
            txt_Boy.Margin = new Padding(3, 4, 3, 4);
            txt_Boy.Name = "txt_Boy";
            txt_Boy.Size = new Size(302, 32);
            txt_Boy.TabIndex = 49;
            // 
            // txt_Sifre
            // 
            txt_Sifre.BackColor = SystemColors.Window;
            txt_Sifre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txt_Sifre.Location = new Point(312, 477);
            txt_Sifre.Margin = new Padding(3, 4, 3, 4);
            txt_Sifre.Name = "txt_Sifre";
            txt_Sifre.Size = new Size(302, 32);
            txt_Sifre.TabIndex = 50;
            // 
            // dogumTarihiPicker
            // 
            dogumTarihiPicker.Location = new Point(312, 293);
            dogumTarihiPicker.Name = "dogumTarihiPicker";
            dogumTarihiPicker.Size = new Size(302, 27);
            dogumTarihiPicker.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(181, 159);
            label8.Name = "label8";
            label8.Size = new Size(33, 23);
            label8.TabIndex = 52;
            label8.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(173, 221);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 53;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(173, 293);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 54;
            label3.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(173, 347);
            label4.Name = "label4";
            label4.Size = new Size(41, 23);
            label4.TabIndex = 55;
            label4.Text = "Kilo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(173, 411);
            label5.Name = "label5";
            label5.Size = new Size(40, 23);
            label5.TabIndex = 56;
            label5.Text = "Boy";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(173, 477);
            label6.Name = "label6";
            label6.Size = new Size(48, 23);
            label6.TabIndex = 57;
            label6.Text = "Sifre";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label17.Location = new Point(290, 165);
            label17.Name = "label17";
            label17.Size = new Size(15, 23);
            label17.TabIndex = 58;
            label17.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(290, 228);
            label7.Name = "label7";
            label7.Size = new Size(15, 23);
            label7.TabIndex = 59;
            label7.Text = ":";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.Location = new Point(290, 293);
            label9.Name = "label9";
            label9.Size = new Size(15, 23);
            label9.TabIndex = 60;
            label9.Text = ":";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.Location = new Point(290, 353);
            label10.Name = "label10";
            label10.Size = new Size(15, 23);
            label10.TabIndex = 61;
            label10.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.Location = new Point(290, 411);
            label11.Name = "label11";
            label11.Size = new Size(15, 23);
            label11.TabIndex = 62;
            label11.Text = ":";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label12.Location = new Point(290, 477);
            label12.Name = "label12";
            label12.Size = new Size(15, 23);
            label12.TabIndex = 63;
            label12.Text = ":";
            // 
            // btn_Kaydet
            // 
            btn_Kaydet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Kaydet.Location = new Point(312, 544);
            btn_Kaydet.Margin = new Padding(3, 4, 3, 4);
            btn_Kaydet.Name = "btn_Kaydet";
            btn_Kaydet.Size = new Size(144, 57);
            btn_Kaydet.TabIndex = 64;
            btn_Kaydet.Text = "Kaydet";
            btn_Kaydet.UseVisualStyleBackColor = true;
            btn_Kaydet.Click += btn_Kaydet_Click;
            // 
            // btn_Sil
            // 
            btn_Sil.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Sil.Location = new Point(463, 544);
            btn_Sil.Margin = new Padding(3, 4, 3, 4);
            btn_Sil.Name = "btn_Sil";
            btn_Sil.Size = new Size(152, 57);
            btn_Sil.TabIndex = 65;
            btn_Sil.Text = "Hesabı Sil";
            btn_Sil.UseVisualStyleBackColor = true;
            btn_Sil.Click += btn_Sil_Click;
            // 
            // AyarlarSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pexels_shvets_production_7195272;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 749);
            Controls.Add(btn_Sil);
            Controls.Add(btn_Kaydet);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label17);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(dogumTarihiPicker);
            Controls.Add(txt_Sifre);
            Controls.Add(txt_Boy);
            Controls.Add(txt_Kilo);
            Controls.Add(txt_Soyad);
            Controls.Add(txt_Ad);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "AyarlarSayfasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AyarlarSayfasi";
            Load += AyarlarSayfasi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txt_Ad;
        private TextBox txt_Soyad;
        private TextBox txt_Kilo;
        private TextBox txt_Boy;
        private TextBox txt_Sifre;
        private DateTimePicker dogumTarihiPicker;
        private Label label8;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label17;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btn_Kaydet;
        private Button btn_Sil;
    }
}