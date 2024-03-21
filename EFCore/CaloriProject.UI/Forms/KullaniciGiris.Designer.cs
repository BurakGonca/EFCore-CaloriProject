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
            email_textBox = new TextBox();
            sifre_textBox = new TextBox();
            btn_girisYap = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(224, 197);
            label1.Name = "label1";
            label1.Size = new Size(114, 31);
            label1.TabIndex = 0;
            label1.Text = "E-mail:";
            // 
            // label2
            // 
            label2.Location = new Point(224, 303);
            label2.Name = "label2";
            label2.Size = new Size(114, 37);
            label2.TabIndex = 1;
            label2.Text = "Sifre:";
            // 
            // email_textBox
            // 
            email_textBox.Location = new Point(377, 197);
            email_textBox.Margin = new Padding(3, 4, 3, 4);
            email_textBox.Name = "email_textBox";
            email_textBox.Size = new Size(114, 27);
            email_textBox.TabIndex = 2;
            // 
            // sifre_textBox
            // 
            sifre_textBox.Location = new Point(377, 303);
            sifre_textBox.Margin = new Padding(3, 4, 3, 4);
            sifre_textBox.Name = "sifre_textBox";
            sifre_textBox.Size = new Size(114, 27);
            sifre_textBox.TabIndex = 3;
            // 
            // btn_girisYap
            // 
            btn_girisYap.Location = new Point(377, 379);
            btn_girisYap.Margin = new Padding(3, 4, 3, 4);
            btn_girisYap.Name = "btn_girisYap";
            btn_girisYap.Size = new Size(110, 52);
            btn_girisYap.TabIndex = 4;
            btn_girisYap.Text = "GİRİŞ YAP";
            btn_girisYap.UseVisualStyleBackColor = true;
            btn_girisYap.Click += btn_girisYap_Click;
            // 
            // button1
            // 
            button1.Location = new Point(228, 379);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(110, 52);
            button1.TabIndex = 5;
            button1.Text = "GİRİS EKRANI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // KullaniciGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 604);
            Controls.Add(button1);
            Controls.Add(btn_girisYap);
            Controls.Add(sifre_textBox);
            Controls.Add(email_textBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KullaniciGiris";
            Text = "KullaniciGiris";
            Load += KullaniciGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox email_textBox;
        private TextBox sifre_textBox;
        private Button btn_girisYap;
        private Button button1;
    }
}