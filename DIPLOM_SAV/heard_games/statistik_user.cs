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
	public class statistik_user
	{
		public int users_id { get; set; }
		public int all_rating { get; set; }
		public int fleets_rating { get; set; }
		public int deff_rating { get; set; }
		public int prom_rating { get; set; }
		public int tech_rating { get; set; }
		public string names_user { get; set; }

		

		public static statistik_user get_data_evolution(int ID)
		{
			statistik_user rtg = new statistik_user();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "get_data_evolution";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", ID));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					rtg.all_rating = Convert.ToInt32(reader["all_rating"]);
					rtg.fleets_rating = Convert.ToInt32(reader["fleets_rating"]);
					rtg.deff_rating = Convert.ToInt32(reader["deff_rating"]);
					rtg.prom_rating = Convert.ToInt32(reader["prom_rating"]);
					rtg.tech_rating = Convert.ToInt32(reader["tech_rating"]);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return rtg;
		}
	}
}
