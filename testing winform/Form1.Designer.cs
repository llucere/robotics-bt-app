namespace testing_winform
{
	partial class Window
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
			this.connect = new System.Windows.Forms.Button();
			this.devices = new System.Windows.Forms.ListBox();
			this.joystick = new System.Windows.Forms.PictureBox();
			this.disconnect = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.all_wheels_speed = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.launcher_wheels_speed = new System.Windows.Forms.TrackBar();
			this.label4 = new System.Windows.Forms.Label();
			this.movement_wheels_speed = new System.Windows.Forms.TrackBar();
			this.label5 = new System.Windows.Forms.Label();
			this.usingAllSpeedOrIndividualSpeedCheckbox = new System.Windows.Forms.CheckBox();
			this.usingWASD = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.joystick)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.all_wheels_speed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.launcher_wheels_speed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.movement_wheels_speed)).BeginInit();
			this.SuspendLayout();
			// 
			// connect
			// 
			this.connect.BackColor = System.Drawing.SystemColors.WindowText;
			this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.connect.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.connect.Location = new System.Drawing.Point(13, 310);
			this.connect.Margin = new System.Windows.Forms.Padding(4);
			this.connect.Name = "connect";
			this.connect.Size = new System.Drawing.Size(248, 41);
			this.connect.TabIndex = 0;
			this.connect.Text = "connect";
			this.connect.UseVisualStyleBackColor = false;
			this.connect.Click += new System.EventHandler(this.connect_Click);
			// 
			// devices
			// 
			this.devices.BackColor = System.Drawing.SystemColors.WindowText;
			this.devices.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.devices.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.devices.FormattingEnabled = true;
			this.devices.ItemHeight = 17;
			this.devices.Location = new System.Drawing.Point(14, 13);
			this.devices.Margin = new System.Windows.Forms.Padding(4);
			this.devices.Name = "devices";
			this.devices.Size = new System.Drawing.Size(248, 289);
			this.devices.TabIndex = 1;
			// 
			// joystick
			// 
			this.joystick.BackColor = System.Drawing.Color.Transparent;
			this.joystick.BackgroundImage = global::testing_winform.Properties.Resources.joystick;
			this.joystick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.joystick.Cursor = System.Windows.Forms.Cursors.Hand;
			this.joystick.InitialImage = global::testing_winform.Properties.Resources.joystick;
			this.joystick.Location = new System.Drawing.Point(592, 297);
			this.joystick.Name = "joystick";
			this.joystick.Size = new System.Drawing.Size(89, 77);
			this.joystick.TabIndex = 2;
			this.joystick.TabStop = false;
			this.joystick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.joystick_MouseDown);
			this.joystick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.joystick_MouseMove);
			this.joystick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.joystick_MouseUp);
			// 
			// disconnect
			// 
			this.disconnect.BackColor = System.Drawing.SystemColors.WindowText;
			this.disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.disconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.disconnect.Location = new System.Drawing.Point(13, 359);
			this.disconnect.Margin = new System.Windows.Forms.Padding(4);
			this.disconnect.Name = "disconnect";
			this.disconnect.Size = new System.Drawing.Size(248, 41);
			this.disconnect.TabIndex = 3;
			this.disconnect.Text = "disconnect";
			this.disconnect.UseVisualStyleBackColor = false;
			this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(602, 261);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Movement";
			// 
			// all_wheels_speed
			// 
			this.all_wheels_speed.Location = new System.Drawing.Point(269, 342);
			this.all_wheels_speed.Maximum = 127;
			this.all_wheels_speed.Minimum = -127;
			this.all_wheels_speed.Name = "all_wheels_speed";
			this.all_wheels_speed.Size = new System.Drawing.Size(287, 45);
			this.all_wheels_speed.TabIndex = 6;
			this.all_wheels_speed.Scroll += new System.EventHandler(this.all_wheels_speed_Scroll);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label2.Location = new System.Drawing.Point(294, 322);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "All Wheels Speed";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label3.Location = new System.Drawing.Point(294, 254);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(155, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Launcher Wheels Speed";
			// 
			// launcher_wheels_speed
			// 
			this.launcher_wheels_speed.Location = new System.Drawing.Point(269, 274);
			this.launcher_wheels_speed.Maximum = 127;
			this.launcher_wheels_speed.Minimum = -127;
			this.launcher_wheels_speed.Name = "launcher_wheels_speed";
			this.launcher_wheels_speed.Size = new System.Drawing.Size(287, 45);
			this.launcher_wheels_speed.TabIndex = 8;
			this.launcher_wheels_speed.Scroll += new System.EventHandler(this.launcher_wheels_speed_Scroll);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label4.Location = new System.Drawing.Point(294, 186);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "Movement Wheels Speed";
			// 
			// movement_wheels_speed
			// 
			this.movement_wheels_speed.Location = new System.Drawing.Point(269, 206);
			this.movement_wheels_speed.Maximum = 127;
			this.movement_wheels_speed.Minimum = -127;
			this.movement_wheels_speed.Name = "movement_wheels_speed";
			this.movement_wheels_speed.Size = new System.Drawing.Size(287, 45);
			this.movement_wheels_speed.TabIndex = 10;
			this.movement_wheels_speed.Scroll += new System.EventHandler(this.movement_wheels_speed_Scroll);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label5.Location = new System.Drawing.Point(269, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(351, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "*the robot can be moved with WASD or the joystick";
			// 
			// usingAllSpeedOrIndividualSpeedCheckbox
			// 
			this.usingAllSpeedOrIndividualSpeedCheckbox.AutoSize = true;
			this.usingAllSpeedOrIndividualSpeedCheckbox.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.usingAllSpeedOrIndividualSpeedCheckbox.Location = new System.Drawing.Point(272, 128);
			this.usingAllSpeedOrIndividualSpeedCheckbox.Name = "usingAllSpeedOrIndividualSpeedCheckbox";
			this.usingAllSpeedOrIndividualSpeedCheckbox.Size = new System.Drawing.Size(230, 21);
			this.usingAllSpeedOrIndividualSpeedCheckbox.TabIndex = 13;
			this.usingAllSpeedOrIndividualSpeedCheckbox.Text = "Use \'All Wheels Speed\' slider";
			this.usingAllSpeedOrIndividualSpeedCheckbox.UseVisualStyleBackColor = true;
			// 
			// usingWASD
			// 
			this.usingWASD.AutoSize = true;
			this.usingWASD.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.usingWASD.Location = new System.Drawing.Point(272, 101);
			this.usingWASD.Name = "usingWASD";
			this.usingWASD.Size = new System.Drawing.Size(111, 21);
			this.usingWASD.TabIndex = 14;
			this.usingWASD.Text = "Using \'WASD\'";
			this.usingWASD.UseVisualStyleBackColor = true;
			// 
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.ClientSize = new System.Drawing.Size(718, 412);
			this.Controls.Add(this.usingWASD);
			this.Controls.Add(this.usingAllSpeedOrIndividualSpeedCheckbox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.movement_wheels_speed);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.launcher_wheels_speed);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.all_wheels_speed);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.disconnect);
			this.Controls.Add(this.joystick);
			this.Controls.Add(this.devices);
			this.Controls.Add(this.connect);
			this.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Window";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Football Launcher Robot Controller";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Window_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.joystick)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.all_wheels_speed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.launcher_wheels_speed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.movement_wheels_speed)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button connect;
		private System.Windows.Forms.ListBox devices;
		private System.Windows.Forms.PictureBox joystick;
		private System.Windows.Forms.Button disconnect;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar all_wheels_speed;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar launcher_wheels_speed;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TrackBar movement_wheels_speed;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox usingAllSpeedOrIndividualSpeedCheckbox;
		private System.Windows.Forms.CheckBox usingWASD;
	}
}

