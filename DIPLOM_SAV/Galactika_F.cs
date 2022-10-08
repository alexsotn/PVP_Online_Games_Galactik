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
	public partial class Galactika_F : Form
	{
		int id_planet = 0, id_user; main_F F;
		List<galactikCoor> coor;
		public Galactika_F(int galactik, main_F f, int us)
		{
			InitializeComponent();
			F = f;
			id_user = us;
			load_galactik(galactik);

		}

		private void menu_activity_Opening(object sender, CancelEventArgs e)
		{

		}
		private void Clic_atta(object sender, EventArgs e)
		{
			galactikCoor attcoor = coor.FindLast(p => p.P == id_planet);
			var form_1 = new  fleets_F(id_user, attcoor);
			form_1.MdiParent =F;
			form_1.Show();
		}
		private void PB_MouseEnter(object sender, EventArgs e)
		{
			id_planet = Convert.ToInt32((sender as PictureBox).Tag);
			using (Graphics g = (sender as PictureBox).CreateGraphics())
			{
				g.DrawEllipse(new Pen(Color.Red, 5), 0, 0, (sender as PictureBox).Width, (sender as PictureBox).Height);
			}
		}

		private void Galactika_F_Load(object sender, EventArgs e)
		{

		}
		private void PB_MouseLeave(object sender, EventArgs e)
		{
			(sender as PictureBox).Invalidate();
		}

		private void Clic_info_user(object sender, EventArgs e)
		{
			var form_1 = new inform_user(id_user, users.set_ID_owner(Convert.ToInt32(txt_galactik.Text), id_planet).id, F);
			form_1.StartPosition = FormStartPosition.CenterScreen;
			tableLayoutPanel1.Visible = false;
			form_1.ShowDialog();
			tableLayoutPanel1.Visible = true;
		}
		private void Clic_sms_user(object sender, EventArgs e)
		{
			var form_1 = new setn_sms(id_user,users.set_ID_owner(Convert.ToInt32(txt_galactik.Text), id_planet).id, users.set_ID_owner(Convert.ToInt32(txt_galactik.Text), id_planet).login);
			form_1.StartPosition = FormStartPosition.CenterScreen;
			tableLayoutPanel1.Visible = false;
			form_1.ShowDialog();
			tableLayoutPanel1.Visible = true;
		}
		private void Clic_spy(object sender, EventArgs e)
		{
			//int flag = Convert.ToInt32((sender as PictureBox).Tag);
			galactikCoor attcoor = coor.FindLast(p => p.P == id_planet);
			var form_1 = new spy_forms_planets(id_user, attcoor);
			form_1.StartPosition = FormStartPosition.CenterScreen;
			form_1.ShowDialog();
		}

		private void bt_next_Click(object sender, EventArgs e)
		{

			if ((Convert.ToInt32(txt_galactik.Text) + 1) <= 100)
			{
				txt_galactik.Text = (Convert.ToInt32(txt_galactik.Text) + 1).ToString();
				load_galactik(Convert.ToInt32(txt_galactik.Text));
			}
		}

		private void bt_back_Click(object sender, EventArgs e)
		{
			int bact_i = Convert.ToInt32(txt_galactik.Text) - 1;

			if (bact_i != 0)
			{
				txt_galactik.Text = (Convert.ToInt32(txt_galactik.Text) - 1).ToString();
				load_galactik(Convert.ToInt32(txt_galactik.Text));
			}
		}

		private void txt_galactik_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
			{
				e.Handled = true;
			}
		}

		private void txt_galactik_TextChanged(object sender, EventArgs e)
		{
			int bact_i = 1;
			if (txt_galactik.Text != "")
			{
				bact_i = Convert.ToInt32(txt_galactik.Text);
				if (txt_galactik.Text.ElementAt(0).ToString() == "0")
				{
					txt_galactik.Text = "1";
				}
			}
			//int bact_i = Convert.ToInt32(txt_galactik.Text);
			if (bact_i <= 0)
			{
				txt_galactik.Text = "1";
			}
		}


		private void load_galactik(int galactik)
		{
			fuc_clear();
			coor = galactikCoor.list_galactik(galactik);
			if (coor.Count > 0)
			{
				txt_galactik.Text = coor.ElementAt(0).G.ToString(); ;
				for (int i = 0; i < coor.Count; i++)
				{

					switch (coor.ElementAt(i).P)
					{
						case 1:
							planet_1.Visible = true;
							planet_1.Enabled = ative_m(coor.ElementAt(i).id_user);
							name_planet_1.Text = coor.ElementAt(i).names_planets;
							pictureBox1.Image = Planet_images.Images[coor.ElementAt(i).p_imege];
							break;
						case 2:
							planet_2.Visible = true;
							planet_2.Enabled = ative_m(coor.ElementAt(i).id_user);
							name_planet_2.Text = coor.ElementAt(i).names_planets;
							pictureBox2.Image = Planet_images.Images[coor.ElementAt(i).p_imege];
							break;
						case 3:
							planet_3.Visible = true;
							planet_3.Enabled = ative_m(coor.ElementAt(i).id_user);
							name_planet_3.Text = coor.ElementAt(i).names_planets;
							pictureBox3.Image = Planet_images.Images[coor.ElementAt(i).p_imege];
							break;
						case 4:
							planet_4.Visible = true;
							planet_4.Enabled = ative_m(coor.ElementAt(i).id_user);
							name_planet_4.Text = coor.ElementAt(i).names_planets;
							pictureBox4.Image = Planet_images.Images[coor.ElementAt(i).p_imege];
							break;
						case 5:
							planet_5.Visible = true;
							planet_5.Enabled = ative_m(coor.ElementAt(i).id_user);
							name_planet_5.Text = coor.ElementAt(i).names_planets;
							pictureBox5.Image = Planet_images.Images[coor.ElementAt(i).p_imege];
							break;
						case 6:
							planet_6.Visible = true;
							planet_6.Enabled = ative_m(coor.ElementAt(i).id_user);
							name_planet_6.Text = coor.ElementAt(i).names_planets;
							pictureBox6.Image = Planet_images.Images[coor.ElementAt(i).p_imege];
							break;
						case 7:
							planet_7.Visible = true;
							planet_7.Enabled = ative_m(coor.ElementAt(i).id_user);
							name_planet_7.Text = coor.ElementAt(i).names_planets;
							pictureBox7.Image = Planet_images.Images[coor.ElementAt(i).p_imege];
							break;
						case 8:
							planet_8.Visible = true;
							planet_8.Enabled = ative_m(coor.ElementAt(i).id_user);
							name_planet_8.Text = coor.ElementAt(i).names_planets;
							pictureBox8.Image = Planet_images.Images[coor.ElementAt(i).p_imege];
							break;
						case 9:
							planet_9.Visible = true;
							planet_9.Enabled = ative_m(coor.ElementAt(i).id_user);
							name_planet_9.Text = coor.ElementAt(i).names_planets;
							pictureBox9.Image = Planet_images.Images[coor.ElementAt(i).p_imege];
							break;

					}
				}
			}
		}

		private void fuc_clear()
		{
			planet_1.Visible = false;
			planet_2.Visible = false;
			planet_3.Visible = false;
			planet_4.Visible = false;
			planet_5.Visible = false;
			planet_6.Visible = false;
			planet_7.Visible = false;
			planet_8.Visible = false;
			planet_9.Visible = false;
		}
		public bool ative_m(int id)
		{
			if (id == this.id_user)
				return false;
			return true;
		}

	}
}
