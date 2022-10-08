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
	public partial class user_sms : Form
	{
		int my_id; game_messages sms;
		public user_sms(int id_user, int id_sms, int flags)
		{
			InitializeComponent();
			my_id = id_user;
			sms = game_messages.item_sms(id_sms);
			if (flags == 1)
			{
				name_user.Text = sms.names_user2.ToString();
				tems_sms.Text = sms.message_from.ToString();
				date_sms.Text = sms.message_time.ToString();
				txt_sms.Text = sms.message_text.ToString();
				this.Width = 380;
			}
			else
			{
				name_user.Text = sms.names_user.ToString();
				tems_sms.Text = sms.message_from.ToString();
				date_sms.Text = sms.message_time.ToString();
				txt_sms.Text = sms.message_text.ToString();
			}

		}

		private void bt_close_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void sms_ansver_Leave(object sender, EventArgs e)
		{
			if (sms_ansver.Text == "")
			{
				sms_ansver.Text = "Введите текст сообщения...";
				sms_ansver.ForeColor = Color.Gray;
			}
		}

		private void sms_ansver_Enter(object sender, EventArgs e)
		{
			if (sms_ansver.Text == "Введите текст сообщения...")
			{
				sms_ansver.Text = null;
				sms_ansver.ForeColor = Color.Black;
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (sms_ansver.Text != "Введите текст сообщения..." && sms_ansver.Text != "")
			{
				game_messages sms_ansve = new game_messages();
				sms_ansve.message_owner = sms.message_sender;//отправитель
				sms_ansve.message_sender = sms.message_owner;// получатель
				sms_ansve.message_text = sms_ansver.Text;
				sms_ansve.message_from = "Ответ от " + sms.names_user2;

				if (game_messages.sent_sms(sms_ansve))
				{
					MessageBox.Show("Ответ на сообщение отправленно");
					Close();
				}

				else
					MessageBox.Show("Ошибка при отправке ответа!");
			}
		}
	}
}
