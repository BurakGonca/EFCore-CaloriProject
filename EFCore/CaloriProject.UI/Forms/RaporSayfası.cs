using CaloriProject.BLL.Manager.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CaloriProject.UI.Forms
{
	
	public partial class RaporSayfası : Form
	{
		KullaniciOgunYiyecekManager kullaniciOgunYiyecekManager = new KullaniciOgunYiyecekManager();
		KategoriManager kategoriManager = new KategoriManager();
		KullaniciManager kullaniciManager = new KullaniciManager();
		OgunManager ogunManager = new OgunManager();
		YiyecekManager yiyecekManager = new YiyecekManager();

		private AnaSayfa anaSayfa;

		public RaporSayfası(AnaSayfa ana)
		{
			Program.AktifSayfa = this;
			anaSayfa = ana;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Program.AktifSayfa.Hide();
			anaSayfa.Show();
		}

		private void günSonu_Click(object sender, EventArgs e)
		{
			var gunluktotal = (from koy in kullaniciOgunYiyecekManager.GetAll()
								join k in kullaniciManager.GetAll() on koy.KullaniciID equals k.Id
								join kat in kategoriManager.GetAll() on koy.KullaniciID equals kat.
								
							   


							   
							   )
				
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			DateTime today = DateTime.Today;
			

		}
	}
}
