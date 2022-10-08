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
	class rating_list
	{
		public int users_id { get; set; }
		public int pozition { get; set; }
		public string names_user { get; set; }
		public int balls { get; set; }
		public static List<rating_list> list(int flag_sort)
		{
			List<rating_list> Result = new List<rating_list>();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				switch (flag_sort)
				{
					case 0:
						cmd.CommandText = "load_rating_SOTR_ALL_Rating";// Название процедуры на сервере
						break;
					case 1:
						cmd.CommandText = "load_rating_SOTR_Fleets";// Название процедуры на сервере
						break;
					case 2:
						cmd.CommandText = "load_rating_SOTR_DEFF";// Название процедуры на сервере
						break;
					case 3:
						cmd.CommandText = "load_rating_SOTR_Prom";// Название процедуры на сервере
						break;
					case 4:
						cmd.CommandText = "load_rating_SOTR_Tech";// Название процедуры на сервере
						break;
				}

				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					rating_list rtg = new rating_list();

					rtg.users_id = Convert.ToInt32(reader["users_id"]);
					rtg.pozition = Convert.ToInt32(reader["position"]);
					rtg.balls = Convert.ToInt32(reader["balls"]);
					rtg.names_user = Convert.ToString(reader["user_n"]);


					Result.Add(rtg);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return Result;
		}

	}
}
