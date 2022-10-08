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
	public partial class user_setting : Form
	{
		int id_imege_new = -1, new_ckin_p = -1; planets plnts; users users_p; int id_users;
		char[] charsToTrim = { '*', ' ', '\'' };
		public user_setting(int id_user)
		{
			InitializeComponent();
			id_users = id_user;
			plnts = planets.get_planets_info(id_user);
			name_p.Text = plnts.names_planets;
			txt_cors.Text = "[ " + plnts.G.ToString() + ":" + plnts.P.ToString() + " ]";
			picture_planet.Image = imageList_planets.Images[plnts.p_imege];
			users_p = users.seting_users_open_Form(id_user);
			txt_login.Text = users_p.login;
			email_txt.Text = users_p.email;
			txt_pass.Text = users_p.pass;
			combo_wom.SelectedIndex = Convert.ToInt32(users_p.sex);
			if (users_p.sex == false)
				picture_avatar.Image = imageList_User_M.Images[users_p.avatar_imege]; // Convert.ToInt32(users.avatar_imege);
			else
				picture_avatar.Image = imageList_User_G.Images[users_p.avatar_imege];

		}

		private void change_image_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			flowLayoutPanel1.Visible = true;
			if (combo_wom.SelectedIndex == 0)
			{
				pictureBox16.Image = imageList_User_M.Images[0];
				pictureBox17.Image = imageList_User_M.Images[1];
				pictureBox18.Image = imageList_User_M.Images[2];
				pictureBox19.Image = imageList_User_M.Images[3];
				pictureBox20.Image = imageList_User_M.Images[4];
				pictureBox21.Image = imageList_User_M.Images[5];
				pictureBox22.Image = imageList_User_M.Images[6];
				pictureBox23.Image = imageList_User_M.Images[7];
			}
			else
			{
				pictureBox16.Image = imageList_User_G.Images[0];
				pictureBox17.Image = imageList_User_G.Images[1];
				pictureBox18.Image = imageList_User_G.Images[2];
				pictureBox19.Image = imageList_User_G.Images[3];
				pictureBox20.Image = imageList_User_G.Images[4];
				pictureBox21.Image = imageList_User_G.Images[5];
				pictureBox22.Image = imageList_User_G.Images[6];
				pictureBox23.Image = imageList_User_G.Images[7];
			}
		}
		private void PB_MouseEnter(object sender, EventArgs e)
		{
			id_imege_new = Convert.ToInt32((sender as PictureBox).Tag);
			using (Graphics g = (sender as PictureBox).CreateGraphics())
			{
				g.DrawRectangle(new Pen(Color.Red, 5), 0, 0, (sender as PictureBox).Width, (sender as PictureBox).Height);
			}
		}
		private void PB_MouseClic(object sender, EventArgs e)
		{


			if (flowLayoutPanel1.Visible == true)
			{
				id_imege_new = Convert.ToInt32((sender as PictureBox).Tag) - 1;
				if (combo_wom.SelectedIndex == 0)
					picture_avatar.Image = imageList_User_M.Images[id_imege_new];
				else
					picture_avatar.Image = imageList_User_G.Images[id_imege_new];
			}
			else
			{
				new_ckin_p = Convert.ToInt32((sender as PictureBox).Tag);
				picture_planet.Image = imageList_planets.Images[new_ckin_p];
			}
			flowLayoutPanel.Visible = false;
			flowLayoutPanel1.Visible = false;
		}
		private void PB_MouseLeave(object sender, EventArgs e)
		{
			(sender as PictureBox).Invalidate();
			//(sender as PictureBox).BackColor = Color.Transparent;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			flowLayoutPanel.Visible = true;

			pictureBox1.Image = imageList_planets.Images[0];
			pictureBox2.Image = imageList_planets.Images[1];
			pictureBox3.Image = imageList_planets.Images[2];
			pictureBox4.Image = imageList_planets.Images[3];
			pictureBox5.Image = imageList_planets.Images[4];
			pictureBox6.Image = imageList_planets.Images[5];
			pictureBox7.Image = imageList_planets.Images[6];
			pictureBox8.Image = imageList_planets.Images[7];
			pictureBox9.Image = imageList_planets.Images[8];
			pictureBox10.Image = imageList_planets.Images[9];
			pictureBox11.Image = imageList_planets.Images[10];
			pictureBox12.Image = imageList_planets.Images[11];
			pictureBox13.Image = imageList_planets.Images[12];
			pictureBox14.Image = imageList_planets.Images[13];
			pictureBox15.Image = imageList_planets.Images[14];

		}

		private void txt_new_pass_TextChanged(object sender, EventArgs e)
		{
			txt_new_pass.Text = txt_new_pass.Text.Trim(charsToTrim);
		}

		private void sava_users_Click(object sender, EventArgs e)
		{
			if (txt_new_pass.Text.Trim(charsToTrim) == txt_repiat_pass.Text.Trim(charsToTrim))
			{
				if (txt_login.Text.Trim(charsToTrim) != "" && txt_pass.Text.Trim(charsToTrim) != "" && email_txt.Text.Trim(charsToTrim) != "")
				{
					users users_new = new users();
					users_new.login = txt_login.Text.Trim(charsToTrim);
					if (txt_repiat_pass.Text.Trim(charsToTrim) != "")
						users_new.pass = txt_repiat_pass.Text.Trim(charsToTrim);
					else
						users_new.pass = txt_pass.Text;
					users_new.email = email_txt.Text;
					users_new.sex = Convert.ToBoolean(combo_wom.SelectedIndex);
					if (id_imege_new != -1)
						users_new.avatar_imege = id_imege_new;
					else
						users_new.avatar_imege = users_p.avatar_imege;
					DialogResult result = MessageBox.Show(
					"Вы уверенны что хотите обновить свои данные  ?!",
					"Сообщение",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Information,
					MessageBoxDefaultButton.Button1);
					if (result == DialogResult.Yes)
					{
						if (users.save_UpDate_user(users_new, id_users))
							MessageBox.Show("Данные изменены!");
						else
							MessageBox.Show("Фатальная ошибка изменения");
					}

				}
				else
					MessageBox.Show("Какое-то поле равняеться пустоте!!!");
			}
			else
				MessageBox.Show("Новый пароль и повтор не совпали!!!");
		}

		private void txt_login_TextChanged(object sender, EventArgs e)
		{
			txt_login.Text = txt_login.Text.Trim(charsToTrim);

		}

		private void txt_repiat_pass_TextChanged(object sender, EventArgs e)
		{
			txt_repiat_pass.Text = txt_repiat_pass.Text.Trim(charsToTrim);
		}

		private void sava_planets_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
					"Вы уверенны что хотите обновить свои данные  ?!",
					"Сообщение",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Information,
					MessageBoxDefaultButton.Button1);
			if (result == DialogResult.Yes)
			{
				if (name_p.Text.Trim(charsToTrim).ToString() != "")
				{
					if (new_ckin_p != -1)
					{
						if (planets.upLoad_planets_blds(id_users, name_p.Text.Trim(charsToTrim).ToString(), new_ckin_p))
							MessageBox.Show("Данные планеты изменены!");
						else
							MessageBox.Show("Фатальная ошибка изменения");
					}
					else
					{
						if (planets.upLoad_planets_blds(id_users, name_p.Text.Trim(charsToTrim).ToString(), plnts.p_imege))
							MessageBox.Show("Данные планеты изменены!");
						else
							MessageBox.Show("Фатальная ошибка изменения");
					}
				}
				else
					MessageBox.Show("Наименвание планеты не может быть пустым!!!");
			}
		}
	}
}
