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
using Newtonsoft.Json;

namespace DIPLOM_SAV
{
	public partial class fleets_F : Form
	{
		fleets_deff FD;
		int udi_us; int id_varag;
		long sum_fleets = 0, sum_fly_prise_deit = 0, hold_global = 0, speds_min_global = 0;
		coorditates coordinates;
		List<pay_to_fleets_deff> fleets_param;
		public fleets_F(int id_user, galactikCoor coor)
		{
			InitializeComponent();
			galactikCoor temp = new galactikCoor();
			if (coor != null)
			{
				txt_att.Text += " #Аткаковать планету:" + coor.names_planets + " [" + coor.G.ToString() + ":" + coor.P.ToString() + "]";
				coordinates = new coorditates();
				coordinates.G = coor.G;
				coordinates.P = coor.P;
				id_varag = coor.id_user;
			}
			else
				button1.Visible = false;
			load_fleets(id_user);
			udi_us = id_user;
			fleets_param = pay_to_fleets_deff.list_flets_param(id_user);
			timer1.Start();
			timer1_Tick(null, null);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			summ_fleets();
			if (sum_fleets > 0)
			{
				fleets_deff flt = new fleets_deff();
				flt.flt_301 = Convert.ToInt32(txt_301.Value);
				flt.flt_302 = Convert.ToInt32(txt_302.Value);
				flt.flt_303 = Convert.ToInt32(txt_303.Value);
				flt.flt_304 = Convert.ToInt32(txt_304.Value);
				flt.flt_305 = Convert.ToInt32(txt_305.Value);
				flt.flt_306 = Convert.ToInt32(txt_306.Value);
				flt.flt_308 = Convert.ToInt32(txt_308.Value);
				flt.flt_309 = Convert.ToInt32(txt_309.Value);

				string JSON_flt = JsonConvert.SerializeObject(flt);
				string JSON_cordinates = JsonConvert.SerializeObject(coordinates);

				//ataked_planed_timer.JSON_coors coorrr = new ataked_planed_timer.JSON_coors(co);

				var form = new F_Attaked(udi_us, id_varag, coordinates, JSON_flt, sum_fleets, speds_min_global, hold_global, sum_fly_prise_deit, flt);
				table_GLOBAL.Visible = false;
				form.ShowDialog();
				load_fleets(udi_us);
				table_GLOBAL.Visible = true;
				txt_301.Value = 0;
				txt_302.Value = 0;
				txt_303.Value = 0;
				txt_304.Value = 0;
				txt_305.Value = 0;
				txt_306.Value = 0;
				txt_308.Value = 0;
				txt_309.Value = 0;
			}
		}

		private void load_fleets(int id_user)
		{
			panel_1.Visible = false;
			panel_2.Visible = false;
			panel_3.Visible = false;
			panel_4.Visible = false;
			panel_5.Visible = false;
			panel_6.Visible = false;
			panel_7.Visible = false;
			panel_8.Visible = false;
			panel_9.Visible = false;
			FD = fleets_deff.get_fleets_deff(id_user);
			if (FD.flt_301 > 0)
			{
				panel_1.Visible = true;
				txt_fleets_301.Text = FD.flt_301.ToString("#,#");
				txt_301.Maximum = FD.flt_301;
			}
			if (FD.flt_302 > 0)
			{
				panel_2.Visible = true;
				txt_fleets_302.Text = FD.flt_302.ToString("#,#");
				txt_302.Maximum = FD.flt_302;
			}
			if (FD.flt_303 > 0)
			{
				panel_3.Visible = true;
				txt_fleets_303.Text = FD.flt_303.ToString("#,#");
				txt_303.Maximum = FD.flt_303;
			}
			if (FD.flt_304 > 0)
			{
				panel_4.Visible = true;
				txt_fleets_304.Text = FD.flt_304.ToString("#,#");
				txt_304.Maximum = FD.flt_304;
			}
			if (FD.flt_305 > 0)
			{
				panel_5.Visible = true;
				txt_fleets_305.Text = FD.flt_305.ToString("#,#");
				txt_305.Maximum = FD.flt_305;
			}
			if (FD.flt_306 > 0)
			{
				panel_6.Visible = true;
				txt_fleets_306.Text = FD.flt_306.ToString("#,#");
				txt_306.Maximum = FD.flt_306;
			}
			if (FD.flt_307 > 0)//спутник
			{
				panel_9.Visible = true;
				txt_fleets_307.Text = FD.flt_307.ToString("#,#");
				//txt_307.Maximum = FD.flt_307;
			}
			if (FD.flt_308 > 0)// уник
			{
				panel_7.Visible = true;
				txt_fleets_308.Text = FD.flt_308.ToString("#,#");
				txt_308.Maximum = FD.flt_308;
			}
			if (FD.flt_309 > 0)// зведа
			{
				panel_8.Visible = true;
				txt_fleets_309.Text = FD.flt_309.ToString("#,#");
				txt_309.Maximum = FD.flt_309;
			}
		}

