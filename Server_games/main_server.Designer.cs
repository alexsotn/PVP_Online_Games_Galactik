
namespace Server_games
{
	partial class main_server
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.start_serv = new System.Windows.Forms.Button();
			this.stop_serv = new System.Windows.Forms.Button();
			this.time_Ivents = new System.Windows.Forms.Timer(this.components);
			this.grid_Bld_tech = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.grid_fleets = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.grid_Attaked = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.grid_deff = new System.Windows.Forms.DataGridView();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.DEL_sms_And_Report = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grid_Bld_tech)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid_fleets)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid_Attaked)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid_deff)).BeginInit();
			this.SuspendLayout();
			// 
			// start_serv
			// 
			this.start_serv.Location = new System.Drawing.Point(27, 22);
			this.start_serv.Margin = new System.Windows.Forms.Padding(6);
			this.start_serv.Name = "start_serv";
			this.start_serv.Size = new System.Drawing.Size(238, 42);
			this.start_serv.TabIndex = 0;
			this.start_serv.Text = "Запустить сервер";
			this.start_serv.UseVisualStyleBackColor = true;
			this.start_serv.Click += new System.EventHandler(this.start_serv_Click);
			// 
			// stop_serv
			// 
			this.stop_serv.Location = new System.Drawing.Point(277, 22);
			this.stop_serv.Margin = new System.Windows.Forms.Padding(6);
			this.stop_serv.Name = "stop_serv";
			this.stop_serv.Size = new System.Drawing.Size(231, 42);
			this.stop_serv.TabIndex = 1;
			this.stop_serv.Text = "Остановить сервер";
			this.stop_serv.UseVisualStyleBackColor = true;
			this.stop_serv.Click += new System.EventHandler(this.stop_serv_Click);
			// 
			// time_Ivents
			// 
			this.time_Ivents.Interval = 1000;
			this.time_Ivents.Tick += new System.EventHandler(this.time_Ivents_Tick);
			// 
			// grid_Bld_tech
			// 
			this.grid_Bld_tech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_Bld_tech.Location = new System.Drawing.Point(27, 100);
			this.grid_Bld_tech.Name = "grid_Bld_tech";
			this.grid_Bld_tech.Size = new System.Drawing.Size(510, 165);
			this.grid_Bld_tech.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(302, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Log простройки и исследования";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(95, 279);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Log флот";
			// 
			// grid_fleets
			// 
			this.grid_fleets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_fleets.Location = new System.Drawing.Point(27, 306);
			this.grid_fleets.Name = "grid_fleets";
			this.grid_fleets.Size = new System.Drawing.Size(252, 165);
			this.grid_fleets.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 485);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(256, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "Log атаковать и разведать";
			// 
			// grid_Attaked
			// 
			this.grid_Attaked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_Attaked.Location = new System.Drawing.Point(27, 512);
			this.grid_Attaked.Name = "grid_Attaked";
			this.grid_Attaked.Size = new System.Drawing.Size(510, 165);
			this.grid_Attaked.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(356, 279);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 24);
			this.label4.TabIndex = 9;
			this.label4.Text = "Log оборона";
			// 
			// grid_deff
			// 
			this.grid_deff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_deff.Location = new System.Drawing.Point(285, 306);
			this.grid_deff.Name = "grid_deff";
			this.grid_deff.Size = new System.Drawing.Size(252, 165);
			this.grid_deff.TabIndex = 8;
			// 
			// timer1
			// 
			this.timer1.Interval = 30000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// DEL_sms_And_Report
			// 
			this.DEL_sms_And_Report.Location = new System.Drawing.Point(27, 683);
			this.DEL_sms_And_Report.Name = "DEL_sms_And_Report";
			this.DEL_sms_And_Report.Size = new System.Drawing.Size(510, 37);
			this.DEL_sms_And_Report.TabIndex = 10;
			this.DEL_sms_And_Report.Text = "Удалить все соообщение помеченые на удаления";
			this.DEL_sms_And_Report.UseVisualStyleBackColor = true;
			this.DEL_sms_And_Report.Click += new System.EventHandler(this.DEL_sms_And_Report_Click);
			// 
			// main_server
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 728);
			this.Controls.Add(this.DEL_sms_And_Report);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.grid_deff);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.grid_Attaked);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.grid_fleets);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.grid_Bld_tech);
			this.Controls.Add(this.stop_serv);
			this.Controls.Add(this.start_serv);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "main_server";
			this.Text = "Server";
			((System.ComponentModel.ISupportInitialize)(this.grid_Bld_tech)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid_fleets)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid_Attaked)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid_deff)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button start_serv;
		private System.Windows.Forms.Button stop_serv;
		private System.Windows.Forms.Timer time_Ivents;
		private System.Windows.Forms.DataGridView grid_Bld_tech;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView grid_fleets;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView grid_Attaked;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView grid_deff;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button DEL_sms_And_Report;
	}
}

