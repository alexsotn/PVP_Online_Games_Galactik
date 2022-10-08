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
	public class game_messages
	{
		public int id { get; set; }
		public int message_owner { get; set; } //id отпавитель
		public int message_sender { get; set; }// id получатель
		public string message_time { get; set; } //время отправки
		public string message_from { get; set; }// пользователь кординаты
		public string message_text { get; set; }
		public int del_owner { get; set; }// 0 сущ. 1 удалено
		public int del_sender { get; set; }// 0 сущ. 1 удалено
										   // доп поле
		public string names_user { get; set; } //стркоое именя пользователя 
		public string names_user2 { get; set; } //стркоое именя пользователя 

		public static List<game_messages> List_sms(int id_owner, int flags)
		{
			// лист всех сообщений в бд
			List<game_messages> r = new List<game_messages>();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			SqlCommand cmd; SqlDataReader reader;
			try
			{
				switch (flags)
				{
					case 0:
						conn.Open();
						cmd = new SqlCommand();
						cmd.Connection = conn;
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.CommandText = "inbox_sms_user";// Название процедуры на сервере
						cmd.Parameters.Add(new SqlParameter("@id_user", id_owner));
						reader = cmd.ExecuteReader();
						while (reader.Read())
						{
							game_messages sms = new game_messages();
							sms.id = Convert.ToInt32(reader["id"]);
							sms.message_owner = Convert.ToInt32(reader["message_owner"]);
							sms.message_sender = Convert.ToInt32(reader["message_sender"]);
							sms.message_time = Convert.ToString(reader["message_time"]);
							sms.message_from = Convert.ToString(reader["message_from"]);
							sms.message_text = Convert.ToString(reader["message_text"]);
							sms.del_owner = Convert.ToInt32(reader["del_owner"]);
							sms.del_owner = Convert.ToInt32(reader["del_sender"]);
							sms.names_user = Convert.ToString(reader["names_user"]);
							r.Add(sms);
						}
						conn.Close();
						break;
					case 1:
						conn.Open();
						cmd = new SqlCommand();
						cmd.Connection = conn;
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.CommandText = "sent_sms_user";// Название процедуры на сервере
						cmd.Parameters.Add(new SqlParameter("@id_user", id_owner));
						reader = cmd.ExecuteReader();
						while (reader.Read())
						{
							game_messages sms = new game_messages();
							sms.id = Convert.ToInt32(reader["id"]);
							sms.message_owner = Convert.ToInt32(reader["message_owner"]);
							sms.message_sender = Convert.ToInt32(reader["message_sender"]);
							sms.message_time = Convert.ToString(reader["message_time"]);
							sms.message_from = Convert.ToString(reader["message_from"]);
							sms.message_text = Convert.ToString(reader["message_text"]);
							sms.del_owner = Convert.ToInt32(reader["del_owner"]);
							sms.del_owner = Convert.ToInt32(reader["del_sender"]);
							sms.names_user = Convert.ToString(reader["names_user"]);
							r.Add(sms);

						}
						conn.Close();
						break;
				}

			}
			catch
			{
				conn.Close();
			}
			return r;
		}
		public static game_messages item_sms(int id_sms)
		{
			// отркрыть одно сообщение 
			game_messages sms = new game_messages();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			SqlCommand cmd; SqlDataReader reader;
			try
			{
				conn.Open();
				cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "items_sms_user";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_sms", id_sms));
				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					sms.id = Convert.ToInt32(reader["id"]);
					sms.message_owner = Convert.ToInt32(reader["message_owner"]);
					sms.message_sender = Convert.ToInt32(reader["message_sender"]);
					sms.message_time = Convert.ToString(reader["message_time"]);
					sms.message_from = Convert.ToString(reader["message_from"]);
					sms.message_text = Convert.ToString(reader["message_text"]);
					sms.del_owner = Convert.ToInt32(reader["del_owner"]);
					sms.del_owner = Convert.ToInt32(reader["del_sender"]);
					sms.names_user = Convert.ToString(reader["names_user"]);
					sms.names_user2 = Convert.ToString(reader["names_user2"]);
				}
				conn.Close();

			}
			catch
			{
				conn.Close();
			}

			return sms;
		}

		public static bool sent_sms(game_messages sms)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "sms_sent_user";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@owner", sms.message_owner));
				cmd.Parameters.Add(new SqlParameter("@sender", sms.message_sender));
				cmd.Parameters.Add(new SqlParameter("@pram_3", sms.message_from));
				cmd.Parameters.Add(new SqlParameter("@pram_4", sms.message_text));
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
		public static bool del_sms(String list_id, int flags)
		{
			// запрсо на удаление отчета. Если del_owner и del_sender = 1
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				switch (flags)
				{
					case 0:
						cmd.CommandText = "del_sms_from_sender";// Название процедуры на сервере
						break;
					case 1:
						cmd.CommandText = "del_sms_from_owner";// Название процедуры на сервере
						break;
					case 2:
						cmd.CommandText = "del_var_report_sms_attaker";// Название процедуры на сервере
						break;
					case 3:
						cmd.CommandText = "del_var_report_sms_deffers";// Название процедуры на сервере
						break;
				}
				cmd.Parameters.Add(new SqlParameter("@List", list_id));
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
		public static bool index_new_sms_ZIRO(int id_user)
		{
			// запрсо на удаление отчета. Если del_owner и del_sender = 1
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "ziro_index_new_sms";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
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
	}
}
