using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIPLOM_SAV.heard_games;

namespace DIPLOM_SAV
{
	public partial class Deff_F : Form
	{
		int My_id;
		public Deff_F(int id_user)
		{
			InitializeComponent();
			My_id = id_user;
			load_deff();
		}
		private void PB_MouseEnter(object sender, EventArgs e)
		{
			using (Graphics g = (sender as PictureBox).CreateGraphics())
			{
				g.DrawRectangle(new Pen(Color.Red, 10), 0, 0, (sender as PictureBox).Width, (sender as PictureBox).Height);
			}
		}
		private void PB_MouseLeave(object sender, EventArgs e)
		{
			(sender as PictureBox).Invalidate();
		}

		private void Clic_deff(object sender, EventArgs e)
		{
			int flag = Convert.ToInt32((sender as PictureBox).Tag);
			List<requirement_trb> trb = requirement_trb.get_requirement_trb(My_id, flag, 300400);
			bool trb_activ_forms = false;
			for (int i = 0; i < trb.Count(); i++)
			{
				if (trb.ElementAt(i).trb_level > trb.ElementAt(i).have_leval)
				{
					trb_activ_forms = true;
				}
			}
			if (trb_activ_forms == true)
			{
				var F = new forma_treb_FLT_DEFF(My_id, flag);
				F.StartPosition = FormStartPosition.CenterScreen;
				F.ShowDialog();
			}
			else
			{
				var F = new Bye_Flot_And_Deff(My_id,flag);
				F.StartPosition = FormStartPosition.CenterScreen;
				F.ShowDialog();
			}
		}
		private void load_deff()
		{
			fleets_deff deff = fleets_deff.get_fleets_deff(My_id);
			t401.Text += deff.deff_401.ToString();
			t402.Text += deff.deff_402.ToString();
			t403.Text += deff.deff_403.ToString();
			t404.Text += deff.deff_404.ToString();
			t405.Text += deff.deff_405.ToString();
			t406.Text += deff.deff_406.ToString();
		}
	}
}
