namespace CaloriProject.UI
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            g_email_textBox = new TextBox();
            g_sifre_textBox = new TextBox();
            btn_girisYap = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(-3, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(617, 700);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lato", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(46, 286);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 1;
            label1.Text = "E-mail";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lato", 14.25F, FontStyle.Bold);
            label2.Location = new Point(46, 378);
            label2.Name = "label2";
            label2.Size = new Size(108, 32);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // g_email_textBox
            // 
            g_email_textBox.Location = new Point(212, 286);
            g_email_textBox.Multiline = true;
            g_email_textBox.Name = "g_email_textBox";
            g_email_textBox.Size = new Size(301, 32);
            g_email_textBox.TabIndex = 3;
            // 
            // g_sifre_textBox
            // 
            g_sifre_textBox.Location = new Point(212, 378);
            g_sifre_textBox.Multiline = true;
            g_sifre_textBox.Name = "g_sifre_textBox";
            g_sifre_textBox.Size = new Size(301, 32);
            g_sifre_textBox.TabIndex = 4;
            // 
            // btn_girisYap
            // 
            btn_girisYap.Font = new Font("Lato", 14.25F, FontStyle.Bold);
            btn_girisYap.Location = new Point(269, 469);
            btn_girisYap.Name = "btn_girisYap";
            btn_girisYap.Size = new Size(179, 66);
            btn_girisYap.TabIndex = 5;
            btn_girisYap.Text = "Giriş Yap";
            btn_girisYap.UseVisualStyleBackColor = true;
            btn_girisYap.Click += btn_girisYap_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 696);
            Controls.Add(btn_girisYap);
            Controls.Add(g_sifre_textBox);
            Controls.Add(g_email_textBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Giris";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox g_email_textBox;
        private TextBox g_sifre_textBox;
        private Button btn_girisYap;
    }
}
