
namespace DIPLOM_SAV
{
	partial class spy_forms_planets
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txt_cols = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.txt_cols)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(24, 18);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Шпионские зонты:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(23, 55);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(257, 39);
			this.button1.TabIndex = 2;
			this.button1.Text = "Отправить шпионов";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(290, 56);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(103, 38);
			this.button2.TabIndex = 3;
			this.button2.Text = "Отмена";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txt_cols
			// 
			this.txt_cols.Location = new System.Drawing.Point(230, 16);
			this.txt_cols.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.txt_cols.Name = "txt_cols";
			this.txt_cols.Size = new System.Drawing.Size(163, 32);
			this.txt_cols.TabIndex = 4;
			this.txt_cols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// spy_forms_planets
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DIPLOM_SAV.Properties.Resources.tab2r_bg;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(417, 110);
			this.Controls.Add(this.txt_cols);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "spy_forms_planets";
			this.Text = "spy_forms_planets";
			((System.ComponentModel.ISupportInitialize)(this.txt_cols)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.NumericUpDown txt_cols;
	}
}