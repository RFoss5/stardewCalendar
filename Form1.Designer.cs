namespace stardewCalendar
{
	partial class Form1
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
			this.seasonChooser = new System.Windows.Forms.ComboBox();
			this.dateChooser = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// seasonChooser
			// 
			this.seasonChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.seasonChooser.FormattingEnabled = true;
			this.seasonChooser.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall",
            "Winter"});
			this.seasonChooser.Location = new System.Drawing.Point(8, 412);
			this.seasonChooser.Name = "seasonChooser";
			this.seasonChooser.Size = new System.Drawing.Size(263, 28);
			this.seasonChooser.TabIndex = 0;
			// 
			// dateChooser
			// 
			this.dateChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dateChooser.FormattingEnabled = true;
			this.dateChooser.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28"});
			this.dateChooser.Location = new System.Drawing.Point(278, 412);
			this.dateChooser.Name = "dateChooser";
			this.dateChooser.Size = new System.Drawing.Size(121, 28);
			this.dateChooser.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(413, 414);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dateChooser);
			this.Controls.Add(this.seasonChooser);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox seasonChooser;
		private System.Windows.Forms.ComboBox dateChooser;
		private System.Windows.Forms.Button button1;
	}
}

