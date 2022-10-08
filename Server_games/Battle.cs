using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_games
{
	public class Battle
	{
		public int Win { get; set; } // если 1 то атакущий если 2 то защитник
		public flets_deff Win_flt { get; set; }
		public string Html_raport { get; set; }
		public long Epx_win { get; set; }


		public static Battle Battels(user_war_log_attaked log)
		{
			Battle Battl = new Battle();
			long Res_All_Flt_Att = 0, Res_All_Flt_deff = 0;

			Flets_param flt_param;
			flets_deff Attaker = log.Flet_attaker;
			flets_deff Deffer = log.Flet_defer;


			long Attarer_attack = 0, Attarer_shields = 0, Attarer_armor = 0;
			long Deffer_attack = 0, Deffer_shields = 0, Deffer_armor = 0;
			int count_colums_Att = 0, count_colums_Deff = 0;


			if (Attaker.flt_301 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_ataker, 301);
				Attarer_attack += flt_param.attack * Attaker.flt_301;
				Attarer_shields += flt_param.shields * Attaker.flt_301;
				Attarer_armor += flt_param.armor * Attaker.flt_301;
				count_colums_Att++;
				Res_All_Flt_Att += flt_param.Res_all;
			}
			if (Attaker.flt_302 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_ataker, 302);
				Attarer_attack += flt_param.attack * Attaker.flt_302;
				Attarer_shields += flt_param.shields * Attaker.flt_302;
				Attarer_armor += flt_param.armor * Attaker.flt_302;
				count_colums_Att++;
				Res_All_Flt_Att += flt_param.Res_all;
			}
			if (Attaker.flt_303 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_ataker, 303);
				Attarer_attack += flt_param.attack * Attaker.flt_303;
				Attarer_shields += flt_param.shields * Attaker.flt_303;
				Attarer_armor += flt_param.armor * Attaker.flt_303;
				count_colums_Att++;
				Res_All_Flt_Att += flt_param.Res_all;
			}
			if (Attaker.flt_304 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_ataker, 304);
				Attarer_attack += flt_param.attack * Attaker.flt_304;
				Attarer_shields += flt_param.shields * Attaker.flt_304;
				Attarer_armor += flt_param.armor * Attaker.flt_304;
				count_colums_Att++;
				Res_All_Flt_Att += flt_param.Res_all;
			}
			if (Attaker.flt_305 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_ataker, 305);
				Attarer_attack += flt_param.attack * Attaker.flt_305;
				Attarer_shields += flt_param.shields * Attaker.flt_305;
				Attarer_armor += flt_param.armor * Attaker.flt_305;
				count_colums_Att++;
				Res_All_Flt_Att += flt_param.Res_all;
			}
			if (Attaker.flt_306 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_ataker, 306);
				Attarer_attack += flt_param.attack * Attaker.flt_306;
				Attarer_shields += flt_param.shields * Attaker.flt_306;
				Attarer_armor += flt_param.armor * Attaker.flt_306;
				count_colums_Att++;
				Res_All_Flt_Att += flt_param.Res_all;
			}
			if (Attaker.flt_307 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_ataker, 307);
				Attarer_attack += flt_param.attack * Attaker.flt_307;
				Attarer_shields += flt_param.shields * Attaker.flt_307;
				Attarer_armor += flt_param.armor * Attaker.flt_307;
				count_colums_Att++;
				Res_All_Flt_Att += flt_param.Res_all;
			}
			if (Attaker.flt_308 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_ataker, 308);
				Attarer_attack += flt_param.attack * Attaker.flt_308;
				Attarer_shields += flt_param.shields * Attaker.flt_308;
				Attarer_armor += flt_param.armor * Attaker.flt_308;
				count_colums_Att++;
				Res_All_Flt_Att += flt_param.Res_all;
			}
			if (Attaker.flt_309 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_ataker, 309);
				Attarer_attack += flt_param.attack * Attaker.flt_309;
				Attarer_shields += flt_param.shields * Attaker.flt_309;
				Attarer_armor += flt_param.armor * Attaker.flt_309;
				count_colums_Att++;
				Res_All_Flt_Att += flt_param.Res_all;
			}

			//так же грузим обороняющего данные
			if (Deffer.flt_301 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_deffer, 301);
				Deffer_attack += flt_param.attack * Deffer.flt_301;
				Deffer_shields += flt_param.shields * Deffer.flt_301;
				Deffer_armor += flt_param.armor * Deffer.flt_301;
				count_colums_Deff++;
				Res_All_Flt_deff += flt_param.Res_all;
			}
			if (Deffer.flt_302 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_deffer, 302);
				Deffer_attack += flt_param.attack * Deffer.flt_302;
				Deffer_shields += flt_param.shields * Deffer.flt_302;
				Deffer_armor += flt_param.armor * Deffer.flt_302;
				count_colums_Deff++; Res_All_Flt_deff += flt_param.Res_all;
			}
			if (Deffer.flt_303 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_deffer, 303);
				Deffer_attack += flt_param.attack * Deffer.flt_303;
				Deffer_shields += flt_param.shields * Deffer.flt_303;
				Deffer_armor += flt_param.armor * Deffer.flt_303;
				count_colums_Deff++; Res_All_Flt_deff += flt_param.Res_all;
			}
			if (Deffer.flt_304 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_deffer, 304);
				Deffer_attack += flt_param.attack * Deffer.flt_304;
				Deffer_shields += flt_param.shields * Deffer.flt_304;
				Deffer_armor += flt_param.armor * Deffer.flt_304;
				count_colums_Deff++; Res_All_Flt_deff += flt_param.Res_all;
			}
			if (Deffer.flt_305 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_deffer, 305);
				Deffer_attack += flt_param.attack * Deffer.flt_305;
				Deffer_shields += flt_param.shields * Deffer.flt_305;
				Deffer_armor += flt_param.armor * Deffer.flt_305;
				count_colums_Deff++; Res_All_Flt_deff += flt_param.Res_all;
			}
			if (Deffer.flt_306 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_deffer, 306);
				Deffer_attack += flt_param.attack * Deffer.flt_306;
				Deffer_shields += flt_param.shields * Deffer.flt_306;
				Deffer_armor += flt_param.armor * Deffer.flt_306;
				count_colums_Deff++; Res_All_Flt_deff += flt_param.Res_all;
			}
			if (Deffer.flt_307 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_deffer, 307);
				Deffer_attack += flt_param.attack * Deffer.flt_307;
				Deffer_shields += flt_param.shields * Deffer.flt_307;
				Deffer_armor += flt_param.armor * Deffer.flt_307;
				count_colums_Deff++; Res_All_Flt_deff += flt_param.Res_all;
			}
			if (Deffer.flt_308 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_deffer, 308);
				Deffer_attack += flt_param.attack * Deffer.flt_308;
				Deffer_shields += flt_param.shields * Deffer.flt_308;
				Deffer_armor += flt_param.armor * Deffer.flt_308;
				count_colums_Deff++; Res_All_Flt_deff += flt_param.Res_all;
			}
			if (Deffer.flt_309 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_deffer, 309);
				Deffer_attack += flt_param.attack * Deffer.flt_309;
				Deffer_shields += flt_param.shields * Deffer.flt_309;
				Deffer_armor += flt_param.armor * Deffer.flt_309;
				count_colums_Deff++; Res_All_Flt_deff += flt_param.Res_all;
			}
			if (Deffer.deff_401 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_deffer, 401);
				Deffer_attack += flt_param.attack * Deffer.deff_401;
				Deffer_shields += flt_param.shields * Deffer.deff_401;
				Deffer_armor += flt_param.armor * Deffer.deff_401;
				count_colums_Deff++;
			}
			if (Deffer.deff_402 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_deffer, 402);
				Deffer_attack += flt_param.attack * Deffer.deff_402;
				Deffer_shields += flt_param.shields * Deffer.deff_402;
				Deffer_armor += flt_param.armor * Deffer.deff_402;
				count_colums_Deff++;
			}
			if (Deffer.deff_403 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_deffer, 403);
				Deffer_attack += flt_param.attack * Deffer.deff_403;
				Deffer_shields += flt_param.shields * Deffer.deff_403;
				Deffer_armor += flt_param.armor * Deffer.deff_403;
				count_colums_Deff++;
			}
			if (Deffer.deff_404 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_deffer, 404);
				Deffer_attack += flt_param.attack * Deffer.deff_404;
				Deffer_shields += flt_param.shields * Deffer.deff_404;
				Deffer_armor += flt_param.armor * Deffer.deff_404;
				count_colums_Deff++;
			}
			if (Deffer.deff_405 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_deffer, 405);
				Deffer_attack += flt_param.attack * Deffer.deff_405;
				Deffer_shields += flt_param.shields * Deffer.deff_405;
				Deffer_armor += flt_param.armor * Deffer.deff_405;
				count_colums_Deff++;
			}
			if (Deffer.deff_406 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(log.user_deffer, 406);
				Deffer_attack += flt_param.attack * Deffer.deff_406;
				Deffer_shields += flt_param.shields * Deffer.deff_406;
				Deffer_armor += flt_param.armor * Deffer.deff_406;
				count_colums_Deff++;
			}


			string Report = table_param_Heder(log.user_ataker, log.user_deffer);
			Report += Add_Table(Attaker, log.user_ataker, count_colums_Att + 1, "Атакующий");
			Report += Add_Table(Deffer, log.user_deffer, count_colums_Deff + 1, "Защитник");

			string Raund = "";


			long R_Attarer_attack = Attarer_attack, R_Attarer_shields = Attarer_shields, R_Attarer_armor = Attarer_armor;
			long R_Deffer_attack = Deffer_attack, R_Deffer_shields = Deffer_shields, R_Deffer_armor = Deffer_armor;

			int Max_raund = 600; // количестов раундов
			try
			{
				for (int Raunnd = 0; Raunnd < Max_raund; Raunnd++)
				{
					if (Attarer_armor > 0 && Deffer_armor > 0)
					{
						long Rund_Attarer_attack = 0;
						long Rund_Deffer_attack = 0;

						if (Deffer_shields <= Attarer_attack)
						{
							Rund_Attarer_attack = Attarer_attack - Deffer_shields;
							Deffer_shields = 0;
							if (Rund_Attarer_attack >= Deffer_armor)
							{
								Attarer_attack = Attarer_attack - Deffer_armor;
								Deffer_armor = 0;
							}
							else
							{
								Deffer_armor = Deffer_armor - Rund_Attarer_attack;
							}
						}
						else
						{
							Deffer_shields = Deffer_shields - Attarer_attack;
						}

						//Обоняющийся
						if (Attarer_shields <= Deffer_attack)
						{
							Rund_Deffer_attack = Deffer_attack - Attarer_shields;
							Attarer_shields = 0;
							if (Deffer_attack >= Attarer_armor)
							{
								Deffer_attack = Deffer_attack - Attarer_armor;
								Attarer_armor = 0;
							}
							else
							{
								Attarer_armor = Attarer_armor - Rund_Deffer_attack;
							}
						}
						else
						{
							Attarer_shields = Attarer_shields - Deffer_attack;
						}
					}
					else
					{
						Raunnd = Max_raund;
						if (Attarer_armor > 0 && Deffer_armor <= 0)
						{
							double proc_poter_att = Math.Round((Convert.ToDouble((Attarer_armor * 100) / R_Attarer_armor)) / 100, 2);
							flets_deff flt = Poteri_From_Win(Attaker, proc_poter_att);
							//string html2_att = Add_Table(flt, 1, log.user_ataker, count_colums_Att + 1, "Атакующий");


							Raund += "<div class=\"div-raoud\">";
							Raund += "<caption align=\"bottom\">Защитник полностью ничтожен</caption>";
							Raund += Add_Table(flt, log.user_ataker, coutn_rows(flt) + 1, "Атакующий");
							//Raund += Add_Table(flt_Deff, 2, log.user_deffer, coutn_rows(flt_Deff) + 1, "Защитник");
							Raund += "</div>";

							string fileText = File.ReadAllText("War_repot.html");
							string HTML_repotr = fileText + Report + Raund + "</body></ html > ";

							Battl = new Battle();
							Battl.Win = 1;
							Battl.Win_flt = flt;
							Battl.Html_raport = HTML_repotr;
							Battl.Epx_win = Res_All_Flt_deff / 1000;

							return Battl;
						}
						else
						{
							double proc_poter_deff = Math.Round((Convert.ToDouble((Deffer_armor * 100) / R_Deffer_armor)) / 100, 2);
							flets_deff flt = Poteri_From_Win(Deffer, proc_poter_deff);

							Raund += "<div class=\"div-raoud\">";
							Raund += "<caption align=\"bottom\">Атакующий флот полностью ничтожен</caption>";
							Raund += Add_Table(flt, log.user_ataker, coutn_rows(flt) + 1, "Защитник");
							//Raund += Add_Table(flt_Deff, 2, log.user_deffer, coutn_rows(flt_Deff) + 1, "Защитник");
							Raund += "</div>";
							string fileText = File.ReadAllText("War_repot.html");
							string HTML_repotr = fileText + Report + Raund + "</body></ html > ";
							Battl = new Battle();
							Battl.Win = 2;
							Battl.Win_flt = flt;
							Battl.Html_raport = HTML_repotr;
							Battl.Epx_win = (Res_All_Flt_Att / 1000) / 4;
							return Battl;
						}
					}


					Raund += "<caption align=\"bottom\">Рауннд " + (Raunnd + 1).ToString() + "</caption>";
					double proc_att = Math.Round((Convert.ToDouble((Attarer_armor * 100) / R_Attarer_armor)) / 100, 2);
					flets_deff Raund_Att = Poteri_From_Win(Attaker, proc_att);
					Raund += "<div class=\"div-raoud\">";

					Raund += Add_Table(Raund_Att, log.user_ataker, coutn_rows(Raund_Att) + 1, "Атакующий");
					//Raund += Add_Table(flt_Deff, 2, log.user_deffer, coutn_rows(flt_Deff) + 1, "Защитник");
					//Raund += "</div>";

					double proc_deff = Math.Round((Convert.ToDouble((Deffer_armor * 100) / R_Deffer_armor)) / 100, 2);
					flets_deff Raund_deff = Poteri_From_Win(Deffer, proc_deff);
					//Raund += "<div class=\"div-raoud\">";
					//	Raund += "<caption align=\"bottom\">Защитник полностью ничтожен</caption>";
					Raund += Add_Table(Raund_deff, log.user_deffer, coutn_rows(Raund_deff) + 1, "Защитник");
					//Raund += Add_Table(flt_Deff, 2, log.user_deffer, coutn_rows(flt_Deff) + 1, "Защитник");
					Raund += "</div>";
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message.ToString());
			}
			return Battl;
		}

		public static flets_deff Poteri_From_Win(flets_deff flt, double Proc_poteri)
		{
			flets_deff New_flets = new flets_deff();
			New_flets.flt_301 = Convert.ToInt32(flt.flt_301 * Proc_poteri);
			New_flets.flt_302 = Convert.ToInt32(flt.flt_302 * Proc_poteri);
			New_flets.flt_303 = Convert.ToInt32(flt.flt_303 * Proc_poteri);
			New_flets.flt_304 = Convert.ToInt32(flt.flt_304 * Proc_poteri);
			New_flets.flt_305 = Convert.ToInt32(flt.flt_305 * Proc_poteri);
			New_flets.flt_306 = Convert.ToInt32(flt.flt_306 * Proc_poteri);
			New_flets.flt_307 = Convert.ToInt32(flt.flt_307 * Proc_poteri);
			New_flets.flt_308 = Convert.ToInt32(flt.flt_308 * Proc_poteri);
			New_flets.flt_309 = Convert.ToInt32(flt.flt_309 * Proc_poteri);
			New_flets.deff_401 = Convert.ToInt32(flt.deff_401 * Proc_poteri);
			New_flets.deff_402 = Convert.ToInt32(flt.deff_402 * Proc_poteri);
			New_flets.deff_403 = Convert.ToInt32(flt.deff_403 * Proc_poteri);
			New_flets.deff_404 = Convert.ToInt32(flt.deff_404 * Proc_poteri);
			New_flets.deff_405 = Convert.ToInt32(flt.deff_405 * Proc_poteri);
			New_flets.deff_406 = Convert.ToInt32(flt.deff_406 * Proc_poteri);
			return New_flets;
		}

		public static bool Attek_report(int id_Rows_timers, Battle battl, int id_att, int id_deff)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				switch (battl.Win)
				{
					case 1: // Win Attaker
						cmd.CommandText = "SERVER_returt_fleets_mission_Attaked_Win_1";// Название процедуры на сервере
						Spy_report win_res = Res_Winers(id_deff);
						cmd.Parameters.Add(new SqlParameter("@Json_flets", JsonConvert.SerializeObject(battl.Win_flt).ToString()));
						cmd.Parameters.Add(new SqlParameter("@res_m", win_res.res_m));
						cmd.Parameters.Add(new SqlParameter("@res_k", win_res.res_k));
						cmd.Parameters.Add(new SqlParameter("@res_d", win_res.res_d));
						break;
					case 2: // Win Deffer
						cmd.CommandText = "SERVER_returt_fleets_mission_Attaked_Win_2";// Название процедуры на сервере
						cmd.Parameters.Add(new SqlParameter("@flt_301", battl.Win_flt.flt_301));
						cmd.Parameters.Add(new SqlParameter("@flt_302", battl.Win_flt.flt_302));
						cmd.Parameters.Add(new SqlParameter("@flt_303", battl.Win_flt.flt_303));
						cmd.Parameters.Add(new SqlParameter("@flt_304", battl.Win_flt.flt_304));
						cmd.Parameters.Add(new SqlParameter("@flt_305", battl.Win_flt.flt_305));
						cmd.Parameters.Add(new SqlParameter("@flt_306", battl.Win_flt.flt_306));
						cmd.Parameters.Add(new SqlParameter("@flt_308", battl.Win_flt.flt_308));
						cmd.Parameters.Add(new SqlParameter("@flt_309", battl.Win_flt.flt_309));
						break;
				}

				cmd.Parameters.Add(new SqlParameter("@ID_rows", id_Rows_timers));
				cmd.Parameters.Add(new SqlParameter("@ID_att", id_att));
				cmd.Parameters.Add(new SqlParameter("@ID_defer", id_deff));
				cmd.Parameters.Add(new SqlParameter("@Win", battl.Win));
				cmd.Parameters.Add(new SqlParameter("@Win_Exp", battl.Epx_win));
				cmd.Parameters.Add(new SqlParameter("@Html_report_batll", battl.Html_raport));
				//SqlDataReader reader = cmd.ExecuteReader();
				if (cmd.ExecuteNonQuery() > 0)
				{
					conn.Close();
					return true;
				}
				conn.Close();

			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message.ToString());
				conn.Close();
			}
			return false;
		}

		private static Spy_report Res_Winers(int id_deff)
		{
			Spy_report report = new Spy_report();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "res_from_Winer_Attaker_SERVER";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_deff));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					report = new Spy_report();
					report.res_m = Convert.ToInt32(reader["res_metal"]) / 2;
					report.res_k = Convert.ToInt32(reader["res_metal"]) / 3;
					report.res_d = Convert.ToInt32(reader["res_metal"]) / 4;
					return report;
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return report;
		}

		public static string Add_Table(flets_deff flets, int id_user, int colspan, string ns)
		{
			string html = "<div class=\"table - responsive\"><table><tbody>";
			html += Heders(flets, colspan, ns);
			html += Add_rows_Сounts(flets);
			html += Add_rows_Attaked_Deffs(flets, id_user);

			return html += "</tbody></table ></div> ";
		}

		public static string Heders(flets_deff flets, int colspan, string names)
		{
			string html = "";
			html += "<tr><td colspan = \"" + colspan + "\">" + names + "</td> </tr>";

			html += "<tr>";
			html += "<td> Наименование </td>";
			if (flets.flt_301 > 0)
			{
				html += "<td>Транспортник</td>";

			}

			if (flets.flt_302 > 0)
			{
				html += "<td>Истрибитель</td>";

			}
			if (flets.flt_303 > 0)
			{
				html += "<td>Крейсер</td>";

			}
			if (flets.flt_304 > 0)
			{
				html += "<td>Линкор</td>";

			}
			if (flets.flt_305 > 0)
			{
				html += "<td>Шпионский зонд</td>";

			}
			if (flets.flt_306 > 0)
			{
				html += "<td>Бомбардировщик</td>";

			}
			if (flets.flt_307 > 0)
			{
				html += "<td>Солнечный спутник</td>";

			}
			if (flets.flt_308 > 0)
			{
				html += "<td>Уничтожитель</td>";

			}
			if (flets.flt_309 > 0)
			{
				html += "<td>Звезда смерти</td>";

			}
			if (flets.deff_401 > 0)
			{
				html += "<td>Ракетная уст.</td>";

			}
			if (flets.deff_402 > 0)
			{
				html += "<td>Лазерная уст.</td>";

			}
			if (flets.deff_403 > 0)
			{
				html += "<td>Пушка гауса</td>";
			}
			if (flets.deff_404 > 0)
			{
				html += "<td>Ионное орудие</td>";


			}
			if (flets.deff_405 > 0)
			{
				html += "<td>Плазменное орудие</td>";

			}
			if (flets.deff_406 > 0)
			{
				html += "<td>Щитовой купол</td>";

			}
			html += "</tr>";

			return html;
		}
		public static string Add_rows_Сounts(flets_deff flets)
		{
			string html = "";
			html += "<tr>";
			html += "<td> Количество </td>";
			if (flets.flt_301 > 0)
			{
				html += "<td>" + flets.flt_301 + "</td>";
			}

			if (flets.flt_302 > 0)
			{
				html += "<td>" + flets.flt_302 + "</td>";
			}
			if (flets.flt_303 > 0)
			{
				html += "<td>" + flets.flt_303 + "</td>";
			}
			if (flets.flt_304 > 0)
			{
				html += "<td>" + flets.flt_304 + "</td>";
			}
			if (flets.flt_305 > 0)
			{
				html += "<td>" + flets.flt_305 + "</td>";
			}
			if (flets.flt_306 > 0)
			{
				html += "<td>" + flets.flt_306 + "</td>";
			}
			if (flets.flt_307 > 0)
			{
				html += "<td>" + flets.flt_307 + "</td>";
			}
			if (flets.flt_308 > 0)
			{
				html += "<td>" + flets.flt_308 + "</td>";
			}
			if (flets.flt_309 > 0)
			{
				html += "<td>" + flets.flt_309 + "</td>";
			}
			if (flets.deff_401 > 0)
			{
				html += "<td>" + flets.deff_401 + "</td>";
			}
			if (flets.deff_402 > 0)
			{
				html += "<td>" + flets.deff_402 + "</td>";
			}
			if (flets.deff_403 > 0)
			{
				html += "<td>" + flets.deff_403 + "</td>";
			}
			if (flets.deff_404 > 0)
			{
				html += "<td>" + flets.deff_404 + "</td>";
			}
			if (flets.deff_405 > 0)
			{
				html += "<td>" + flets.deff_405 + "</td>";
			}
			if (flets.deff_406 > 0)
			{
				html += "<td>" + flets.deff_406 + "</td>";
			}

			html += "</tr>";
			return html;
		}
		public static string Add_rows_Attaked_Deffs(flets_deff flets, int id_user)
		{
			Flets_param flt_param = new Flets_param();
			string html = "", html_shets = "";
			html += "<tr>";
			html += "<td> Атака </td>";
			html_shets += "<tr>";
			html_shets += "<td> Броня </td>";
			if (flets.flt_301 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(id_user, 301);
				html += "<td>" + flt_param.attack + "</td>";
				html_shets += "<td>" + flt_param.armor + "</td>";
			}

			if (flets.flt_302 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(id_user, 302);
				html += "<td>" + flt_param.attack + "</td>";
				html_shets += "<td>" + flt_param.armor + "</td>";
			}
			if (flets.flt_303 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(id_user, 303);
				html += "<td>" + flt_param.attack + "</td>";
				html_shets += "<td>" + flt_param.armor + "</td>";
			}
			if (flets.flt_304 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(id_user, 304);
				html += "<td>" + flt_param.attack + "</td>";
				html_shets += "<td>" + flt_param.armor + "</td>";
			}
			if (flets.flt_305 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(id_user, 305);
				html += "<td>" + flt_param.attack + "</td>";
				html_shets += "<td>" + flt_param.armor + "</td>";
			}
			if (flets.flt_306 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(id_user, 306);
				html += "<td>" + flt_param.attack + "</td>";
				html_shets += "<td>" + flt_param.armor + "</td>";
			}
			if (flets.flt_307 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(id_user, 307);
				html += "<td>" + flt_param.attack + "</td>";
				html_shets += "<td>" + flt_param.armor + "</td>";
			}
			if (flets.flt_308 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(id_user, 308);
				html += "<td>" + flt_param.attack + "</td>";
				html_shets += "<td>" + flt_param.armor + "</td>";
			}
			if (flets.flt_309 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(id_user, 309);
				html += "<td>" + flt_param.attack + "</td>";
				html_shets += "<td>" + flt_param.armor + "</td>";
			}
			if (flets.deff_401 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(id_user, 401);
				html += "<td>" + flt_param.attack + "</td>";
				html_shets += "<td>" + flt_param.armor + "</td>";
			}
			if (flets.deff_402 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(id_user, 402);
				html += "<td>" + flt_param.attack + "</td>";
				html_shets += "<td>" + flt_param.armor + "</td>";
			}
			if (flets.deff_403 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(id_user, 403);
				html += "<td>" + flt_param.attack + "</td>";
				html_shets += "<td>" + flt_param.armor + "</td>";
			}
			if (flets.deff_404 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(id_user, 404);
				html += "<td>" + flt_param.attack + "</td>";
				html_shets += "<td>" + flt_param.armor + "</td>";
			}
			if (flets.deff_405 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(id_user, 405);
				html += "<td>" + flt_param.attack + "</td>";
				html_shets += "<td>" + flt_param.armor + "</td>";
			}
			if (flets.deff_406 > 0)
			{
				flt_param = Flets_param.set_pay_to_FD(id_user, 406);
				html += "<td>" + flt_param.attack + "</td>";
				html_shets += "<td>" + flt_param.armor + "</td>";
			}

			html += "</tr>";
			html_shets += "</tr>";
			return html + html_shets;
		}


		public static Spy_report Inform_user(int id_user)
		{
			Spy_report report = new Spy_report();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "spy_report_SERVER_param";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					report = new Spy_report();
					report.ataked_tech = Convert.ToInt32(reader["ataked_tech"]);
					report.shield_tech = Convert.ToInt32(reader["shield_tech"]);
					report.defence_tech = Convert.ToInt32(reader["defence_tech"]);
					report.shield_planets_tech = Convert.ToInt32(reader["shield_planets_tech"]);
					//ресурсы на планете
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return report;
		}


		public static string table_param_Heder(int id_att, int id_Deff)
		{
			Spy_report att_param = Inform_user(id_att);
			Spy_report deff_param = Inform_user(id_Deff);

			string html = "<div class=\"table - responsive\"><table><tbody>";
			html += "<tbody><tr><td colspan = \"3\" > БОЕВОЙ ОТЧЕТ </td>";

			html += "</tr><tr><td colspan = \"3\"> Характеристики игроков </td></tr>";

			html += "<tr><td ></td><td> Атакущий </td><td> Защищающий </td></tr>";

			html += " <tr><td> Оружейная технология </td>";

			html += "<td>" + att_param.ataked_tech + "%</td>";

			html += "<td>" + deff_param.ataked_tech + "%</td>";

			html += "</tr>";

			html += " <tr><td> Щитовая технология </td>";

			html += "<td>" + att_param.shield_tech + "%</td>";

			html += "<td>" + deff_param.shield_tech + "%</td>";

			html += "</tr>";

			html += " <tr><td> Броня КК </td>";

			html += "<td>" + att_param.defence_tech + "%</td>";

			html += "<td>" + deff_param.defence_tech + "%</td>";

			html += "</tr>";

			html += " <tr><td> Обороная планеты </td>";

			html += "<td>" + att_param.shield_planets_tech + "%</td>";

			html += "<td>" + deff_param.shield_planets_tech + "%</td>";

			html += "</tr>";

			return html += "</tbody></table ></div> ";
		}

		public static int coutn_rows(flets_deff flets)
		{
			int row = 0;
			if (flets.flt_301 > 0)
				row++;
			if (flets.flt_302 > 0)
				row++;
			if (flets.flt_303 > 0)
				row++;
			if (flets.flt_304 > 0)
				row++;
			if (flets.flt_305 > 0)
				row++;
			if (flets.flt_306 > 0)
				row++;
			if (flets.flt_307 > 0)
				row++;
			if (flets.flt_308 > 0)
				row++;
			if (flets.flt_309 > 0)
				row++;
			if (flets.deff_401 > 0)
				row++;
			if (flets.deff_402 > 0)
				row++;
			if (flets.deff_403 > 0)
				row++;
			if (flets.deff_404 > 0)
				row++;
			if (flets.deff_405 > 0)
				row++;
			if (flets.deff_406 > 0)
				row++;

			return row;
		}

	}
}
