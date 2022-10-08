using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIPLOM_SAV.heard_games;

namespace DIPLOM_SAV
{
	public partial class messing : Form
	{
		int id_user_my; List<game_messages> Inbox, Sender; List<sms_vars> war_list; main_F F_main; List<sms_vars> against_My;
		public messing(int id_user, main_F main_f)
		{
			InitializeComponent();
			id_user_my = id_user;
			Updates_sms();
			game_messages.index_new_sms_ZIRO(id_user);
			timer1.Start();
			grid_sms.DefaultCellStyle.ForeColor = Color.Black;
			grid_sent.DefaultCellStyle.ForeColor = Color.Black;
			grid_wars.DefaultCellStyle.ForeColor = Color.Black;
			grid_wars_against_My.DefaultCellStyle.ForeColor = Color.Black;
			F_main = main_f;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Updates_sms();
		}

		void Updates_sms()
		{
			Inbox = game_messages.List_sms(id_user_my, 0);
			Sender = game_messages.List_sms(id_user_my, 1);
			war_list = sms_vars.list_sms(id_user_my, 1);
			against_My = sms_vars.list_sms(id_user_my, 2);

			grid_sms.DataSource = Inbox;
			grid_sent.DataSource = Sender;
			grid_wars.DataSource = war_list;
			grid_wars_against_My.DataSource = against_My;
		}

		private void grid_sms_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (grid_sms.Columns[e.ColumnIndex].Name != "del_chek_inbox")
			{
				int id = Convert.ToInt32(this.grid_sms.CurrentRow.Cells["Column1"].Value);
				var form_1 = new user_sms(id_user_my, id, 0);
				form_1.StartPosition = FormStartPosition.CenterScreen;
				Tab_contener.Visible = false;
				form_1.ShowDialog();
				Tab_contener.Visible = true;
			}

		}

		private void grid_sent_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (grid_sent.Columns[e.ColumnIndex].Name != "del_chek_sent")
			{
				int id = Convert.ToInt32(this.grid_sent.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value);
				var form_1 = new user_sms(id_user_my, id, 1);
				form_1.StartPosition = FormStartPosition.CenterScreen;
				form_1.Width = 381;
				Tab_contener.Visible = false;
				form_1.ShowDialog();
				Tab_contener.Visible = true;
			}
		}

		private void grid_wars_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (grid_wars.Columns[e.ColumnIndex].Name != "chek_war")
			{
				//MessageBox.Show(e.RowIndex.ToString());
				if (Convert.ToString(grid_wars[6, e.RowIndex].Value) == "Атака")
				{
					int id = Convert.ToInt32(this.grid_wars.CurrentRow.Cells["Column5"].Value);
					var form_1 = new war_report(id);
					form_1.StartPosition = FormStartPosition.CenterParent;
					Tab_contener.Visible = false;
					form_1.ShowDialog();
					Tab_contener.Visible = true;
				}
				else if (Convert.ToString(grid_wars[6, e.RowIndex].Value) == "Шпионаж")
				{
					int id = Convert.ToInt32(this.grid_wars.CurrentRow.Cells["Column5"].Value);
					var form_1 = new spy_sms(id, id_user_my, F_main);
					form_1.StartPosition = FormStartPosition.CenterParent;
					Tab_contener.Visible = false;
					form_1.ShowDialog();
					Tab_contener.Visible = true;
				}

			}
		}

		private void grid_wars_against_My_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (grid_wars_against_My.Columns[e.ColumnIndex].Name != "chek_war_as_My")
			{
				//MessageBox.Show(e.RowIndex.ToString());
				if (Convert.ToString(grid_wars_against_My[6, e.RowIndex].Value) == "Атака")
				{
					int id = Convert.ToInt32(this.grid_wars_against_My.CurrentRow.Cells["ID_war_my"].Value);
					var form_1 = new war_report(id);
					form_1.StartPosition = FormStartPosition.CenterParent;
					Tab_contener.Visible = false;
					form_1.ShowDialog();
					Tab_contener.Visible = true;
				}

				else if (Convert.ToString(grid_wars_against_My[6, e.RowIndex].Value) == "Шпионаж")
				{
					MessageBox.Show("Вас разведал игрок с никок: " + Convert.ToString(this.grid_wars_against_My.CurrentRow.Cells["name_vrag_Spy"].Value) + "\n Перейдите в рейтинг и сможете найти его координаты");
				}

			}
		}

		private void bt_del_sms_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
				"Вы уверенны что хотите удалить выбранные смс ?!",
					"Сообщение",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Information,
					MessageBoxDefaultButton.Button1);
			if (result == DialogResult.Yes)
			{
				List<int> list = new List<int>(); ; string id_param = "";
				switch (tabControl1.SelectedIndex)
				{
					case 0:
						list = new List<int>();
						for (int i = 0; i < Inbox.Count; i++)
						{
							//MessageBox.Show(grid_sms[0, i].Value.ToString());
							if (Convert.ToBoolean(grid_sms[0, i].Value) == true)
								list.Add(Convert.ToInt32(Inbox.ElementAt(i).id));
						}
						break;
					case 1:
						list = new List<int>();
						for (int i = 0; i < Sender.Count; i++)
						{
							if (Convert.ToBoolean(grid_sent[0, i].Value) == true)
								list.Add(Convert.ToInt32(Sender.ElementAt(i).id));
						}
						break;
					case 2:
						MessageBox.Show("3");
						list = new List<int>();
						for (int i = 0; i < war_list.Count; i++)
						{
							if (Convert.ToBoolean(grid_wars[0, i].Value) == true)
								list.Add(Convert.ToInt32(war_list.ElementAt(i).id));
						}
						break;
					case 3:
						MessageBox.Show("4");
						list = new List<int>();
						for (int i = 0; i < against_My.Count; i++)
						{
							if (Convert.ToBoolean(grid_wars_against_My[0, i].Value) == true)
								list.Add(Convert.ToInt32(against_My.ElementAt(i).id));
						}
						break;
				}
				for (int i = 0; i < list.Count; i++)
				{
					if (i == list.Count - 1)
						id_param += list.ElementAt(i).ToString();
					else id_param += list.ElementAt(i).ToString() + ",";
				}
				if (id_param != "")
				{
					if (game_messages.del_sms(id_param, tabControl1.SelectedIndex))
						MessageBox.Show("Сообщение удалены)");
					else
						MessageBox.Show("Ошибка не вышло удалить смс! Пожалуста попробуйте позже!");
				}
				else
					MessageBox.Show("Вы ничего не выбрали что бы начать удалять");

			}
			Updates_sms();
		}
	}
}
