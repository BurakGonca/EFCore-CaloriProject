namespace CaloriProject.UI;
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

    public partial class Giris : Form
{

    SqlConnection connect = new SqlConnection(@"Data Source=KASKADE;Initial Catalog=loginEkrani_c#;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    public Giris()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btn_girisYap_Click(object sender, EventArgs e)
    {
        if (g_email_textBox.Text == "" || g_sifre_textBox.Text == "")
        {
            MessageBox.Show("L�tfen b�t�n bo� alanlar� doldurun.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    String selectData = "SELECT * FROM users WHERE Email = @email AND Sifre = @sifre";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@email", g_email_textBox.Text);
                        cmd.Parameters.AddWithValue("@sifre", g_sifre_textBox.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("Ba�ar�yla giri� yap�ld�.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("�ifre veya E-mail yanl��", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }

            }

        }
    }
}

