
namespace DIPLOM_SAV
{
	partial class avtorization
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(avtorization));
			this.txt_login = new System.Windows.Forms.TextBox();
			this.txt_pass = new System.Windows.Forms.TextBox();
			this.save_user = new System.Windows.Forms.CheckBox();
			this.bt_input = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.reges = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_online_user = new System.Windows.Forms.Label();
			this.txt_user_all = new System.Windows.Forms.Label();
			this.bt_exit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txt_login
			// 
			this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txt_login.ForeColor = System.Drawing.Color.Gray;
			this.txt_login.Location = new System.Drawing.Point(919, 373);
			this.txt_login.MaxLength = 50;
			this.txt_login.Name = "txt_login";
			this.txt_login.Size = new System.Drawing.Size(131, 26);
			this.txt_login.TabIndex = 0;
			this.txt_login.Tag = "1";
			this.txt_login.Text = "login";
			this.txt_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_login.Enter += new System.EventHandler(this.txt_login_Enter);
			this.txt_login.Leave += new System.EventHandler(this.Leahe);
			// 
			// txt_pass
			// 
			this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txt_pass.ForeColor = System.Drawing.Color.Gray;
			this.txt_pass.Location = new System.Drawing.Point(919, 408);
			this.txt_pass.MaxLength = 50;
			this.txt_pass.Name = "txt_pass";
			this.txt_pass.PasswordChar = '*';
			this.txt_pass.Size = new System.Drawing.Size(131, 26);
			this.txt_pass.TabIndex = 1;
			this.txt_pass.Tag = "2";
			this.txt_pass.Text = "*****";
			this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
			this.txt_pass.Leave += new System.EventHandler(this.Leahe);
			// 
			// save_user
			// 
			this.save_user.AutoSize = true;
			this.save_user.BackColor = System.Drawing.Color.Transparent;
			this.save_user.ForeColor = System.Drawing.Color.White;
			this.save_user.Location = new System.Drawing.Point(919, 441);
			this.save_user.Name = "save_user";
			this.save_user.Size = new System.Drawing.Size(111, 17);
			this.save_user.TabIndex = 2;
			this.save_user.Text = "Запомнить меня";
			this.save_user.UseVisualStyleBackColor = false;
			// 
			// bt_input
			// 
			this.bt_input.BackColor = System.Drawing.Color.Transparent;
			this.bt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bt_input.Location = new System.Drawing.Point(947, 464);
			this.bt_input.Name = "bt_input";
			this.bt_input.Size = new System.Drawing.Size(73, 28);
			this.bt_input.TabIndex = 3;
			this.bt_input.Text = "Вход";
			this.bt_input.UseVisualStyleBackColor = false;
			this.bt_input.Click += new System.EventHandler(this.bt_input_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(534, 301);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(350, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// reges
			// 
			this.reges.AutoSize = true;
			this.reges.BackColor = System.Drawing.Color.Transparent;
			this.reges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.reges.ForeColor = System.Drawing.Color.White;
			this.reges.Location = new System.Drawing.Point(634, 313);
			this.reges.Name = "reges";
			this.reges.Size = new System.Drawing.Size(154, 24);
			this.reges.TabIndex = 5;
			this.reges.Text = " РЕГЕСТРАЦИЯ";
			this.reges.Click += new System.EventHandler(this.reges_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(534, 624);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 150);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(344, 150);
			this.label2.TabIndex = 0;
			this.label2.Text = "Space — это онлайновая мультиплеерная космическая стратегия. Тысячи игроков высту" +
    "пают одновременно против друг друга. Для игры Вам нужен лишь обычный компьютер.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.txt_online_user, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.txt_user_all, 1, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(541, 792);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(340, 56);
			this.tableLayoutPanel2.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.Green;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(254, 28);
			this.label3.TabIndex = 0;
			this.label3.Text = "Игроков в сети:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.Green;
			this.label4.Location = new System.Drawing.Point(3, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(254, 28);
			this.label4.TabIndex = 1;
			this.label4.Text = "Количество игроков:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt_online_user
			// 
			this.txt_online_user.AutoSize = true;
			this.txt_online_user.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txt_online_user.ForeColor = System.Drawing.Color.White;
			this.txt_online_user.Location = new System.Drawing.Point(263, 0);
			this.txt_online_user.Name = "txt_online_user";
			this.txt_online_user.Size = new System.Drawing.Size(74, 28);
			this.txt_online_user.TabIndex = 2;
			this.txt_online_user.Text = "0";
			this.txt_online_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_user_all
			// 
			this.txt_user_all.AutoSize = true;
			this.txt_user_all.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txt_user_all.ForeColor = System.Drawing.Color.White;
			this.txt_user_all.Location = new System.Drawing.Point(263, 28);
			this.txt_user_all.Name = "txt_user_all";
			this.txt_user_all.Size = new System.Drawing.Size(74, 28);
			this.txt_user_all.TabIndex = 3;
			this.txt_user_all.Text = "0";
			this.txt_user_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bt_exit
			// 
			this.bt_exit.Location = new System.Drawing.Point(919, 498);
			this.bt_exit.Name = "bt_exit";
			this.bt_exit.Size = new System.Drawing.Size(131, 23);
			this.bt_exit.TabIndex = 8;
			this.bt_exit.Text = "Выход";
			this.bt_exit.UseVisualStyleBackColor = true;
			this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
			// 
			// avtorization
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DIPLOM_SAV.Properties.Resources.bg;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1400, 900);
			this.Controls.Add(this.bt_exit);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.reges);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.bt_input);
			this.Controls.Add(this.save_user);
			this.Controls.Add(this.txt_pass);
			this.Controls.Add(this.txt_login);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "avtorization";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.avtorization_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_login;
		private System.Windows.Forms.TextBox txt_pass;
		private System.Windows.Forms.CheckBox save_user;
		private System.Windows.Forms.Button bt_input;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label reges;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label txt_online_user;
		private System.Windows.Forms.Label txt_user_all;
		private System.Windows.Forms.Button bt_exit;
	}
}