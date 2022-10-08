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
	class resurs_planets
	{
		public int res_metal { get; set; } // метал
		public int capacity_metal { get; set; } //вместимость метала
		public int production_metal { get; set; } //выроботка в час М
		public int res_kristal { get; set; } // кристал
		public int capacity_kristal { get; set; } //вместимость кристал
		public int production_kristal { get; set; } //выроботка в час К
		public int res_deuterium { get; set; } // дейтерий
		public int capacity_deuterium { get; set; } //вместимость дейтерий
		public int production_deuterium { get; set; } //выроботка в час Д
		public int res_energy { get; set; } // энергия
		public int capacity_energy { get; set; } //вместимость энергия

		public static resurs_planets load_res(int id_owner)
		{
			resurs_planets Result = new resurs_planets();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add(new SqlParameter("@ID_users", id_owner));
				cmd.CommandText = "load_resurs";// Название процедуры на сервере
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					Result.res_metal = Convert.ToInt32(reader["res_metal"]);
					Result.res_kristal = Convert.ToInt32(reader["res_kristal"]);
					Result.res_deuterium = Convert.ToInt32(reader["res_deuterium"]);
					Result.res_energy = Convert.ToInt32(reader["res_energy"]);
					Result.capacity_metal = Convert.ToInt32(reader["capacity_metal"]);
					Result.capacity_kristal = Convert.ToInt32(reader["capacity_kristal"]);
					Result.capacity_deuterium = Convert.ToInt32(reader["capacity_deuterium"]);
					Result.capacity_energy = Convert.ToInt32(reader["capacity_energy"]);
					Result.production_metal = Convert.ToInt32(reader["production_metal"]);
					Result.production_kristal = Convert.ToInt32(reader["production_kristal"]);
					Result.production_deuterium = Convert.ToInt32(reader["production_deuterium"]);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}

			return Result;
		}
		public static bool to_pay(int id_owner, long res_m, long res_k, long res_d)
		{
			//запрос на списание ресурсов со счета
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "debiting_res";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_owner));
				cmd.Parameters.Add(new SqlParameter("@res_metal", res_m));
				cmd.Parameters.Add(new SqlParameter("@res_kristal", res_k));
				cmd.Parameters.Add(new SqlParameter("@res_detrium", res_d));
				int count = cmd.ExecuteNonQuery();
				conn.Close();
				if (count > 0)
				{
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
	}
}
