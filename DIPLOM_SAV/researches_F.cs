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
	public partial class researches_F : Form
	{
		int id_user_my; timer_tech_prom_deff_fleets timers_list;
		public researches_F(int id_user)
		{
			InitializeComponent();
			id_user_my = id_user;
			this.WindowState = FormWindowState.Maximized;
			timer1.Start();
		}

		private void researches_F_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
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

		private void Clic_researches(object sender, EventArgs e)
		{
			int flag = Convert.ToInt32((sender as PictureBox).Tag);
			var F = new Bilds_And_Reserv_Date_F(id_user_my,flag, table_active.Visible);
			F.StartPosition = FormStartPosition.CenterScreen;
			F.ShowDialog();
			timer1.Start();
		}
		private void load_tech(int id_iwner)
		{
			technologies tech = technologies.Load_tech(id_iwner);
			txt_201.Text = "Шпионаж: " + tech.spy_tech.ToString() + " ур.";
			txt_202.Text = "Компьютерная технология: " + tech.computer_tech.ToString() + " ур.";
			txt_203.Text = "Оружейная технология: " + tech.ataked_tech.ToString() + " ур.";
			txt_204.Text = "Щитовая технология: " + tech.shield_tech.ToString() + " ур.";
			txt_205.Text = "Броня космических кораблей: " + tech.defence_tech.ToString() + " ур.";
			txt_206.Text = "Энергетическая технология: " + tech.energy_tech.ToString() + " ур.";
			txt_207.Text = "Гипердвигатели кораблей: " + tech.giper_tech.ToString() + " ур.";
			txt_208.Text = "Оборона планеты: " + tech.oborona_planets_tech.ToString() + " ур.";
			txt_209.Text = "Щиты планеты: " + tech.shield_planets_tech.ToString() + " ур.";
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			timers_list = timer_tech_prom_deff_fleets.timers_bld_and_proms(id_user_my, 200);
			if (timers_list != null)
			{
				load_tech(id_user_my);
				table_active.Visible = true;
				name_tech.Text = timers_list.names.ToString();
				time_tech.Text = timers_list.times_str.ToString();
			}
			else
			{
				timer1.Stop();
				load_tech(id_user_my);
				table_active.Visible = false;
			}
		}

		private void cansel_bt_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
				"Вы уверенны что хотите отменить исследование ? \n Ресурсы обратно не вернуться!!!",
					"Сообщение",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Information,
					MessageBoxDefaultButton.Button1);
			if (result == DialogResult.Yes)
			{
				if (timer_tech_prom_deff_fleets.bld_tech_Cansel(timers_list.id_planets, timers_list.code_bld_tech_FD))
				{
					MessageBox.Show("Исследование отменено!");
				}
				else
					MessageBox.Show("Отмена не удалась. Попробуйте позже!!!");
			}
		}
	}
}
