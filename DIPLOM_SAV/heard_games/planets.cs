using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIPLOM_SAV.heard_games
{
	public class planets : galactikCoor
	{
		public int id { get; set; }
		public int id_owner { get; set; }
		public int p_diameter { get; set; }
		public int p_temperatura { get; set; }
		public int p_max_size { get; set; }//максимальный размер палены
		public int p_busyness { get; set; }//занятые клетки планеты
		public int bld_mine_metal { get; set; }//рудник метала
		public int bld_mine_kristal { get; set; }// руд кристал
		public int bld_mine_deuterium { get; set; }// руд дейтерий
		public int bld_warehouse_metal { get; set; }//скалад метала
		public int bld_warehouse_kristal { get; set; }//скалад кристала
		public int bld_warehouse_deuterium { get; set; }//скалад дейта
		public int bld_solar_plant { get; set; }//солнечная стнация
		public int bld_robot_factory { get; set; }//фабрика роботов
		public int bld_nano_factory { get; set; }//нано фабрика
		public int bld_laboratory { get; set; }//лаборатория
		public int bld_shipyard { get; set; }//верфь
		public int bld_terraformer { get; set; }// терраформатор
		

		public static planets get_planets_info(int id_user)
		{
			planets pln = new planets();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "get_planets_info";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					pln.names_planets = Convert.ToString(reader["names_planets"]);
					pln.G = Convert.ToInt32(reader["galaxy"]);
					pln.P = Convert.ToInt32(reader["planet"]);
					pln.p_imege = Convert.ToInt32(reader["p_imege"]);
					pln.p_diameter = Convert.ToInt32(reader["p_diameter"]);
					pln.p_temperatura = Convert.ToInt32(reader["p_temperatura"]);
					pln.p_max_size = Convert.ToInt32(reader["p_max_size"]);
					pln.p_busyness = Convert.ToInt32(reader["p_busyness"]);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return pln;
		}

		public static planets set_planets_info_from_Arens(int id_user)
		{
			planets pln = new planets();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "load_planets";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					pln.bld_mine_metal = Convert.ToInt32(reader["bld_mine_metal"]);
					pln.bld_mine_kristal = Convert.ToInt32(reader["bld_mine_kristal"]);
					pln.bld_mine_deuterium = Convert.ToInt32(reader["bld_mine_deuterium"]);
					pln.bld_warehouse_metal = Convert.ToInt32(reader["bld_warehouse_metal"]);
					pln.bld_warehouse_kristal = Convert.ToInt32(reader["bld_warehouse_kristal"]);
					pln.bld_warehouse_deuterium = Convert.ToInt32(reader["bld_warehouse_deuterium"]);
					pln.bld_solar_plant = Convert.ToInt32(reader["bld_solar_plant"]);
					pln.bld_robot_factory = Convert.ToInt32(reader["bld_robot_factory"]);
					pln.bld_nano_factory = Convert.ToInt32(reader["bld_nano_factory"]);
					pln.bld_laboratory = Convert.ToInt32(reader["bld_laboratory"]);
					pln.bld_shipyard = Convert.ToInt32(reader["bld_shipyard"]);
					pln.bld_terraformer = Convert.ToInt32(reader["bld_terraformer"]);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return pln;
		}

		public static bool upLoad_planets_blds(int id_user,string new_name_p, int new_scins_p)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;

				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "UpDate_planets";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
				cmd.Parameters.Add(new SqlParameter("@imegs", new_scins_p));
				cmd.Parameters.Add(new SqlParameter("@names_p", new_name_p));
				if (cmd.ExecuteNonQuery() > 0)
				{
					conn.Close();
					return true;
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Ошибка: " + e.Message);
				conn.Close();
			}
			return false;
		}

		
	}
}
