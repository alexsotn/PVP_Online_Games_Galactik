using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_games
{
	public partial class main_server : Form
	{
		List<timer_List> List_bld_and_proms;
		List<timer_List> List_Flt;
		List<timer_List> List_t_deff;
		List<timer_war_list> List_Att_flets_list;
		CancellationTokenSource Tok = new CancellationTokenSource();
		public main_server()
		{
			InitializeComponent();
		}
		int sec_stop = 0;
		private async void time_Ivents_Tick(object sender, EventArgs e)
		{
			try
			{
				//t_bld_prom();
				//Res();
				await Task.Run(() => Res());
				await Task.Run(() => t_bld_prom());
				await Task.Run(() => Flt());
				await Task.Run(() => t_deff());
				await Task.Run(() => Att_flets_list());

			//	await Task.Delay(1000);
			}
			catch
			{
				//	s_cts.Cancel();
				time_Ivents.Stop();
				time_Ivents.Start();
			}

			grid_Bld_tech.DataSource = List_bld_and_proms;
			grid_fleets.DataSource = List_Flt;
			grid_deff.DataSource = List_t_deff;
			grid_Attaked.DataSource = List_Att_flets_list;
			sec_stop++;
			if (sec_stop == 20)
			{
				sec_stop = 0;
				time_Ivents.Stop();
				time_Ivents.Start();
			}

		}

		private void t_bld_prom()
		{
			List_bld_and_proms = timer_List.Timers_bld_and_proms();
		}

		private void Flt()
		{
			List_Flt = timer_List.timers_fleets();
		}

		private void t_deff()
		{
			List_t_deff = timer_List.timers_deff();
		}
		private void Att_flets_list()
		{
			List_Att_flets_list = timer_war_list.get_list_ataaked();
		}
		private void Res()
		{
			UpDate_resurs.List_User_planets();
		}


		private void start_serv_Click(object sender, EventArgs e)
		{
			time_Ivents.Start();
			//timer1.Start();
		}

		private void stop_serv_Click(object sender, EventArgs e)
		{
			time_Ivents.Stop();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			//await Res();
		}

		private void DEL_sms_And_Report_Click(object sender, EventArgs e)
		{
			UpDate_resurs.Delete_All_sms_and_Report();
		}
	}
}
