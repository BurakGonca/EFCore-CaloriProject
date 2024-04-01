namespace CaloriProject.UI
{
    partial class KullaniciGiris
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
            email_textBox = new TextBox();
            sifre_textBox = new TextBox();
            btn_girisYap = new Button();
            button1 = new Button();
            panel1 = new Panel();
            sifreGoster_CheckBox = new CheckBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // email_textBox
            // 
            email_textBox.BackColor = Color.LightCoral;
            email_textBox.ForeColor = SystemColors.ActiveCaptionText;
            email_textBox.Location = new Point(168, 121);
            email_textBox.Margin = new Padding(3, 4, 3, 4);
            email_textBox.Name = "email_textBox";
            email_textBox.PlaceholderText = "E-mail";
            email_textBox.Size = new Size(241, 27);
            email_textBox.TabIndex = 2;
            // 
            // sifre_textBox
            // 
            sifre_textBox.BackColor = Color.LightCoral;
            sifre_textBox.ForeColor = SystemColors.ActiveCaptionText;
            sifre_textBox.Location = new Point(171, 194);
            sifre_textBox.Margin = new Padding(3, 4, 3, 4);
            sifre_textBox.Name = "sifre_textBox";
            sifre_textBox.PlaceholderText = "Şifre";
            sifre_textBox.Size = new Size(241, 27);
            sifre_textBox.TabIndex = 3;
            sifre_textBox.TextChanged += sifre_textBox_TextChanged;
            // 
            // btn_girisYap
            // 
            btn_girisYap.BackColor = Color.LightCoral;
            btn_girisYap.ForeColor = SystemColors.ActiveCaptionText;
            btn_girisYap.Location = new Point(299, 311);
            btn_girisYap.Margin = new Padding(3, 4, 3, 4);
            btn_girisYap.Name = "btn_girisYap";
            btn_girisYap.Size = new Size(110, 52);
            btn_girisYap.TabIndex = 4;
            btn_girisYap.Text = "Giriş";
            btn_girisYap.UseVisualStyleBackColor = false;
            btn_girisYap.Click += btn_girisYap_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(168, 311);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(110, 52);
            button1.TabIndex = 5;
            button1.Text = "Ana Sayfa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(sifreGoster_CheckBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(email_textBox);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_girisYap);
            panel1.Controls.Add(sifre_textBox);
            panel1.Location = new Point(186, 140);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 433);
            panel1.TabIndex = 6;
            // 
            // sifreGoster_CheckBox
            // 
            sifreGoster_CheckBox.AutoSize = true;
            sifreGoster_CheckBox.Location = new Point(171, 243);
            sifreGoster_CheckBox.Name = "sifreGoster_CheckBox";
            sifreGoster_CheckBox.Size = new Size(108, 24);
            sifreGoster_CheckBox.TabIndex = 7;
            sifreGoster_CheckBox.Text = "Şifre Göster";
            sifreGoster_CheckBox.UseVisualStyleBackColor = true;
            sifreGoster_CheckBox.CheckedChanged += sifreGoster_CheckBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 30.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(626, 59);
            label1.TabIndex = 6;
            label1.Text = "Start to Loss Your Weights !";
            // 
            // KullaniciGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pexels_any_lane_5946101;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(952, 708);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KullaniciGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciGiris";
            Load += KullaniciGiris_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox email_textBox;
        private TextBox sifre_textBox;
        private Button btn_girisYap;
        private Button button1;
		private Panel panel1;
		private Label label1;
        private CheckBox sifreGoster_CheckBox;
    }
}