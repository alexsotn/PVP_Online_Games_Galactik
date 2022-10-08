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
	public class requirement_trb
	{
		public string name_trb { get; set; }
		public int trb_level { get; set; }
		public int have_leval { get; set; }
		public bool chek { get; set; }

		public static List<requirement_trb> get_requirement_trb(int id_user, int codes, int flags_trb)
		{
			List<requirement_trb> r_trb = new List<requirement_trb>();
			SqlConnection conn = new SqlConnection();
			switch (flags_trb)
			{
				case 100200:
					conn = new SqlConnection();
					conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
					try
					{
						conn.Open();
						SqlCommand cmd = new SqlCommand();
						cmd.Connection = conn;
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.CommandText = "load_trb_Prom_and_Tech";// Название процедуры на сервере
						cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
						cmd.Parameters.Add(new SqlParameter("@codes_FD", codes));
						SqlDataReader reader = cmd.ExecuteReader();
						while (reader.Read())
						{
							requirement_trb Trb = new requirement_trb();
							Trb.name_trb = Convert.ToString(reader["names_trb"]);
							Trb.trb_level = Convert.ToInt32(reader["trb_level"]);
							Trb.have_leval = Convert.ToInt32(reader["have_lv"]);
							if (Trb.trb_level <= Trb.have_leval)
								Trb.chek = true;
							else
								Trb.chek = false;
							r_trb.Add(Trb);
						}
						conn.Close();
					}
					catch
					{
						conn.Close();
					}
					break;
				case 300400:
					conn = new SqlConnection();
					conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
					try
					{
						conn.Open();
						SqlCommand cmd = new SqlCommand();
						cmd.Connection = conn;
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.CommandText = "load_trb_fleets_and_deff";// Название процедуры на сервере
						cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
						cmd.Parameters.Add(new SqlParameter("@codes_FD", codes));
						SqlDataReader reader = cmd.ExecuteReader();
						while (reader.Read())
						{
							requirement_trb Trb = new requirement_trb();
							Trb.name_trb = Convert.ToString(reader["names_trb"]);
							Trb.trb_level = Convert.ToInt32(reader["trb_level"]);
							Trb.have_leval = Convert.ToInt32(reader["have_lv"]);
							if (Trb.trb_level <= Trb.have_leval)
								Trb.chek = true;
							else
								Trb.chek = false;
							r_trb.Add(Trb);
						}
						conn.Close();
					}
					catch
					{
						conn.Close();
					}
					break;
			}
			return r_trb;
		}
	}
}
