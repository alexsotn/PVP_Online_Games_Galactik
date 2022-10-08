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
	public partial class setn_sms : Form
	{
		int id_sender, id_owner;
		public setn_sms(int my_id, int id_user, string names)
		{
			InitializeComponent();
			name_user.Text = names;
			txt_tems.Focus();
			id_sender = id_user;
			id_owner = my_id;
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
				sms_ansve.message_owner = id_owner;//отправитель
				sms_ansve.message_sender = id_sender;// получатель
				sms_ansve.message_text = sms_ansver.Text;
				sms_ansve.message_from = txt_tems.Text;

				if (game_messages.sent_sms(sms_ansve))
				{
					MessageBox.Show("Смс отправлено");
					Close();
				}

				else
					MessageBox.Show("Ошибка при отправке смс!");
			}
		}
	}
}
