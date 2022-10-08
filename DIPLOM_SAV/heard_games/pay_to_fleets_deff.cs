using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM_SAV.heard_games
{
	class pay_to_fleets_deff
	{
		public int code_fleets_deff { get; set; }// флота или обороны
		public int res_m { get; set; }
		public int res_k { get; set; }
		public int res_d { get; set; }
		public int time_fleets { get; set; } // время на постройку флота или обороны в секундах
		public string time_str { get; set; } // время на постройку флота или обороны в секундах
		public int attack { get; set; }//атака
		public int shields { get; set; }//щиты
		public int armor { get; set; }//броня
		public int hold { get; set; }// трюм
		public int speed { get; set; }// скорость полета
		public int consumption_ditriy { get; set; } // поребление топлива

		public static pay_to_fleets_deff set_pay_to_FD(int id_user, int code_FD)
		{
			pay_to_fleets_deff list = new pay_to_fleets_deff();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "flesets_param_items";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
				cmd.Parameters.Add(new SqlParameter("@codes", code_FD));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					list.code_fleets_deff = Convert.ToInt32(reader["code_fleets_deff"]);
					list.res_m = Convert.ToInt32(reader["res_m"]);
					list.res_k = Convert.ToInt32(reader["res_k"]);
					list.res_d = Convert.ToInt32(reader["res_d"]);
					list.time_fleets = Convert.ToInt32(reader["time_fleets"]);
					list.time_str = timer_Convet_Minuts(Convert.ToInt32(reader["time_fleets"]));
					list.attack = Convert.ToInt32(reader["attack"]);
					list.shields = Convert.ToInt32(reader["shields"]);
					list.armor = Convert.ToInt32(reader["armor"]);
					list.hold = Convert.ToInt32(reader["hold"]);
					list.speed = Convert.ToInt32(reader["speed"]);
					list.consumption_ditriy = Convert.ToInt32(reader["consumption_ditriy"]);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return list;
		}
		public static List<pay_to_fleets_deff> list_flets_param(int ID)
		{
			List<pay_to_fleets_deff> Result = new List<pay_to_fleets_deff>();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "list_flesets_param";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", ID));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					pay_to_fleets_deff list = new pay_to_fleets_deff();
					list.code_fleets_deff = Convert.ToInt32(reader["code_fleets_deff"]);
					list.hold = Convert.ToInt32(reader["hold"]);
					list.speed = Convert.ToInt32(reader["speeds"]);
					list.consumption_ditriy = Convert.ToInt32(reader["consumption_ditriy"]);
					Result.Add(list);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return Result;
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
