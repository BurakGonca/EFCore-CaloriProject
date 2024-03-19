using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CaloriProject.UI.Forms
{
    public partial class UyelikOlusturma : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=KASKADE;Initial Catalog=loginEkrani_c#;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public UyelikOlusturma()
        {
            InitializeComponent();
        }

        

        private void UyelikOlusturma_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;
            label7.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;
            label8.Parent = pictureBox1;
            label8.BackColor = Color.Transparent;
            label9.Parent = pictureBox1;
            label9.BackColor = Color.Transparent;


        }

        private void btn_Olustur_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    String checkUsername = "SELECT * FROM users WHERE Email = ' " + eMail_textBox.Text.Trim() + "'";
                    using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(eMail_textBox.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users(Cinsiyet, Ad, Soyad, DogumTarihi, Kilo, Boy, Email, Sifre, SifreTekrar) VALUES(@cinsiyet,@ad,@soyad,@dogumTarihi,@kilo,@boy,@email,@sifre,@sifreTekrar)";

                            DateTime selectedDate = DogumTarihi_dateTimePicker.Value; 

                            string formattedDate = selectedDate.ToString("yyyy-MM-dd");

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@cinsiyet", radioButton_Erkek.Checked ? "Erkek" : "Kadın");
                                //cmd.Parameters.AddWithValue("@cinsiyet", radioButton_Erkek.Checked);
                                cmd.Parameters.AddWithValue("@ad", ad_textBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@soyad", soyad_textBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@dogumTarihi", formattedDate);
                                cmd.Parameters.AddWithValue("@kilo", kilo_textBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@boy", boy_textBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@email", eMail_textBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@sifre", sifre_textBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@sifreTekrar", sifreTekrar_textBox.Text.Trim());

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Başarıyla kayıt olundu.","Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //kapanıyosa sil (to switch form demiş)
                                UyelikOlusturma uyelikOlusturma = new UyelikOlusturma();
                                uyelikOlusturma.Show();
                                this.Hide();
                            }
                                }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }

            }
        }
    }
}
