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
	public class galactikCoor : coorditates
	{
		public int id_user { get; set; }
		public string names_planets { get; set; }
		public int p_imege { get; set; }

		public static List<galactikCoor> list_galactik(int galaxy)
		{
			List<galactikCoor> L = new List<galactikCoor>();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "set_info_galactik";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@galaxy", galaxy));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					galactikCoor glc = new galactikCoor();
					glc.id_user = Convert.ToInt32(reader["id_owner"]);
					glc.names_planets = Convert.ToString(reader["names_planets"]);
					glc.G = Convert.ToInt32(reader["galaxy"]);
					glc.P = Convert.ToInt32(reader["planet"]);
					glc.p_imege = Convert.ToInt32(reader["p_imege"]);
					L.Add(glc);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return L;
		}
		public static galactikCoor items_galactik_for_ID_user(int id_user)
		{
			galactikCoor glc = new galactikCoor();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "select_Galactik_for_ID_user";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					glc.id_user = Convert.ToInt32(reader["id_owner"]);
					glc.names_planets = Convert.ToString(reader["names_planets"]);
					glc.G = Convert.ToInt32(reader["galaxy"]);
					glc.P = Convert.ToInt32(reader["planet"]);
					glc.p_imege = Convert.ToInt32(reader["p_imege"]);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return glc;
		}

	}
}
