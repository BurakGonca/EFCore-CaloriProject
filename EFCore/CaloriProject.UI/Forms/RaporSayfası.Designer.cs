namespace CaloriProject.UI.Forms
{
	partial class RaporSayfası
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
            tabControl1 = new TabControl();
            günSonu = new TabPage();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(639, 481);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "ANA SAYFA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(günSonu);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(60, 65);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(677, 391);
            tabControl1.TabIndex = 1;
            // 
            // günSonu
            // 
            günSonu.Location = new Point(4, 29);
            günSonu.Name = "günSonu";
            günSonu.Padding = new Padding(3);
            günSonu.Size = new Size(669, 358);
            günSonu.TabIndex = 0;
            günSonu.Text = "Gün Sonu Raporu";
            günSonu.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(669, 358);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kıyas Raporu";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(669, 358);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Yemek Cesidi Raporu";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // RaporSayfası
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 659);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Name = "RaporSayfası";
            Text = "RaporSayfası";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TabControl tabControl1;
        private TabPage günSonu;
        private TabPage tabPage2;
        private TabPage tabPage1;
    }
}