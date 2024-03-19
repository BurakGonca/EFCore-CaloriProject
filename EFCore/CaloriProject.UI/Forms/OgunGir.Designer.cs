namespace CaloriProject.UI.Forms
{
    partial class OgunGir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgunGir));
            dateTimePicker1 = new DateTimePicker();
            comboBox1_ogun = new ComboBox();
            comboBox3_yiyecek = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            ekle_buton = new Button();
            sil_buton = new Button();
            guncelle_buton = new Button();
            button4 = new Button();
            kullanici_Isım_Lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(660, 175);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // comboBox1_ogun
            // 
            comboBox1_ogun.FormattingEnabled = true;
            comboBox1_ogun.Location = new Point(660, 232);
            comboBox1_ogun.Name = "comboBox1_ogun";
            comboBox1_ogun.Size = new Size(250, 28);
            comboBox1_ogun.TabIndex = 1;
            // 
            // comboBox3_yiyecek
            // 
            comboBox3_yiyecek.FormattingEnabled = true;
            comboBox3_yiyecek.Location = new Point(660, 290);
            comboBox3_yiyecek.Name = "comboBox3_yiyecek";
            comboBox3_yiyecek.Size = new Size(250, 28);
            comboBox3_yiyecek.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(578, 178);
            label1.Name = "label1";
            label1.Size = new Size(50, 23);
            label1.TabIndex = 4;
            label1.Text = "Tarih:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(578, 237);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 5;
            label2.Text = "Öğün:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(578, 295);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 7;
            label4.Text = "Yiyecek:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 355);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(857, 313);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ekle_buton
            // 
            ekle_buton.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ekle_buton.Location = new Point(53, 285);
            ekle_buton.Name = "ekle_buton";
            ekle_buton.Size = new Size(93, 37);
            ekle_buton.TabIndex = 11;
            ekle_buton.Text = "Ekle";
            ekle_buton.UseVisualStyleBackColor = true;
            ekle_buton.Click += ekle_buton_Click;
            // 
            // sil_buton
            // 
            sil_buton.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sil_buton.Location = new Point(171, 285);
            sil_buton.Name = "sil_buton";
            sil_buton.Size = new Size(93, 37);
            sil_buton.TabIndex = 12;
            sil_buton.Text = "Sil";
            sil_buton.UseVisualStyleBackColor = true;
            sil_buton.Click += sil_buton_Click;
            // 
            // guncelle_buton
            // 
            guncelle_buton.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guncelle_buton.Location = new Point(289, 285);
            guncelle_buton.Name = "guncelle_buton";
            guncelle_buton.Size = new Size(93, 37);
            guncelle_buton.TabIndex = 13;
            guncelle_buton.Text = "Güncelle";
            guncelle_buton.UseVisualStyleBackColor = true;
            guncelle_buton.Click += guncelle_buton_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(410, 285);
            button4.Name = "button4";
            button4.Size = new Size(101, 37);
            button4.TabIndex = 14;
            button4.Text = "Ana Sayfa";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // kullanici_Isım_Lbl
            // 
            kullanici_Isım_Lbl.AutoSize = true;
            kullanici_Isım_Lbl.BackColor = Color.LemonChiffon;
            kullanici_Isım_Lbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            kullanici_Isım_Lbl.Location = new Point(782, 63);
            kullanici_Isım_Lbl.Name = "kullanici_Isım_Lbl";
            kullanici_Isım_Lbl.Size = new Size(128, 28);
            kullanici_Isım_Lbl.TabIndex = 15;
            kullanici_Isım_Lbl.Text = "Burak Gonca";
            // 
            // OgunGir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(963, 713);
            Controls.Add(kullanici_Isım_Lbl);
            Controls.Add(button4);
            Controls.Add(guncelle_buton);
            Controls.Add(sil_buton);
            Controls.Add(ekle_buton);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox3_yiyecek);
            Controls.Add(comboBox1_ogun);
            Controls.Add(dateTimePicker1);
            Name = "OgunGir";
            Text = "OgunGir";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1_ogun;
        private ComboBox comboBox3_yiyecek;
        private Label label1;
        private Label label2;
        private Label label4;
        private DataGridView dataGridView1;
        private Button ekle_buton;
        private Button sil_buton;
        private Button guncelle_buton;
        private Button button4;
        private Label kullanici_Isım_Lbl;
    }
}