		private void clik_min(object sender, EventArgs e)
		{
			int link_min = Convert.ToInt32((sender as LinkLabel).Tag);
			switch (link_min)
			{
				case 301:
					txt_301.Value = 0;
					break;
				case 302:
					txt_302.Value = 0;
					break;
				case 303:
					txt_303.Value = 0;
					break;
				case 304:
					txt_304.Value = 0;
					break;
				case 305:
					txt_305.Value = 0;
					break;
				case 306:
					txt_306.Value = 0;
					break;
				case 308:
					txt_308.Value = 0;
					break;
				case 309:
					txt_309.Value = 0;
					break;
			}
			min_speeds();
		}
		private void clik_max(object sender, EventArgs e)
		{
			int link_max = Convert.ToInt32((sender as LinkLabel).Tag);
			switch (link_max)
			{
				case 301:
					txt_301.Value = FD.flt_301;
					break;
				case 302:
					txt_302.Value = FD.flt_302;
					break;
				case 303:
					txt_303.Value = FD.flt_303;
					break;
				case 304:
					txt_304.Value = FD.flt_304;
					break;
				case 305:
					txt_305.Value = FD.flt_305;
					break;
				case 306:
					txt_306.Value = FD.flt_306;
					break;
				case 308:
					txt_308.Value = FD.flt_308;
					break;
				case 309:
					txt_309.Value = FD.flt_309;
					break;
			}
			min_speeds();
			summ_fleets();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			list_grid.DataSource = ataked_planed_timer.get_list_ataaked(udi_us);
			list_grid.Columns["Cansel_miss"].DisplayIndex = 9;
			counts.Text = "Флоты:" + list_grid.Rows.Count;
			color_columss_grid();
			//load_fleets(udi_us);
		}
		private void list_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (list_grid.Columns[e.ColumnIndex].Name == "Cansel_miss")
			{
				int id_cells = Convert.ToInt32(this.list_grid[1, e.RowIndex].Value);
				if (Convert.ToString(this.list_grid[8, e.RowIndex].Value) == "Возвращение")
					MessageBox.Show("Флот и так возвращаеться на планету");
				else
				{
					if (ataked_planed_timer.cansel_attaked(id_cells, udi_us))
						MessageBox.Show("Миссия отменена и флот возвращаеться домой");
					else
						MessageBox.Show("Ошибка отмены флота!!!!");
				}
			}
		}
		private void summ_fleets()
		{
			sum_fleets = Convert.ToInt64(txt_301.Value + txt_302.Value + txt_303.Value + txt_304.Value + txt_305.Value + txt_306.Value + txt_308.Value + txt_309.Value);
			long hold = 0;
			sum_fly_prise_deit = 0;
			for (int i = 0; i < fleets_param.Count; i++)
			{
				switch (fleets_param.ElementAt(i).code_fleets_deff)
				{
					case 301:
						hold += Convert.ToInt32(txt_301.Value) * fleets_param.ElementAt(i).hold;
						sum_fly_prise_deit += Convert.ToInt32(txt_301.Value) * fleets_param.ElementAt(i).consumption_ditriy;
						break;
					case 302:
						hold += Convert.ToInt32(txt_302.Value) * fleets_param.ElementAt(i).hold;
						sum_fly_prise_deit += Convert.ToInt32(txt_302.Value) * fleets_param.ElementAt(i).consumption_ditriy;
						break;
					case 303:
						hold += Convert.ToInt32(txt_303.Value) * fleets_param.ElementAt(i).hold;
						sum_fly_prise_deit += Convert.ToInt32(txt_303.Value) * fleets_param.ElementAt(i).consumption_ditriy;
						break;
					case 304:
						hold += Convert.ToInt32(txt_304.Value) * fleets_param.ElementAt(i).hold;
						sum_fly_prise_deit += Convert.ToInt32(txt_304.Value) * fleets_param.ElementAt(i).consumption_ditriy;
						break;
					case 305:
						hold += Convert.ToInt32(txt_305.Value) * fleets_param.ElementAt(i).hold;
						sum_fly_prise_deit += Convert.ToInt32(txt_305.Value) * fleets_param.ElementAt(i).consumption_ditriy;
						break;
					case 306:
						hold += Convert.ToInt32(txt_306.Value) * fleets_param.ElementAt(i).hold;
						sum_fly_prise_deit += Convert.ToInt32(txt_306.Value) * fleets_param.ElementAt(i).consumption_ditriy;
						break;
					case 308:
						hold += Convert.ToInt32(txt_308.Value) * fleets_param.ElementAt(i).hold;
						sum_fly_prise_deit += Convert.ToInt32(txt_308.Value) * fleets_param.ElementAt(i).consumption_ditriy;
						break;
					case 309:
						hold += Convert.ToInt64(Convert.ToInt32(txt_309.Value) * fleets_param.ElementAt(i).hold);
						sum_fly_prise_deit += Convert.ToInt32(txt_309.Value) * fleets_param.ElementAt(i).consumption_ditriy;
						break;
				}
			}
			if (hold > 0)
			{
				txt_grus.Text = hold.ToString("#,#");
				hold_global = hold;
			}
			else
			{
				hold_global = 0;
				txt_grus.Text = "0";
			}


		}

