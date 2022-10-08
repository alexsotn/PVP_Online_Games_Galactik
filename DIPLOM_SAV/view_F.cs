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
	public partial class view_F : Form
	{
		int uid_user = -1;
		int sec_bld = 0, sec_tech = 0, sec_fleets = 0, sec_deff = 0;
		int timer_tik = 0;
		List<timer_tech_prom_deff_fleets> List_BldTectFleetsDeff;
		prom_war_level pw_level;
		statistik_user rtg;
		planets plnts;
		public view_F(int ID)
		{
			InitializeComponent();
			uid_user = ID;
			load_timer_List(uid_user);
			load_PWL(uid_user);
			prom_statistik(uid_user);
			load_date_planets(uid_user);
			//list_attaked(uid_user);
			panel3.Visible = false;
		}

		private void view_F_Load(object sender, EventArgs e)
		{
			//list_grid.Rows.Clear();
			//вкл таймер обратного отсчета
			list_grid.DataSource = ataked_planed_timer.get_list_ataaked(uid_user);
			timer1.Enabled = true;
			timer1.Start();
		}


		private void timer1_Tick(object sender, EventArgs e)
		{
			sec_bld--; sec_tech--; sec_fleets--; sec_deff--;
			if (sec_bld > 0)
				time_bilds.Text = timer_Convet_Minuts(sec_bld);
			if (sec_tech > 0)
				time_tech.Text = timer_Convet_Minuts(sec_tech);
			if (sec_fleets > 0)
				time_att.Text = timer_Convet_Minuts(sec_fleets);
			if (sec_deff > 0)
				time_deff.Text = timer_Convet_Minuts(sec_deff);

			if (timer_tik == 10)
			{
				timer_tik = 0;
				load_timer_List(uid_user);
			}
			else
				timer_tik++;
			list_update_timet(uid_user);
		}
		public string timer_Convet_Minuts(int sec)
		{
			int minutes = sec / 60;
			int newSec = sec - minutes * 60;
			int hour = minutes / 60;
			int newMinnutes = minutes - hour * 60;
			TimeSpan time = new TimeSpan(hour, newMinnutes, newSec);
			return time.ToString();
		}
		private void load_timer_List(int ID)
		{
			time_bilds.Text = "Ничего не заданно";
			time_tech.Text = "Ничего не заданно";
			time_att.Text = "Ничего не заданно";
			time_deff.Text = "Ничего не заданно";

			List_BldTectFleetsDeff = timer_tech_prom_deff_fleets.bld_tech_fleets_deff_view_t(ID);
			for (int i = 0; i < List_BldTectFleetsDeff.Count(); i++)
			{
				if (List_BldTectFleetsDeff.ElementAt(i).code_bld_tech_FD > 100 && List_BldTectFleetsDeff.ElementAt(i).code_bld_tech_FD < 200)
				{
					if (List_BldTectFleetsDeff.ElementAt(i).time_left > 0)
					{
						time_bilds.Text = List_BldTectFleetsDeff.ElementAt(i).time_left.ToString();
						sec_bld = List_BldTectFleetsDeff.ElementAt(i).time_left;
					}

				}
				if (List_BldTectFleetsDeff.ElementAt(i).code_bld_tech_FD > 200 && List_BldTectFleetsDeff.ElementAt(i).code_bld_tech_FD < 300)
				{
					if (List_BldTectFleetsDeff.ElementAt(i).time_left > 0)
					{
						time_tech.Text = List_BldTectFleetsDeff.ElementAt(i).time_left.ToString();
						sec_tech = List_BldTectFleetsDeff.ElementAt(i).time_left;
					}

				}
				if (List_BldTectFleetsDeff.ElementAt(i).code_bld_tech_FD > 300 && List_BldTectFleetsDeff.ElementAt(i).code_bld_tech_FD < 400)
				{
					if (List_BldTectFleetsDeff.ElementAt(i).time_left > 0)
					{
						time_att.Text = List_BldTectFleetsDeff.ElementAt(i).time_left.ToString();
						sec_fleets = List_BldTectFleetsDeff.ElementAt(i).time_left;
					}

				}
				if (List_BldTectFleetsDeff.ElementAt(i).code_bld_tech_FD > 400)
				{
					if (List_BldTectFleetsDeff.ElementAt(i).time_left > 0)
					{
						time_deff.Text = List_BldTectFleetsDeff.ElementAt(i).time_left.ToString();
						sec_deff = List_BldTectFleetsDeff.ElementAt(i).time_left;
					}

				}
			}
		}
		private void load_PWL(int ID)
		{
			pw_level = prom_war_level.load_PRL(ID);
			war_win.Text += " " + pw_level.war_win.ToString("#,#");
			war_gameovar.Text += " " + pw_level.war_gameovor.ToString("#,#");
			all_war.Text += " " + (pw_level.war_win + pw_level.war_gameovor).ToString("#,#");
			exp_war.Text = pw_level.exp_var.ToString("#,#") + "/" + ((200 * Math.Pow(2, pw_level.war_lv)) / 2).ToString("#,#");
			exp_prom.Text = pw_level.exp_prom.ToString("#,#") + "/" + ((100 * Math.Pow(2, pw_level.prom_lv)) / 4).ToString("#,#");
			picture_war.Image = list_war_ID.Images[pw_level.war_imege];
			picture_prom.Image = list_prom_ID.Images[pw_level.prom_imege];
		}
		private void prom_statistik(int ID)
		{
			rtg = statistik_user.get_data_evolution(ID);
			txt_bilds.Text += " " + rtg.prom_rating.ToString("#,#");
			txt_tech.Text += " " + rtg.tech_rating.ToString("#,#");
			txt_deff.Text += " " + rtg.deff_rating.ToString("#,#");
			txt_att.Text += " " + rtg.fleets_rating.ToString("#,#");
			txt_all_prom.Text += " " + rtg.all_rating.ToString("#,#");
		}
		private void load_date_planets(int ID)
		{
			plnts = planets.get_planets_info(ID);
			name_coor.Text += " \"" + plnts.names_planets + "\" [" + plnts.G.ToString() + ":" + plnts.P.ToString() + "]";
			diamtr.Text = plnts.p_diameter.ToString("#,#");
			size_p.Text = plnts.p_busyness.ToString() + " / " + plnts.p_max_size.ToString();
			if (plnts.p_temperatura > 0)
				temperatur_p.Text = " +" + plnts.p_temperatura.ToString("#,#");
			else
				temperatur_p.Text = " " + plnts.p_temperatura.ToString("#,#");
			picture_planet.Image = list_planet_ID.Images[plnts.p_imege];
		}

		private void list_attaked(int ID)
		{
			list_grid.DataSource = ataked_planed_timer.get_list_ataaked(ID);
		}
		private void list_update_timet(int ID)
		{
			list_grid.DataSource = ataked_planed_timer.get_list_ataaked(ID);
			panel1.Height = 36 + 25 * list_grid.Rows.Count;
			color_columss_grid();

			List<ataked_planed_timer> Vrag_attak = ataked_planed_timer.List_Vrag_ataaked(ID);
			if(Vrag_attak.Count() > 0)
			{
				grid_war_in_Planets.DataSource = Vrag_attak;
				panel3.Height = 75 + 25 * grid_war_in_Planets.Rows.Count;
				panel3.Visible = true;
			}
			else
				panel3.Visible = false;
		}
		private void color_columss_grid()
		{
			for (int i = 0; i < list_grid.Rows.Count; i++)
			{
				if (Convert.ToString(this.list_grid[7, i].Value) == "Возвращение")
				{
					list_grid.Rows[i].DefaultCellStyle.BackColor = Color.Green;
				}
				if (Convert.ToString(this.list_grid[7, i].Value) == "Атаковать")
				{
					list_grid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
				}
				if (Convert.ToString(this.list_grid[7, i].Value) == "Шпионаж")
				{
					list_grid.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
				}
			}
		}
	}
}
