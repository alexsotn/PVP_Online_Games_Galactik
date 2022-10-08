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
	public partial class inform_user : Form
	{
		int us_id,my_id;
		From_F_inform_user info;
		main_F F;
		public inform_user(int id_m,int id_user, main_F f)
		{
			InitializeComponent();
			F = f;
			my_id = id_m;
			us_id = id_user;
			info = From_F_inform_user.get_info_USER(id_user);
			if (!info.sex)
			{
				avarat_img.BackgroundImage = L_m.Images[info.img_avatar];
				t_sex.Text += " Мужской";
			}
			else
			{
				avarat_img.BackgroundImage = L_g.Images[info.img_avatar];
				t_sex.Text += " Женский";
			}
			t_login.Text += " " + info.login;
			t_planet.Text += " " + info.planets_data;
			picture_prom.Image = L_prom.Images[info.img_prom_scn];
			picture_war.Image = L_prom.Images[info.img_war_scn];
			t_bld.Text = info.prom_rating.ToString();
			t_tech.Text = info.tech_rating.ToString();
			t_flt.Text = info.fleets_rating.ToString();
			t_deff.Text = info.deff_rating.ToString();
			t_all.Text = info.all_rating.ToString();
			rtg_bld.Text = info.pozit_prom_r.ToString();
			rtg_tech.Text = info.pozit_tech_r.ToString();
			rtg_flt.Text = info.pozit_fllets_r.ToString();
			rtg_deff.Text = info.pozit_deff_r.ToString();
			rtg_all.Text = info.pozit_all_r.ToString();
			t_win.Text = info.war_win.ToString();
			t_govar.Text = info.war_gameovar.ToString();
			t_all_air.Text = (info.war_win + info.war_gameovar).ToString();
			if (info.war_win != 0)
				proc_war.Text = (Math.Round(Convert.ToDouble((100 * Convert.ToDouble(info.war_win)) / Convert.ToDouble(t_all_air.Text)), 2)).ToString();
			if (info.war_gameovar != 0)
				proc_over.Text = (Math.Round(Convert.ToDouble((100 * Convert.ToDouble(info.war_gameovar)) / Convert.ToDouble(t_all_air.Text)), 2)).ToString();
		}

		private void bt_close_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void sent_bt_Click(object sender, EventArgs e)
		{
			var form = new setn_sms(my_id, us_id, info.login);
			form.StartPosition = FormStartPosition.CenterScreen;
			tableL_GLOABAL.Visible = false;
			form.ShowDialog();
			tableL_GLOABAL.Visible = true;
		}

		private void t_planet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var form_3 = new Galactika_F(info.g,F, my_id);
			form_3.MdiParent = F;
			form_3.WindowState = FormWindowState.Maximized;
			Hide();
			form_3.Show();
		}
	}
}
