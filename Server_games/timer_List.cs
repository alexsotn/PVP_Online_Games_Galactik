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
	public class timer_List
	{
		public long time_left { get; set; }// осталось времени в секундах
		public int id { get; set; }
		public int id_planets { get; set; }
		public int code_bld_tech_FD { get; set; }
		public int quantity { get; set; } // количество


		public static List<timer_List> Timers_bld_and_proms()
		{
			List<timer_List> Result = new List<timer_List>();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "SERVER_list_Prom_Tech";// Название процедуры на сервере
				SqlDataReader reader = cmd.ExecuteReader();
			//	conn.Close();
				while (reader.Read())
				{
					timer_List list = new timer_List();
					list.id = Convert.ToInt32(reader["id"]);
					list.id_planets = Convert.ToInt32(reader["id_planets"]);
					list.code_bld_tech_FD = Convert.ToInt32(reader["code_bld_tech"]);
					list.time_left = Convert.ToInt64(reader["sec"]);
					if (list.time_left < 2)
					{
						Up_lv(list.id_planets, list.code_bld_tech_FD);
						Up_Lv_Prom(list.id_planets);
					}
					else
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
		public static List<timer_List> timers_fleets()
		{
			List<timer_List> Result = new List<timer_List>();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "SERVER_list_Fleets_Hire_T";// Название процедуры на сервере
				SqlDataReader reader = cmd.ExecuteReader();
			//	conn.Close();
				while (reader.Read())
				{
					timer_List list = new timer_List();
					list.id = Convert.ToInt32(reader["id"]);
					list.id_planets = Convert.ToInt32(reader["id_planets"]);
					list.code_bld_tech_FD = Convert.ToInt32(reader["code_fleets"]);
					list.quantity = Convert.ToInt32(reader["quantity"]);
					list.time_left = Convert.ToInt64(reader["sec"]);
					if (list.time_left < 2)
						Up_fleets_and_deff(list);
					else
						Result.Add(list);
				}
				conn.Close();
			}
			catch (Exception e)
			{
				//MessageBox.Show(e.Message.ToString());
				conn.Close();
			}
			return Result;
		}
		public static List<timer_List> timers_deff()
		{
			List<timer_List> Result = new List<timer_List>();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "SERVER_list_DEFF_Hire_T";// Название процедуры на сервере
				SqlDataReader reader = cmd.ExecuteReader();
				//conn.Close();
				while (reader.Read())
				{
					timer_List list = new timer_List();
					list.id = Convert.ToInt32(reader["id"]);
					list.id_planets = Convert.ToInt32(reader["id_planets"]);
					list.code_bld_tech_FD = Convert.ToInt32(reader["code_deff"]);
					list.quantity = Convert.ToInt32(reader["quantity"]);
					list.time_left = Convert.ToInt64(reader["sec"]);
					if (list.time_left < 2)
						Up_fleets_and_deff(list);
					else
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

		public static bool Up_lv(int id_planets, int flaf_code)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "techolog_and_prom_Up_lv_SEVERE";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@codes_Prom_tech", flaf_code));
				cmd.Parameters.Add(new SqlParameter("@id_planets", id_planets));
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
		public static bool Up_fleets_and_deff(timer_List pram)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "SERVER_HIRE_Fleets_and_deff";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_planets", pram.id_planets));
				cmd.Parameters.Add(new SqlParameter("@code_DF", pram.code_bld_tech_FD));
				cmd.Parameters.Add(new SqlParameter("@colih", pram.quantity));
				cmd.Parameters.Add(new SqlParameter("@id_rows", pram.id));
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


		public static bool Up_Lv_Prom(int id_p)
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
				cmd.Parameters.Add(new SqlParameter("@id_p", id_p));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{

					int tek_lv = Convert.ToInt32(reader["prom_lv"]);
					int Next_Epx_Up_LV = Convert.ToInt32(100 * Math.Pow(2, tek_lv) / 4);
					int tex_Exp = Convert.ToInt32(reader["exp_prom"]);

					if (tek_lv != 22)
					{
						while (Next_Epx_Up_LV < tex_Exp)
						{
							if (tek_lv != 22)
							{
								Up_Lv_Prom(id_p, Next_Epx_Up_LV);
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
		public static bool Up_Lv_Prom(int id_p, int Exp_minus)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "Update_Level_Prom";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_p", id_p));
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
