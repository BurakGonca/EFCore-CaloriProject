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
            Raporlar = new TabControl();
            tabgünSonu = new TabPage();
            groupBox1 = new GroupBox();
            lblKahvaltiKalori = new Label();
            label14 = new Label();
            groupboxaksam = new GroupBox();
            lblAksamKalori = new Label();
            label6 = new Label();
            groupBoxOglen = new GroupBox();
            lblOglenKalori = new Label();
            label3 = new Label();
            lblToplamCalory = new Label();
            Label = new Label();
            dateTimePicker1 = new DateTimePicker();
            tabKıyasRapor = new TabPage();
            tabyemekcesidRapor = new TabPage();
            dgvyemekcesidirapor = new DataGridView();
            aksamyemegibuton = new Button();
            OglenButton = new Button();
            kahvaltıbuton = new Button();
            yenile_buton = new Button();
            Raporlar.SuspendLayout();
            tabgünSonu.SuspendLayout();
            groupBox1.SuspendLayout();
            groupboxaksam.SuspendLayout();
            groupBoxOglen.SuspendLayout();
            tabyemekcesidRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvyemekcesidirapor).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(711, 831);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "ANA SAYFA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Raporlar
            // 
            Raporlar.Controls.Add(tabgünSonu);
            Raporlar.Controls.Add(tabKıyasRapor);
            Raporlar.Controls.Add(tabyemekcesidRapor);
            Raporlar.Location = new Point(14, 15);
            Raporlar.Name = "Raporlar";
            Raporlar.SelectedIndex = 0;
            Raporlar.Size = new Size(778, 793);
            Raporlar.TabIndex = 1;
            // 
            // tabgünSonu
            // 
            tabgünSonu.Controls.Add(yenile_buton);
            tabgünSonu.Controls.Add(groupBox1);
            tabgünSonu.Controls.Add(groupboxaksam);
            tabgünSonu.Controls.Add(groupBoxOglen);
            tabgünSonu.Controls.Add(lblToplamCalory);
            tabgünSonu.Controls.Add(Label);
            tabgünSonu.Controls.Add(dateTimePicker1);
            tabgünSonu.Location = new Point(4, 29);
            tabgünSonu.Name = "tabgünSonu";
            tabgünSonu.Padding = new Padding(3);
            tabgünSonu.Size = new Size(770, 760);
            tabgünSonu.TabIndex = 0;
            tabgünSonu.Text = "Gün Sonu Raporu";
            tabgünSonu.UseVisualStyleBackColor = true;
            tabgünSonu.Click += günSonu_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lblKahvaltiKalori);
            groupBox1.Controls.Add(label14);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(90, 360);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(597, 75);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kahvaltı";
            // 
            // lblKahvaltiKalori
            // 
            lblKahvaltiKalori.AutoSize = true;
            lblKahvaltiKalori.Location = new Point(251, 47);
            lblKahvaltiKalori.Name = "lblKahvaltiKalori";
            lblKahvaltiKalori.Size = new Size(31, 20);
            lblKahvaltiKalori.TabIndex = 37;
            lblKahvaltiKalori.Text = "0.0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(242, 24);
            label14.Name = "label14";
            label14.Size = new Size(50, 20);
            label14.TabIndex = 36;
            label14.Text = "Kalori";
            // 
            // groupboxaksam
            // 
            groupboxaksam.BackColor = Color.Transparent;
            groupboxaksam.Controls.Add(lblAksamKalori);
            groupboxaksam.Controls.Add(label6);
            groupboxaksam.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupboxaksam.Location = new Point(90, 565);
            groupboxaksam.Name = "groupboxaksam";
            groupboxaksam.Size = new Size(597, 75);
            groupboxaksam.TabIndex = 17;
            groupboxaksam.TabStop = false;
            groupboxaksam.Text = "Akşam Yemeği";
            // 
            // lblAksamKalori
            // 
            lblAksamKalori.AutoSize = true;
            lblAksamKalori.Location = new Point(251, 47);
            lblAksamKalori.Name = "lblAksamKalori";
            lblAksamKalori.Size = new Size(31, 20);
            lblAksamKalori.TabIndex = 37;
            lblAksamKalori.Text = "0.0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(242, 24);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 36;
            label6.Text = "Kalori";
            // 
            // groupBoxOglen
            // 
            groupBoxOglen.BackColor = Color.Transparent;
            groupBoxOglen.Controls.Add(lblOglenKalori);
            groupBoxOglen.Controls.Add(label3);
            groupBoxOglen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxOglen.Location = new Point(90, 459);
            groupBoxOglen.Name = "groupBoxOglen";
            groupBoxOglen.Size = new Size(597, 75);
            groupBoxOglen.TabIndex = 16;
            groupBoxOglen.TabStop = false;
            groupBoxOglen.Text = "Öğlen Yemeği";
            // 
            // lblOglenKalori
            // 
            lblOglenKalori.AutoSize = true;
            lblOglenKalori.Location = new Point(251, 44);
            lblOglenKalori.Name = "lblOglenKalori";
            lblOglenKalori.Size = new Size(31, 20);
            lblOglenKalori.TabIndex = 37;
            lblOglenKalori.Text = "0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 24);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 36;
            label3.Text = "Kalori";
            // 
            // lblToplamCalory
            // 
            lblToplamCalory.AutoSize = true;
            lblToplamCalory.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblToplamCalory.Location = new Point(350, 217);
            lblToplamCalory.Name = "lblToplamCalory";
            lblToplamCalory.Size = new Size(60, 37);
            lblToplamCalory.TabIndex = 2;
            lblToplamCalory.Text = "0.0";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            Label.Location = new Point(285, 189);
            Label.Name = "Label";
            Label.Size = new Size(212, 28);
            Label.TabIndex = 1;
            Label.Text = "Günlük Toplam Kalori";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(265, 155);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tabKıyasRapor
            // 
            tabKıyasRapor.Location = new Point(4, 29);
            tabKıyasRapor.Name = "tabKıyasRapor";
            tabKıyasRapor.Padding = new Padding(3);
            tabKıyasRapor.Size = new Size(770, 760);
            tabKıyasRapor.TabIndex = 1;
            tabKıyasRapor.Text = "Kıyas Raporu";
            tabKıyasRapor.UseVisualStyleBackColor = true;
            // 
            // tabyemekcesidRapor
            // 
            tabyemekcesidRapor.Controls.Add(dgvyemekcesidirapor);
            tabyemekcesidRapor.Controls.Add(aksamyemegibuton);
            tabyemekcesidRapor.Controls.Add(OglenButton);
            tabyemekcesidRapor.Controls.Add(kahvaltıbuton);
            tabyemekcesidRapor.Location = new Point(4, 29);
            tabyemekcesidRapor.Name = "tabyemekcesidRapor";
            tabyemekcesidRapor.Size = new Size(770, 760);
            tabyemekcesidRapor.TabIndex = 2;
            tabyemekcesidRapor.Text = "Yemek Cesidi Raporu";
            tabyemekcesidRapor.UseVisualStyleBackColor = true;
            // 
            // dgvyemekcesidirapor
            // 
            dgvyemekcesidirapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvyemekcesidirapor.Location = new Point(117, 243);
            dgvyemekcesidirapor.Margin = new Padding(3, 4, 3, 4);
            dgvyemekcesidirapor.Name = "dgvyemekcesidirapor";
            dgvyemekcesidirapor.RowHeadersWidth = 51;
            dgvyemekcesidirapor.Size = new Size(507, 345);
            dgvyemekcesidirapor.TabIndex = 3;
            // 
            // aksamyemegibuton
            // 
            aksamyemegibuton.Location = new Point(486, 133);
            aksamyemegibuton.Margin = new Padding(3, 4, 3, 4);
            aksamyemegibuton.Name = "aksamyemegibuton";
            aksamyemegibuton.Size = new Size(138, 60);
            aksamyemegibuton.TabIndex = 2;
            aksamyemegibuton.Text = "Akşam Yemeği";
            aksamyemegibuton.UseVisualStyleBackColor = true;
            // 
            // OglenButton
            // 
            OglenButton.Location = new Point(305, 132);
            OglenButton.Margin = new Padding(3, 4, 3, 4);
            OglenButton.Name = "OglenButton";
            OglenButton.Size = new Size(138, 60);
            OglenButton.TabIndex = 1;
            OglenButton.Text = "Öğlen Yemeği";
            OglenButton.UseVisualStyleBackColor = true;
            // 
            // kahvaltıbuton
            // 
            kahvaltıbuton.Location = new Point(117, 132);
            kahvaltıbuton.Margin = new Padding(3, 4, 3, 4);
            kahvaltıbuton.Name = "kahvaltıbuton";
            kahvaltıbuton.Size = new Size(138, 60);
            kahvaltıbuton.TabIndex = 0;
            kahvaltıbuton.Text = "Kahvaltı";
            kahvaltıbuton.UseVisualStyleBackColor = true;
            // 
            // yenile_buton
            // 
            yenile_buton.Location = new Point(332, 295);
            yenile_buton.Name = "yenile_buton";
            yenile_buton.Size = new Size(94, 29);
            yenile_buton.TabIndex = 18;
            yenile_buton.Text = "Yenile";
            yenile_buton.UseVisualStyleBackColor = true;
            yenile_buton.Click += yenile_buton_Click;
            // 
            // RaporSayfası
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 875);
            Controls.Add(Raporlar);
            Controls.Add(button1);
            Name = "RaporSayfası";
            Text = "RaporSayfası";
            Load += RaporSayfası_Load;
            Raporlar.ResumeLayout(false);
            tabgünSonu.ResumeLayout(false);
            tabgünSonu.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupboxaksam.ResumeLayout(false);
            groupboxaksam.PerformLayout();
            groupBoxOglen.ResumeLayout(false);
            groupBoxOglen.PerformLayout();
            tabyemekcesidRapor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvyemekcesidirapor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TabControl Raporlar;
        private TabPage tabgünSonu;
        private TabPage tabKıyasRapor;
        private TabPage tabyemekcesidRapor;
		private Label lblToplamCalory;
		private Label Label;
		private DateTimePicker dateTimePicker1;
		private GroupBox groupBox1;
		private Label lblKahvaltiKalori;
		private Label label14;
		private GroupBox groupBoxOglen;
		private Label lblOglenKalori;
		private Label label3;
		private GroupBox groupboxaksam;
		private Label lblAksamKalori;
		private Label label6;
		private DataGridView dgvyemekcesidirapor;
		private Button aksamyemegibuton;
		private Button OglenButton;
		private Button kahvaltıbuton;
        private Button yenile_buton;
    }
}