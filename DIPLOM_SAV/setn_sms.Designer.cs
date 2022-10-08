
namespace DIPLOM_SAV
{
	partial class setn_sms
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bt_close = new System.Windows.Forms.PictureBox();
			this.sms_ansver = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.name_user = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_tems = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bt_close)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::DIPLOM_SAV.Properties.Resources.sent_sms;
			this.pictureBox1.Location = new System.Drawing.Point(391, 70);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(43, 41);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// bt_close
			// 
			this.bt_close.BackColor = System.Drawing.Color.LightGreen;
			this.bt_close.Image = global::DIPLOM_SAV.Properties.Resources.back;
			this.bt_close.Location = new System.Drawing.Point(4, 9);
			this.bt_close.Margin = new System.Windows.Forms.Padding(4);
			this.bt_close.Name = "bt_close";
			this.bt_close.Size = new System.Drawing.Size(37, 40);
			this.bt_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bt_close.TabIndex = 19;
			this.bt_close.TabStop = false;
			this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
			// 
			// sms_ansver
			// 
			this.sms_ansver.BackColor = System.Drawing.Color.White;
			this.sms_ansver.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sms_ansver.ForeColor = System.Drawing.Color.Gray;
			this.sms_ansver.Location = new System.Drawing.Point(0, 118);
			this.sms_ansver.Margin = new System.Windows.Forms.Padding(4);
			this.sms_ansver.Name = "sms_ansver";
			this.sms_ansver.Size = new System.Drawing.Size(439, 184);
			this.sms_ansver.TabIndex = 18;
			this.sms_ansver.Text = "Введите текст сообщения...";
			this.sms_ansver.Enter += new System.EventHandler(this.sms_ansver_Enter);
			this.sms_ansver.Leave += new System.EventHandler(this.sms_ansver_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(183, 85);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 17);
			this.label3.TabIndex = 15;
			this.label3.Text = "Текс смс";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(49, 40);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 17);
			this.label2.TabIndex = 13;
			this.label2.Text = "Тема смс:";
			// 
			// name_user
			// 
			this.name_user.AutoSize = true;
			this.name_user.BackColor = System.Drawing.Color.Transparent;
			this.name_user.ForeColor = System.Drawing.Color.White;
			this.name_user.Location = new System.Drawing.Point(117, 9);
			this.name_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.name_user.Name = "name_user";
			this.name_user.Size = new System.Drawing.Size(79, 17);
			this.name_user.TabIndex = 12;
			this.name_user.Text = "name_user";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(49, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 17);
			this.label1.TabIndex = 11;
			this.label1.Text = "Кому смс: ";
			// 
			// txt_tems
			// 
			this.txt_tems.Location = new System.Drawing.Point(120, 40);
			this.txt_tems.MaxLength = 50;
			this.txt_tems.Name = "txt_tems";
			this.txt_tems.Size = new System.Drawing.Size(314, 23);
			this.txt_tems.TabIndex = 21;
			// 
			// setn_sms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DIPLOM_SAV.Properties.Resources.tab1_bg;
			this.ClientSize = new System.Drawing.Size(439, 302);
			this.Controls.Add(this.txt_tems);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.bt_close);
			this.Controls.Add(this.sms_ansver);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.name_user);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "setn_sms";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "setn_sms";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bt_close)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox bt_close;
		private System.Windows.Forms.RichTextBox sms_ansver;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label name_user;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_tems;
	}
}