		private void color_columss_grid()
		{
			for (int i = 0; i < list_grid.Rows.Count; i++)
			{
				if (Convert.ToString(this.list_grid[8, i].Value) == "Возвращение")
				{
					list_grid.Rows[i].DefaultCellStyle.BackColor = Color.Green;
				}
				if (Convert.ToString(this.list_grid[8, i].Value) == "Атаковать")
				{
					list_grid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
				}
				if (Convert.ToString(this.list_grid[8, i].Value) == "Шпионаж")
				{
					list_grid.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
				}
			}
		}

		private void txt_302_ValueChanged(object sender, EventArgs e)
		{
			summ_fleets();
			min_speeds();
		}

		private void min_speeds()
		{
			long min_spids = 99999999999999;
			if (Convert.ToInt32(txt_301.Value) > 0)
			{
				if (min_spids > fleets_param.ElementAt(0).speed)
					min_spids = fleets_param.ElementAt(0).speed;
			}
			if (Convert.ToInt32(txt_302.Value) > 0)
			{
				if (min_spids > fleets_param.ElementAt(1).speed)
					min_spids = fleets_param.ElementAt(1).speed;
			}
			if (Convert.ToInt32(txt_303.Value) > 0)
			{
				if (min_spids > fleets_param.ElementAt(2).speed)
					min_spids = fleets_param.ElementAt(2).speed;
			}
			if (Convert.ToInt32(txt_304.Value) > 0)
			{
				if (min_spids > fleets_param.ElementAt(3).speed)
					min_spids = fleets_param.ElementAt(3).speed;
			}
			if (Convert.ToInt32(txt_305.Value) > 0)
			{
				if (min_spids > fleets_param.ElementAt(4).speed)
					min_spids = fleets_param.ElementAt(4).speed;
			}
			if (Convert.ToInt32(txt_306.Value) > 0)
			{
				if (min_spids > fleets_param.ElementAt(5).speed)
					min_spids = fleets_param.ElementAt(5).speed;
			}
			if (Convert.ToInt32(txt_308.Value) > 0)
			{
				if (min_spids > fleets_param.ElementAt(7).speed)
					min_spids = fleets_param.ElementAt(7).speed;
			}
			if (Convert.ToInt32(txt_309.Value) > 0)
			{
				if (min_spids > fleets_param.ElementAt(8).speed)
					min_spids = fleets_param.ElementAt(8).speed;
			}
			if (min_spids != 99999999999999)
			{
				txt_speed.Text = min_spids.ToString("#,#");
				speds_min_global = min_spids;
			}
			else
			{
				txt_speed.Text = "0";
				speds_min_global = 0;
			}

		}
	}
}
