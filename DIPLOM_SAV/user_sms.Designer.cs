
namespace DIPLOM_SAV
{
	partial class user_sms
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
			this.label1 = new System.Windows.Forms.Label();
			this.name_user = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tems_sms = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_sms = new System.Windows.Forms.RichTextBox();
			this.date_sms = new System.Windows.Forms.Label();
			this.sms_ansver = new System.Windows.Forms.RichTextBox();
			this.bt_close = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.bt_close)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Пользователь:";
			// 
			// name_user
			// 
			this.name_user.AutoSize = true;
			this.name_user.BackColor = System.Drawing.Color.Transparent;
			this.name_user.Location = new System.Drawing.Point(134, 13);
			this.name_user.Name = "name_user";
			this.name_user.Size = new System.Drawing.Size(89, 20);
			this.name_user.TabIndex = 1;
			this.name_user.Text = "name_user";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(13, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Тема смс:";
			// 
			// tems_sms
			// 
			this.tems_sms.AutoSize = true;
			this.tems_sms.BackColor = System.Drawing.Color.Transparent;
			this.tems_sms.Location = new System.Drawing.Point(91, 43);
			this.tems_sms.Name = "tems_sms";
			this.tems_sms.Size = new System.Drawing.Size(82, 20);
			this.tems_sms.TabIndex = 3;
			this.tems_sms.Text = "tems_sms";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(121, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(138, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Содержимое смс";
			// 
			// txt_sms
			// 
			this.txt_sms.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.txt_sms.Location = new System.Drawing.Point(6, 112);
			this.txt_sms.Name = "txt_sms";
			this.txt_sms.ReadOnly = true;
			this.txt_sms.Size = new System.Drawing.Size(368, 155);
			this.txt_sms.TabIndex = 5;
			this.txt_sms.Text = "";
			// 
			// date_sms
			// 
			this.date_sms.AutoSize = true;
			this.date_sms.BackColor = System.Drawing.Color.Transparent;
			this.date_sms.ForeColor = System.Drawing.Color.PaleGreen;
			this.date_sms.Location = new System.Drawing.Point(12, 63);
			this.date_sms.Name = "date_sms";
			this.date_sms.Size = new System.Drawing.Size(50, 20);
			this.date_sms.TabIndex = 6;
			this.date_sms.Text = "#date";
			// 
			// sms_ansver
			// 
			this.sms_ansver.BackColor = System.Drawing.Color.White;
			this.sms_ansver.ForeColor = System.Drawing.Color.Gray;
			this.sms_ansver.Location = new System.Drawing.Point(6, 284);
			this.sms_ansver.Name = "sms_ansver";
			this.sms_ansver.Size = new System.Drawing.Size(314, 48);
			this.sms_ansver.TabIndex = 8;
			this.sms_ansver.Text = "Введите текст сообщения...";
			this.sms_ansver.Enter += new System.EventHandler(this.sms_ansver_Enter);
			this.sms_ansver.Leave += new System.EventHandler(this.sms_ansver_Leave);
			// 
			// bt_close
			// 
			this.bt_close.BackColor = System.Drawing.Color.LightGreen;
			this.bt_close.Image = global::DIPLOM_SAV.Properties.Resources.back;
			this.bt_close.Location = new System.Drawing.Point(338, 3);
			this.bt_close.Name = "bt_close";
			this.bt_close.Size = new System.Drawing.Size(36, 42);
			this.bt_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bt_close.TabIndex = 9;
			this.bt_close.TabStop = false;
			this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::DIPLOM_SAV.Properties.Resources.sent_sms;
			this.pictureBox1.Location = new System.Drawing.Point(326, 284);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(47, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// user_sms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DIPLOM_SAV.Properties.Resources.background_IMAGE;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(381, 341);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.bt_close);
			this.Controls.Add(this.sms_ansver);
			this.Controls.Add(this.date_sms);
			this.Controls.Add(this.txt_sms);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tems_sms);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.name_user);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "user_sms";
			((System.ComponentModel.ISupportInitialize)(this.bt_close)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label name_user;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label tems_sms;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox txt_sms;
		private System.Windows.Forms.Label date_sms;
		private System.Windows.Forms.RichTextBox sms_ansver;
		private System.Windows.Forms.PictureBox bt_close;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}