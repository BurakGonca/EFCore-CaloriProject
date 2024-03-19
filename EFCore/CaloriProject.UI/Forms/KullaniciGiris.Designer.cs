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
            label1 = new Label();
            label2 = new Label();
            g_email_textBox = new TextBox();
            g_sifre_textBox = new TextBox();
            btn_girisYap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(86, 164);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Location = new Point(86, 244);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // g_email_textBox
            // 
            g_email_textBox.Location = new Point(260, 164);
            g_email_textBox.Name = "g_email_textBox";
            g_email_textBox.Size = new Size(100, 23);
            g_email_textBox.TabIndex = 2;
            // 
            // g_sifre_textBox
            // 
            g_sifre_textBox.Location = new Point(260, 244);
            g_sifre_textBox.Name = "g_sifre_textBox";
            g_sifre_textBox.Size = new Size(100, 23);
            g_sifre_textBox.TabIndex = 3;
            // 
            // btn_girisYap
            // 
            btn_girisYap.Location = new Point(260, 334);
            btn_girisYap.Name = "btn_girisYap";
            btn_girisYap.Size = new Size(96, 39);
            btn_girisYap.TabIndex = 4;
            btn_girisYap.Text = "button1";
            btn_girisYap.UseVisualStyleBackColor = true;
            btn_girisYap.Click += btn_girisYap_Click;
            // 
            // KullaniciGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 704);
            Controls.Add(btn_girisYap);
            Controls.Add(g_sifre_textBox);
            Controls.Add(g_email_textBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KullaniciGiris";
            Text = "KullaniciGiris";
            Load += KullaniciGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox g_email_textBox;
        private TextBox g_sifre_textBox;
        private Button btn_girisYap;
    }
}