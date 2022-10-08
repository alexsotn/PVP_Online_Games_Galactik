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
	public partial class Bilds_Aren_F : Form
	{
		int my_ID; timer_tech_prom_deff_fleets timers_list;
		public Bilds_Aren_F(int id_owners)
		{
			InitializeComponent();
			my_ID = id_owners;
			panel13.Visible = false;
			timer.Start();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Maximized;
		}


		//***********
		private void Clic_blds(object sender, EventArgs e)
		{
			//MessageBox.Show(Convert.ToString((sender as PictureBox).Tag));
			/*
				 * 101  - Рудник метала
				 * 102  - Р кристала
				 * 103  - Р дейтерия
				 *	
				 * 105	- Скдал метал
				 * 106	- крсиатл
				 * 107	- дейтерий
				 *
				 *	108 - Лаборатория
				 *	109 - Фаб нанитов
				 *	110 - Фаб роб
				 *	111 - верфь
				 *	112 - терраформер
				 *	113 - солничная станция
			 */
			int flag = Convert.ToInt32((sender as PictureBox).Tag);
			var F = new Bilds_And_Reserv_Date_F(my_ID, flag, panel13.Visible);
			F.StartPosition = FormStartPosition.CenterScreen;
			F.ShowDialog();
			timer.Start();
		}

		private void PB_MouseEnter(object sender, EventArgs e)
		{
			using (Graphics g = (sender as PictureBox).CreateGraphics())
			{
				g.DrawEllipse(new Pen(Color.Red, 4), 0, 0, (sender as PictureBox).Width, (sender as PictureBox).Height);
			}
		}
		private void PB_MouseLeave(object sender, EventArgs e)
		{
			(sender as PictureBox).Invalidate();
		}

		private void load_Blds(int id_iwner)
		{
			planets pln = planets.set_planets_info_from_Arens(id_iwner);
			Lv_metal.Text = "Рудник метала: " + pln.bld_mine_metal.ToString() + " ур.";
			Lv_kristal.Text = "Рудник кристала: " + pln.bld_mine_kristal.ToString() + " ур.";
			Lv_drt.Text = "Рудник дейтерия: " + pln.bld_mine_deuterium.ToString() + " ур.";
			Lv_metal_S.Text = "Склад метала: " + pln.bld_warehouse_metal.ToString() + " ур.";
			Lv_kristal_S.Text = "Склад кристала: " + pln.bld_warehouse_kristal.ToString() + " ур.";
			Lv_dtr_S.Text = "Склад дейтерия: " + pln.bld_warehouse_deuterium.ToString() + " ур.";
			Lv_solar.Text = "Солнечная станция: " + pln.bld_solar_plant.ToString() + " ур.";
			Lv_terraF.Text = "Терраформер: " + pln.bld_terraformer.ToString() + " ур.";
			Lv_lab.Text = "Лабратория: " + pln.bld_laboratory.ToString() + " ур.";
			Lv_nota_fab.Text = "Фабрика нанитов: " + pln.bld_nano_factory.ToString() + " ур.";
			Lv_fab_rob.Text = "Фабриак роботов: " + pln.bld_robot_factory.ToString() + " ур.";
			Lv_werf.Text = "Верфь: " + pln.bld_shipyard.ToString() + "ур.";
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			timers_list = timer_tech_prom_deff_fleets.timers_bld_and_proms(my_ID, 100);
			if (timers_list != null)
			{
				load_Blds(my_ID);
				panel13.Visible = true;
				name_bld.Text = timers_list.names.ToString();
				time_bld.Text = timers_list.times_str.ToString();
			}
			else
			{
				timer.Stop();
				load_Blds(my_ID);
				panel13.Visible = false;
			}
		}

		private void cansel_bt_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
				"Вы уверенны что хотите отменить постойку ? \n Ресурсы обратно не вернуться!!!",
					"Сообщение",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Information,
					MessageBoxDefaultButton.Button1);
			if (result == DialogResult.Yes)
			{
				if (timer_tech_prom_deff_fleets.bld_tech_Cansel(timers_list.id_planets, timers_list.code_bld_tech_FD))
				{
					MessageBox.Show("Постройка отменена!");
				}
				else
					MessageBox.Show("Отмена не удалась. Попробуйте позже!!!");
			}
		}
	}
}
