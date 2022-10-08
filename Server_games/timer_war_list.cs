using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_games
{
	public class timer_war_list
	{
		public long timer_secend_air { get; set; }
		public int ID { get; set; }
		public int fleet_mission { get; set; } // код миссии
		public int ID_fleet_owner { get; set; } //  
		public int ID_target_owner { get; set; } //  
		public string array_json_fleets { get; set; }// массив флота
		public static List<timer_war_list> get_list_ataaked()
		{
			List<timer_war_list> Result = new List<timer_war_list>();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "SERVER_list_attaked";// Название процедуры на сервере
				SqlDataReader reader = cmd.ExecuteReader();
				//conn.Close();
				while (reader.Read())
				{
					timer_war_list att = new timer_war_list();
					att.ID = Convert.ToInt32(reader["id"]);
					att.fleet_mission = Convert.ToInt32(reader["fleet_mission"]);
					att.array_json_fleets = Convert.ToString(reader["array_json_fleets"]);
					att.timer_secend_air = Convert.ToInt64(reader["sec"]);
					att.ID_fleet_owner = Convert.ToInt32(reader["id_fleet_owner"]);
					att.ID_target_owner = Convert.ToInt32(reader["target_owner"]);

					long  res_m = Convert.ToInt64(reader["res_metal"]);
					long  res_k = Convert.ToInt64(reader["res_kristal"]);
					long  res_d = Convert.ToInt64(reader["res_deuterium"]);
					if (att.timer_secend_air < 0)
					{
						switch (att.fleet_mission)
						{
							case 0:// Атака
								user_war_log_attaked log = user_war_log_attaked.load_data_user(att.ID, att.ID_fleet_owner, att.ID_target_owner, att.array_json_fleets);
								Battle Report = Battle.Battels(log);
								Battle.Attek_report(att.ID, Report, att.ID_fleet_owner, att.ID_target_owner);
								if (Report.Win == 1)
									Up_Lv_War(att.ID_fleet_owner);
								else
									Up_Lv_War(att.ID_target_owner);
								break;
							case 1:// шпионаж
								Spy_report.Write_report(att.ID, Spy_report.Spy_planets(att.ID_target_owner), att.ID_fleet_owner, att.ID_target_owner);
								break;
							case 2:// Возвтат флота
								flets_deff df = JsonConvert.DeserializeObject<flets_deff>(att.array_json_fleets);
								Spy_report.Up_return_fleets_inPlanets(df, att.ID_fleet_owner, att.ID, res_m, res_k, res_d);
								break;
						}

						//Battels(log);
					}
					else
						Result.Add(att);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return Result;
		}
		public static bool Up_Lv_War(int id_user)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "SELECT_Prom_War_Exp_SERVER";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_p", id_user));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{

					int tek_lv = Convert.ToInt32(reader["war_lv"]);
					int Next_Epx_Up_LV = Convert.ToInt32(200 * Math.Pow(2, tek_lv) / 2);
					int tex_Exp = Convert.ToInt32(reader["exp_var"]);
					if (tek_lv != 22)
					{
						while (Next_Epx_Up_LV < tex_Exp)
						{
							if (tek_lv != 22)
							{
								Up_Lv_war(id_user, Next_Epx_Up_LV);
								tex_Exp = tex_Exp - Next_Epx_Up_LV;
								Next_Epx_Up_LV = Convert.ToInt32(100 * Math.Pow(2, (tek_lv + 1)) / 4);
							}
						}
					}
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}

			return false;
		}

		public static bool Up_Lv_war(int id_user, int Exp_minus)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "Update_Level_Var";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
				cmd.Parameters.Add(new SqlParameter("@Exp_Minus_new_Lv", Exp_minus));
				if (cmd.ExecuteNonQuery() > 0)
					return true;
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return false;
		}
	}
}
