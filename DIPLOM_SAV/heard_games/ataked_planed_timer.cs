using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DIPLOM_SAV.heard_games
{
	public class ataked_planed_timer
	{
		public int ID { get; set; }
		public int fleet_mission { get; set; } // код миссии
		public int amount_fleets { get; set; } //количество флота
		public string array_json_fleets { get; set; }// массив флота
		public string start_GP_array { get; set; }//кординаты планеты(мои кординаты) в форате json
		public string end_GP_array { get; set; } // кординаты планеты(кординаты противника) в форате json
		public string timer_secend_air { get; set; }

		public string string_mission { get; set; } // код миссии


		public static List<ataked_planed_timer> get_list_ataaked(int ID)
		{
			List<ataked_planed_timer> Result = new List<ataked_planed_timer>();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "get_list_ataked_fllets";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", ID));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					ataked_planed_timer att = new ataked_planed_timer();
					att.ID = Convert.ToInt32(reader["id"]);
					switch (Convert.ToInt32(reader["fleet_mission"]))
					{
						case 0:// атаковать
							att.string_mission = "Атаковать";
							break;
						case 1:// шпионаж
							att.string_mission = "Шпионаж";
							break;
						case 2:// возвращение
							att.string_mission = "Возвращение";
							break;
					}
					att.amount_fleets = Convert.ToInt32(reader["amount_fleets"]);
					att.array_json_fleets = Convert.ToString(reader["array_json_fleets"]);
					att.start_GP_array = Convert.ToString(reader["start_GP_array"]);
					att.end_GP_array = Convert.ToString(reader["end_GP_array"]);
					att.timer_secend_air = timer_Convet_Minuts(Convert.ToInt32(reader["sec"]));
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

		public static List<ataked_planed_timer> List_Vrag_ataaked(int ID)
		{
			List<ataked_planed_timer> Result = new List<ataked_planed_timer>();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "list_Vrag_Attaked";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", ID));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					ataked_planed_timer att = new ataked_planed_timer();
					att.ID = Convert.ToInt32(reader["id"]);
					switch (Convert.ToInt32(reader["fleet_mission"]))
					{
						case 0:// атаковать
							att.string_mission = "Атаковать";
							break;
						case 1:// шпионаж
							att.string_mission = "Шпионаж";
							break;
					}
					att.amount_fleets = Convert.ToInt32(reader["amount_fleets"]);
					att.array_json_fleets = Convert.ToString(reader["array_json_fleets"]);
					att.start_GP_array = Convert.ToString(reader["start_GP_array"]);
					att.end_GP_array = Convert.ToString(reader["end_GP_array"]);
					att.timer_secend_air = timer_Convet_Minuts(Convert.ToInt32(reader["sec"]));
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
		public static bool atted_planets(int id_my, int id_vrag, string fls_fson, int counts_fls, int times, string my_coors, string vrag_coors, long max_trum, long cost_fley, fleets_deff FD)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "attaked_panets";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_my));
				cmd.Parameters.Add(new SqlParameter("@json_fleets", fls_fson));
				cmd.Parameters.Add(new SqlParameter("@amount_fleets", counts_fls));
				cmd.Parameters.Add(new SqlParameter("@max_tums", max_trum));
				cmd.Parameters.Add(new SqlParameter("@id_vars", id_vrag));
				cmd.Parameters.Add(new SqlParameter("@sec_timer", times));
				cmd.Parameters.Add(new SqlParameter("@coor_My", my_coors));
				cmd.Parameters.Add(new SqlParameter("@coor_Vrag", vrag_coors));
				int count = cmd.ExecuteNonQuery();
				if (count > 0)
				{
					conn.Close();
					conn.Open();
					cmd = new SqlCommand();
					cmd.Connection = conn;
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "cost_fly";// Название процедуры на сервере
					cmd.Parameters.Add(new SqlParameter("@id_user", id_my));
					cmd.Parameters.Add(new SqlParameter("@res_detrium", cost_fley));
					count = cmd.ExecuteNonQuery();
					if (count > 0)
					{
						conn.Close();
						conn.Open();
						cmd = new SqlCommand();
						cmd.Connection = conn;
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.CommandText = "atakets_up_tables";// Название процедуры на сервере
						cmd.Parameters.Add(new SqlParameter("@id_user", id_my));
						cmd.Parameters.Add(new SqlParameter("@flt_301", FD.flt_301));
						cmd.Parameters.Add(new SqlParameter("@flt_302", FD.flt_302));
						cmd.Parameters.Add(new SqlParameter("@flt_303", FD.flt_303));
						cmd.Parameters.Add(new SqlParameter("@flt_304", FD.flt_304));
						cmd.Parameters.Add(new SqlParameter("@flt_305", FD.flt_305));
						cmd.Parameters.Add(new SqlParameter("@flt_306", FD.flt_306));
						cmd.Parameters.Add(new SqlParameter("@flt_308", FD.flt_308));
						cmd.Parameters.Add(new SqlParameter("@flt_309", FD.flt_309));
						count = cmd.ExecuteNonQuery();
						if (count > 0)
						{
							return true;
						}
					}
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
		public static bool spys_planets(int id_my, int id_vrag, string fls_fson, int counts_fls, string my_coors, string vrag_coors, int cost_fley)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "scyps_panets";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_my));
				cmd.Parameters.Add(new SqlParameter("@json_fleets", fls_fson));
				cmd.Parameters.Add(new SqlParameter("@amount_fleets", counts_fls));
				cmd.Parameters.Add(new SqlParameter("@id_vars", id_vrag));
				cmd.Parameters.Add(new SqlParameter("@coor_My", my_coors));
				cmd.Parameters.Add(new SqlParameter("@coor_Vrag", vrag_coors));
				int count = cmd.ExecuteNonQuery();
				if (count > 0)
				{
					conn.Close();
					conn.Open();
					cmd = new SqlCommand();
					cmd.Connection = conn;
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "cost_fly";// Название процедуры на сервере
					cmd.Parameters.Add(new SqlParameter("@id_user", id_my));
					cmd.Parameters.Add(new SqlParameter("@res_detrium", cost_fley));
					count = cmd.ExecuteNonQuery();
					if (count > 0)
					{
						conn.Close();
						conn.Open();
						cmd = new SqlCommand();
						cmd.Connection = conn;
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.CommandText = "scyps_up_tables";// Название процедуры на сервере
						cmd.Parameters.Add(new SqlParameter("@id_user", id_my));
						cmd.Parameters.Add(new SqlParameter("@counts_305", cost_fley));
						count = cmd.ExecuteNonQuery();
						if (count > 0)
						{
							return true;
						}
					}
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
		public static bool cansel_attaked(int id_, int id_owner)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "cansel_fleets_mission";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_owner));
				cmd.Parameters.Add(new SqlParameter("@ID", id_));
				int count = cmd.ExecuteNonQuery();
				if (count > 0)
				{
					return true;
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return false;
		}
		public static string timer_Convet_Minuts(int sec)
		{
			int minutes = sec / 60;
			int newSec = sec - minutes * 60;
			int hour = minutes / 60;
			int newMinnutes = minutes - hour * 60;
			TimeSpan time = new TimeSpan(hour, newMinnutes, newSec);
			return time.ToString();
		}
	}
}
