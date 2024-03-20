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
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tangerine_newt_RgT22Ixcq4Y_unsplash1;
            pictureBox1.Location = new Point(362, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(918, 711);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Olive;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Coral;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 700);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkKhaki;
            label4.Font = new Font("Algerian", 48F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 427);
            label4.Name = "label4";
            label4.Size = new Size(249, 89);
            label4.TabIndex = 3;
            label4.Text = "MOOD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Olive;
            label3.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(48, 279);
            label3.Name = "label3";
            label3.Size = new Size(344, 68);
            label3.TabIndex = 2;
            label3.Text = "for wealthy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkKhaki;
            label2.Font = new Font("Algerian", 48F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 157);
            label2.Name = "label2";
            label2.Size = new Size(234, 89);
            label2.TabIndex = 1;
            label2.Text = "FOOD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Olive;
            label1.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(48, 47);
            label1.Name = "label1";
            label1.Size = new Size(209, 68);
            label1.TabIndex = 0;
            label1.Text = "Healty";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Olive;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Right;
            panel2.ForeColor = Color.Yellow;
            panel2.Location = new Point(902, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 700);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.küçüldü;
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(57, 457);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(274, 217);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
           
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Palatino Linotype", 56.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.YellowGreen;
            label5.Location = new Point(3, 47);
            label5.Name = "label5";
            label5.Size = new Size(396, 129);
            label5.TabIndex = 1;
            label5.Text = "Lose It !";
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 700);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Giris";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Panel panel1;
		private Panel panel2;
		private Label label1;
		private Label label3;
		private Label label2;
		private Label label4;
		private Button button1;
		private Label label5;
	}
}
