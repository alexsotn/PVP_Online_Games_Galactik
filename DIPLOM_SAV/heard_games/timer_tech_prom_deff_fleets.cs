using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//класс для управление задачи постоеки или наему обороны или флота
namespace DIPLOM_SAV.heard_games
{
	public class timer_tech_prom_deff_fleets
	{
		public int id_planets { get; set; }
		public string names { get; set; }
		public int code_bld_tech_FD { get; set; }
		public int quantity { get; set; } // количество
		public int time_left { get; set; }// осталось времени в секундах
		public string times_str { get; set; }// осталось времени в секундах

		public static List<timer_tech_prom_deff_fleets> bld_tech_fleets_deff_view_t(int ID_user)//получаю время построек и исследваний
		{
			// 1эл - простройки, 2-технологии, 3-флот, 4 -оборона
			List<timer_tech_prom_deff_fleets> Result = new List<timer_tech_prom_deff_fleets>();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "set_timet_blb_tech";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", ID_user));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					timer_tech_prom_deff_fleets t = new timer_tech_prom_deff_fleets();
					t.id_planets = Convert.ToInt32(reader["id_planets"]);
					t.code_bld_tech_FD = Convert.ToInt32(reader["code_bld_tech"]);
					t.time_left = Convert.ToInt32(reader["sec"]);
					Result.Add(t);
				}
				conn.Close();
				conn.Open();
				cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "set_timet_flets";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", ID_user));
				SqlDataReader reader_F = cmd.ExecuteReader();
				while (reader_F.Read())
				{
					timer_tech_prom_deff_fleets t = new timer_tech_prom_deff_fleets();
					t.id_planets = Convert.ToInt32(reader_F["id_planets"]);
					t.code_bld_tech_FD = Convert.ToInt32(reader_F["code_fleets"]);
					t.time_left = Convert.ToInt32(reader_F["sum_sec"]);
					Result.Add(t);
				}
				conn.Close();
				conn.Open();
				cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "set_timet_deff";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", ID_user));
				SqlDataReader reader_D = cmd.ExecuteReader();
				while (reader_D.Read())
				{
					timer_tech_prom_deff_fleets t = new timer_tech_prom_deff_fleets();
					t.id_planets = Convert.ToInt32(reader_D["id_planets"]);
					t.code_bld_tech_FD = Convert.ToInt32(reader_D["code_deff"]);
					t.time_left = Convert.ToInt32(reader_D["sum_sec"]);
					Result.Add(t);
				}
				conn.Close();

			}
			catch
			{
				conn.Close();
			}
			return Result;
		}
		public static timer_tech_prom_deff_fleets timers_bld_and_proms(int ID_user, int flaf_code)//получаю время флота и обороны
		{
			timer_tech_prom_deff_fleets Result = null;
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "set_timet_blb_tech";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", ID_user));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					if (100 < Convert.ToInt32(reader["code_bld_tech"]) && Convert.ToInt32(reader["code_bld_tech"]) < 200 && flaf_code == 100)
					{
						Result = new timer_tech_prom_deff_fleets();
						Result.id_planets = Convert.ToInt32(reader["id_planets"]);
						Result.names = Convert.ToString(reader["names"]);
						Result.code_bld_tech_FD = Convert.ToInt32(reader["code_bld_tech"]);
						Result.times_str = timer_Convet_Minuts(Convert.ToInt32(reader["sec"]));
					}
					if (200 < Convert.ToInt32(reader["code_bld_tech"]) && Convert.ToInt32(reader["code_bld_tech"]) < 300 && flaf_code == 200)
					{
						Result = new timer_tech_prom_deff_fleets();
						Result.id_planets = Convert.ToInt32(reader["id_planets"]);
						Result.names = Convert.ToString(reader["names"]);
						Result.code_bld_tech_FD = Convert.ToInt32(reader["code_bld_tech"]);
						Result.times_str = timer_Convet_Minuts(Convert.ToInt32(reader["sec"]));
					}
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return Result;
		}
		//нанять или улучшить 
		public static bool bld_tech_Up_level(int id_user, int code_BT, long t)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "timer_bld_tech_Update";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
				cmd.Parameters.Add(new SqlParameter("@codes_Up", code_BT));
				cmd.Parameters.Add(new SqlParameter("@times_sec", t));
				int count = cmd.ExecuteNonQuery();
				if (count > 0)
				{
					conn.Close();
					return true;
				}
				conn.Close();
			}
			catch 
			{
				conn.Close();
				return false;
			}
			return false;
		}
		public static bool hire_fllet_deff(int id_user, int code_FD, int t, int kolich)
		{
			bool result = false;
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				while (kolich > 0)
				{
					if (kolich >= 5)
					{
						conn.Open();
						SqlCommand cmd = new SqlCommand();
						cmd.Connection = conn;
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.CommandText = "timer_flets_deff";// Название процедуры на сервере
						cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
						cmd.Parameters.Add(new SqlParameter("@codes_Up", code_FD));
						cmd.Parameters.Add(new SqlParameter("@kolich", 5));
						cmd.Parameters.Add(new SqlParameter("@times_sec", Convert.ToInt32(t * 5)));
						int count = cmd.ExecuteNonQuery();
						if (count > 0)
						{
							conn.Close();
							result =  true;
						}
						conn.Close();
						kolich = kolich - 5;
					}
					else
					{
						conn.Open();
						SqlCommand cmd = new SqlCommand();
						cmd.Connection = conn;
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.CommandText = "timer_flets_deff";// Название процедуры на сервере
						cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
						cmd.Parameters.Add(new SqlParameter("@codes_Up", code_FD));
						cmd.Parameters.Add(new SqlParameter("@kolich", kolich));
						cmd.Parameters.Add(new SqlParameter("@times_sec", Convert.ToInt32(t * kolich)));
						int count = cmd.ExecuteNonQuery();
						if (count > 0)
						{
							conn.Close();
							return true;
						}
						conn.Close();
					}


				}
				
			}
			catch 
			{
				conn.Close();
				return false;
			}
			return result;
		}
		public static bool bld_tech_Cansel(int id_planets, int codes)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "timer_bld_tech_Cansel";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_planets", id_planets));
				cmd.Parameters.Add(new SqlParameter("@code_bld_tech", codes));
				int count = cmd.ExecuteNonQuery();
				if (count > 0)
				{
					conn.Close();
					return true;
				}
				conn.Close();
			}
			catch 
			{
				conn.Close();
				return false;
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
