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
	public class fleets_deff 
	{
		public int flt_301 { get; set; } //транспортник
		public int flt_302 { get; set; } //истрибитель
		public int flt_303 { get; set; } // крейсер
		public int flt_304 { get; set; } //линкор
		public int flt_305 { get; set; } //шпонский зонд
		public int flt_306 { get; set; } //бомбордировщик
		public int flt_307 { get; set; } //солнечный спутник
		public int flt_308 { get; set; } //уничтожитель
		public int flt_309 { get; set; } //звезда смерти
		public int deff_401 { get; set; } // ректная установка
		public int deff_402 { get; set; } // лезерная установка
		public int deff_403 { get; set; } // пушка гуауса
		public int deff_404 { get; set; } // ионное орудие
		public int deff_405 { get; set; } // плазменная пушка
		public int deff_406 { get; set; }  // щитовой купол

		public static fleets_deff get_fleets_deff(int owner) {
			fleets_deff FD = new fleets_deff();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "load_fleets_and_deff";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", owner));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					FD.flt_301 = Convert.ToInt32(reader["flt_301"]);
					FD.flt_302 = Convert.ToInt32(reader["flt_302"]);
					FD.flt_303 = Convert.ToInt32(reader["flt_303"]);
					FD.flt_304 = Convert.ToInt32(reader["flt_304"]);
					FD.flt_305 = Convert.ToInt32(reader["flt_305"]);
					FD.flt_306 = Convert.ToInt32(reader["flt_306"]);
					FD.flt_307 = Convert.ToInt32(reader["flt_307"]);
					FD.flt_308 = Convert.ToInt32(reader["flt_308"]);
					FD.flt_309 = Convert.ToInt32(reader["flt_309"]);
					FD.deff_401 = Convert.ToInt32(reader["deff_401"]);
					FD.deff_402 = Convert.ToInt32(reader["deff_402"]);
					FD.deff_403 = Convert.ToInt32(reader["deff_403"]);
					FD.deff_404 = Convert.ToInt32(reader["deff_404"]);
					FD.deff_405 = Convert.ToInt32(reader["deff_405"]);
					FD.deff_406 = Convert.ToInt32(reader["deff_406"]);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return FD;
		}
	
	}
}
