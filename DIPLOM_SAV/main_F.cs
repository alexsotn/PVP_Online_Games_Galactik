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
	public partial class main_F : Form
	{
		int udi_user = -1;
		int sec = 0;
		users User;
		resurs_planets res_p;
		public main_F(int ID)
		{
			InitializeComponent();
			udi_user = ID;
			users.online_stat(udi_user, 1);
			var form_satrt = new Bilds_Aren_F(udi_user);
			form_satrt.MdiParent = this;
			form_satrt.WindowState = FormWindowState.Maximized;
			load_resurs(); load_newSms_and_credits();
			form_satrt.Show();

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//ресурсы
			pb_metal.Image = ListI_resurs.Images[0];
			pb_kristal.Image = ListI_resurs.Images[1];
			pb_detr.Image = ListI_resurs.Images[2];
			pb_solar.Image = ListI_resurs.Images[3];
			pb_kredit.Image = ListI_resurs.Images[4];
			pb_sms.Image = ListI_resurs.Images[5];

			//избражения иконок меню
			BT_view.Image = LI_menu.Images[0];
			BT_imperiya.Image = LI_menu.Images[1];
			BT_Galactik.Image = LI_menu.Images[2];
			BT_Fleet.Image = LI_menu.Images[3];
			BT_Bilds.Image = LI_menu.Images[4];
			BT_Tech.Image = LI_menu.Images[5];
			BT_werf.Image = LI_menu.Images[6];
			BT_Offer.Image = LI_menu.Images[7];
			BT_market.Image = LI_menu.Images[8];
			BT_message.Image = LI_menu.Images[9];
			BT_tech_tree.Image = LI_menu.Images[10];
			BT_rating.Image = LI_menu.Images[11];
			BT_simulator.Image = LI_menu.Images[12];
			BT_profil_user.Image = LI_menu.Images[13];
			PB_bt_exit.Image = LI_menu.Images[14];

			//загрузка данных
			timer.Start();

		}
		//Подцветка кнопок
		private void PB_MouseEnter(object sender, EventArgs e)
		{
			(sender as PictureBox).BackColor = Color.Blue;
		}
		private void PB_MouseLeave(object sender, EventArgs e)
		{
			(sender as PictureBox).Invalidate();
			(sender as PictureBox).BackColor = Color.Transparent;
		}
		//**********
		private void Clic_open_page(object sender, EventArgs e)
		{

			//	MessageBox.Show(Convert.ToString((sender as PictureBox).Tag));
			int flag = Convert.ToInt32((sender as PictureBox).Tag);
			switch (flag)
			{
				case 1:
					var form_1 = new view_F(udi_user);
					form_1.MdiParent = this;
					form_1.WindowState = FormWindowState.Maximized;
					form_1.Show();
					break;
				case 2:
					var form_2 = new imperiy_F(udi_user);
					form_2.MdiParent = this;
					form_2.WindowState = FormWindowState.Maximized;
					form_2.Show();
					break;
				case 3:
					var form_3 = new Galactika_F(udi_user, this, udi_user);
					form_3.MdiParent = this;
					form_3.WindowState = FormWindowState.Maximized;
					form_3.Show();
					break;
				case 4:
					var form_4 = new fleets_F(udi_user, null);
					form_4.MdiParent = this;
					form_4.WindowState = FormWindowState.Maximized;
					form_4.Show();
					break;
				case 5:
					var form_5 = new Bilds_Aren_F(udi_user);
					form_5.MdiParent = this;
					form_5.Icon = Icon;
					form_5.Show();
					break;
				case 6:
					var form_6 = new researches_F(udi_user);
					form_6.MdiParent = this;
					form_6.Icon = Icon;
					form_6.Show();
					break;
				case 7:
					var form_7 = new Fleet_F(udi_user);
					form_7.MdiParent = this;
					form_7.Icon = Icon;
					form_7.Show();
					break;
				case 8:
					var form_8 = new Deff_F(udi_user);
					form_8.MdiParent = this;
					form_8.Icon = Icon;
					form_8.WindowState = FormWindowState.Maximized;
					form_8.Show();
					break;
				case 9:
					var form_9 = new market_F();
					form_9.MdiParent = this;
					form_9.WindowState = FormWindowState.Maximized;
					form_9.Show();
					break;
				case 10:
					var form_10 = new messing(udi_user,this);
					form_10.MdiParent = this;
					form_10.Icon = Icon;
					form_10.Show();
					break;
				case 11:
					break;
				case 12:
					var form_12 = new rating_F(this, udi_user);
					form_12.MdiParent = this;
					form_12.WindowState = FormWindowState.Maximized;
					form_12.Show();
					break;
				case 13:
					var form_13 = new Simulytor_F();
					form_13.MdiParent = this;
					form_13.WindowState = FormWindowState.Maximized;
					form_13.Show();
					break;
				case 14:
					var form_14 = new user_setting(udi_user);
					form_14.MdiParent = this;
					form_14.WindowState = FormWindowState.Maximized;
					form_14.Show();
					break;
			}
			MdiChildren[0].Close();
		}

		private void PB_bt_exit_Click(object sender, EventArgs e)
		{
			users.online_stat(udi_user, 0);
			var form = new avtorization();
			form.StartPosition = FormStartPosition.CenterScreen;
			form.Show();
			Close();
		}

		private void sms_count_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var form = new messing(udi_user,this);
			form.MdiParent = this;
			form.Icon = Icon;
			form.Show();
			MdiChildren[0].Close();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			status_games_user();
			load_newSms_and_credits();
			if (sec == 5)
			{
				load_resurs();
				sec = 0;
			}
			else
				sec++;
		}

		private void load_resurs()
		{
			res_p = resurs_planets.load_res(udi_user);
			t_s_m.Text = res_p.res_metal.ToString("#,#");
			t_s_k.Text = res_p.res_kristal.ToString("#,#");
			t_s_d.Text = res_p.res_deuterium.ToString("#,#");
			t_s_s.Text = res_p.res_energy.ToString("#,#");

			t_v_m.Text = res_p.capacity_metal.ToString("#,#");
			t_v_k.Text = res_p.capacity_kristal.ToString("#,#");
			t_v_d.Text = res_p.capacity_deuterium.ToString("#,#");
			t_v_s.Text = res_p.capacity_energy.ToString("#,#");
		}
		private void load_newSms_and_credits()
		{
			User = users.load_SMS_and_Credits(udi_user);
			t_s_KRD.Text = User.credits.ToString();
			sms_count.Text = User.new_message.ToString();
		}

		private void status_games_user()
		{
			users.status_online onl_list =  users.status_online.load_data();
			users_online.Text = onl_list.user_online_counts.ToString();
			count_user_all.Text = onl_list.user_online_all.ToString();
		}


	}
}
