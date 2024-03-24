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
			dgvKıyasRapor = new DataGridView();
			tabyemekcesidRapor = new TabPage();
			dgvyemekcesidirapor = new DataGridView();
			aksamyemegibuton = new Button();
			OglenButton = new Button();
			kahvaltıbuton = new Button();
			Raporlar.SuspendLayout();
			tabgünSonu.SuspendLayout();
			groupBox1.SuspendLayout();
			groupboxaksam.SuspendLayout();
			groupBoxOglen.SuspendLayout();
			tabKıyasRapor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvKıyasRapor).BeginInit();
			tabyemekcesidRapor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvyemekcesidirapor).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.BackColor = Color.Bisque;
			button1.Location = new Point(624, 628);
			button1.Margin = new Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Size = new Size(104, 25);
			button1.TabIndex = 0;
			button1.Text = "ANA SAYFA";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// Raporlar
			// 
			Raporlar.Controls.Add(tabgünSonu);
			Raporlar.Controls.Add(tabKıyasRapor);
			Raporlar.Controls.Add(tabyemekcesidRapor);
			Raporlar.Location = new Point(12, 11);
			Raporlar.Margin = new Padding(3, 2, 3, 2);
			Raporlar.Name = "Raporlar";
			Raporlar.SelectedIndex = 0;
			Raporlar.Size = new Size(716, 617);
			Raporlar.TabIndex = 1;
			// 
			// tabgünSonu
			// 
			tabgünSonu.BackgroundImage = Properties.Resources._42;
			tabgünSonu.BackgroundImageLayout = ImageLayout.Stretch;
			tabgünSonu.Controls.Add(groupBox1);
			tabgünSonu.Controls.Add(groupboxaksam);
			tabgünSonu.Controls.Add(groupBoxOglen);
			tabgünSonu.Controls.Add(lblToplamCalory);
			tabgünSonu.Controls.Add(Label);
			tabgünSonu.Controls.Add(dateTimePicker1);
			tabgünSonu.Location = new Point(4, 24);
			tabgünSonu.Margin = new Padding(3, 2, 3, 2);
			tabgünSonu.Name = "tabgünSonu";
			tabgünSonu.Padding = new Padding(3, 2, 3, 2);
			tabgünSonu.Size = new Size(708, 589);
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
			groupBox1.ForeColor = SystemColors.InfoText;
			groupBox1.Location = new Point(131, 341);
			groupBox1.Margin = new Padding(3, 2, 3, 2);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 2, 3, 2);
			groupBox1.Size = new Size(522, 56);
			groupBox1.TabIndex = 12;
			groupBox1.TabStop = false;
			groupBox1.Text = "Kahvaltı";
			// 
			// lblKahvaltiKalori
			// 
			lblKahvaltiKalori.AutoSize = true;
			lblKahvaltiKalori.Location = new Point(220, 35);
			lblKahvaltiKalori.Name = "lblKahvaltiKalori";
			lblKahvaltiKalori.Size = new Size(24, 15);
			lblKahvaltiKalori.TabIndex = 37;
			lblKahvaltiKalori.Text = "0.0";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(212, 18);
			label14.Name = "label14";
			label14.Size = new Size(39, 15);
			label14.TabIndex = 36;
			label14.Text = "Kalori";
			// 
			// groupboxaksam
			// 
			groupboxaksam.BackColor = Color.Transparent;
			groupboxaksam.Controls.Add(lblAksamKalori);
			groupboxaksam.Controls.Add(label6);
			groupboxaksam.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			groupboxaksam.ForeColor = SystemColors.InfoText;
			groupboxaksam.Location = new Point(131, 495);
			groupboxaksam.Margin = new Padding(3, 2, 3, 2);
			groupboxaksam.Name = "groupboxaksam";
			groupboxaksam.Padding = new Padding(3, 2, 3, 2);
			groupboxaksam.Size = new Size(522, 56);
			groupboxaksam.TabIndex = 17;
			groupboxaksam.TabStop = false;
			groupboxaksam.Text = "Akşam Yemeği";
			// 
			// lblAksamKalori
			// 
			lblAksamKalori.AutoSize = true;
			lblAksamKalori.Location = new Point(220, 35);
			lblAksamKalori.Name = "lblAksamKalori";
			lblAksamKalori.Size = new Size(24, 15);
			lblAksamKalori.TabIndex = 37;
			lblAksamKalori.Text = "0.0";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(212, 18);
			label6.Name = "label6";
			label6.Size = new Size(39, 15);
			label6.TabIndex = 36;
			label6.Text = "Kalori";
			// 
			// groupBoxOglen
			// 
			groupBoxOglen.BackColor = Color.Transparent;
			groupBoxOglen.Controls.Add(lblOglenKalori);
			groupBoxOglen.Controls.Add(label3);
			groupBoxOglen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			groupBoxOglen.ForeColor = SystemColors.InfoText;
			groupBoxOglen.Location = new Point(131, 415);
			groupBoxOglen.Margin = new Padding(3, 2, 3, 2);
			groupBoxOglen.Name = "groupBoxOglen";
			groupBoxOglen.Padding = new Padding(3, 2, 3, 2);
			groupBoxOglen.Size = new Size(522, 56);
			groupBoxOglen.TabIndex = 16;
			groupBoxOglen.TabStop = false;
			groupBoxOglen.Text = "Öğlen Yemeği";
			// 
			// lblOglenKalori
			// 
			lblOglenKalori.AutoSize = true;
			lblOglenKalori.Location = new Point(220, 33);
			lblOglenKalori.Name = "lblOglenKalori";
			lblOglenKalori.Size = new Size(24, 15);
			lblOglenKalori.TabIndex = 37;
			lblOglenKalori.Text = "0.0";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(212, 18);
			label3.Name = "label3";
			label3.Size = new Size(39, 15);
			label3.TabIndex = 36;
			label3.Text = "Kalori";
			// 
			// lblToplamCalory
			// 
			lblToplamCalory.AutoSize = true;
			lblToplamCalory.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			lblToplamCalory.Location = new Point(358, 234);
			lblToplamCalory.Name = "lblToplamCalory";
			lblToplamCalory.Size = new Size(46, 30);
			lblToplamCalory.TabIndex = 2;
			lblToplamCalory.Text = "0.0";
			// 
			// Label
			// 
			Label.AutoSize = true;
			Label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
			Label.Location = new Point(301, 213);
			Label.Name = "Label";
			Label.Size = new Size(168, 21);
			Label.TabIndex = 1;
			Label.Text = "Günlük Toplam Kalori";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.CalendarForeColor = SystemColors.AppWorkspace;
			dateTimePicker1.CalendarMonthBackground = Color.Chocolate;
			dateTimePicker1.Location = new Point(284, 187);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(200, 23);
			dateTimePicker1.TabIndex = 0;
			dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
			// 
			// tabKıyasRapor
			// 
			tabKıyasRapor.BackgroundImage = Properties.Resources._51;
			tabKıyasRapor.BackgroundImageLayout = ImageLayout.Center;
			tabKıyasRapor.Controls.Add(dgvKıyasRapor);
			tabKıyasRapor.Location = new Point(4, 24);
			tabKıyasRapor.Margin = new Padding(3, 2, 3, 2);
			tabKıyasRapor.Name = "tabKıyasRapor";
			tabKıyasRapor.Padding = new Padding(3, 2, 3, 2);
			tabKıyasRapor.Size = new Size(708, 589);
			tabKıyasRapor.TabIndex = 1;
			tabKıyasRapor.Text = "Kıyas Raporu";
			tabKıyasRapor.UseVisualStyleBackColor = true;
			// 
			// dgvKıyasRapor
			// 
			dgvKıyasRapor.BackgroundColor = Color.Bisque;
			dgvKıyasRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvKıyasRapor.Location = new Point(66, 185);
			dgvKıyasRapor.Name = "dgvKıyasRapor";
			dgvKıyasRapor.Size = new Size(556, 214);
			dgvKıyasRapor.TabIndex = 0;
			// 
			// tabyemekcesidRapor
			// 
			tabyemekcesidRapor.BackgroundImage = Properties.Resources._7;
			tabyemekcesidRapor.BackgroundImageLayout = ImageLayout.Stretch;
			tabyemekcesidRapor.Controls.Add(dgvyemekcesidirapor);
			tabyemekcesidRapor.Controls.Add(aksamyemegibuton);
			tabyemekcesidRapor.Controls.Add(OglenButton);
			tabyemekcesidRapor.Controls.Add(kahvaltıbuton);
			tabyemekcesidRapor.Location = new Point(4, 24);
			tabyemekcesidRapor.Margin = new Padding(3, 2, 3, 2);
			tabyemekcesidRapor.Name = "tabyemekcesidRapor";
			tabyemekcesidRapor.Size = new Size(708, 589);
			tabyemekcesidRapor.TabIndex = 2;
			tabyemekcesidRapor.Text = "Yemek Cesidi Raporu";
			tabyemekcesidRapor.UseVisualStyleBackColor = true;
			// 
			// dgvyemekcesidirapor
			// 
			dgvyemekcesidirapor.BackgroundColor = Color.NavajoWhite;
			dgvyemekcesidirapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvyemekcesidirapor.Location = new Point(102, 182);
			dgvyemekcesidirapor.Name = "dgvyemekcesidirapor";
			dgvyemekcesidirapor.RowHeadersWidth = 51;
			dgvyemekcesidirapor.Size = new Size(444, 259);
			dgvyemekcesidirapor.TabIndex = 3;
			dgvyemekcesidirapor.CellContentClick += dgvyemekcesidirapor_CellContentClick;
			// 
			// aksamyemegibuton
			// 
			aksamyemegibuton.BackColor = Color.BurlyWood;
			aksamyemegibuton.Location = new Point(425, 100);
			aksamyemegibuton.Name = "aksamyemegibuton";
			aksamyemegibuton.Size = new Size(121, 45);
			aksamyemegibuton.TabIndex = 2;
			aksamyemegibuton.Text = "Akşam Yemeği";
			aksamyemegibuton.UseVisualStyleBackColor = false;
			// 
			// OglenButton
			// 
			OglenButton.BackColor = Color.BurlyWood;
			OglenButton.Location = new Point(267, 99);
			OglenButton.Name = "OglenButton";
			OglenButton.Size = new Size(121, 45);
			OglenButton.TabIndex = 1;
			OglenButton.Text = "Öğlen Yemeği";
			OglenButton.UseVisualStyleBackColor = false;
			// 
			// kahvaltıbuton
			// 
			kahvaltıbuton.BackColor = Color.BurlyWood;
			kahvaltıbuton.Location = new Point(102, 99);
			kahvaltıbuton.Name = "kahvaltıbuton";
			kahvaltıbuton.Size = new Size(121, 45);
			kahvaltıbuton.TabIndex = 0;
			kahvaltıbuton.Text = "Kahvaltı";
			kahvaltıbuton.UseVisualStyleBackColor = false;
			kahvaltıbuton.Click += kahvaltıbuton_Click;
			// 
			// RaporSayfası
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.NavajoWhite;
			ClientSize = new Size(740, 656);
			Controls.Add(Raporlar);
			Controls.Add(button1);
			Margin = new Padding(3, 2, 3, 2);
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
			tabKıyasRapor.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvKıyasRapor).EndInit();
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
		private DataGridView dgvKıyasRapor;
	}
}