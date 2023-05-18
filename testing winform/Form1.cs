using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Bluetooth.Factory;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Radios;
using Windows.Security.Authentication.OnlineId;
using Windows.UI.Xaml.Controls;
using Windows.Web.Syndication;

namespace testing_winform
{
	public partial class Window : Form
	{
		Guid serviceGUID = new Guid("60518635-a4f1-4831-898e-9c585928aff6");
		BluetoothClient bluetoothClient;
		

		public Window()
		{
			InitializeComponent();
		}

		public bool isBluetoothActive()
		{
			var sq = new SelectQuery("SELECT DeviceId FROM Win32_PnPEntity WHERE service='BthLEEnum'");
			var searcher = new ManagementObjectSearcher(sq);
			return searcher.Get().Count > 0;
		}

		public async Task<bool> Connect(BluetoothDeviceInfo deviceInfo)
		{
			if (deviceInfo == null)
			{
				throw new ArgumentNullException("deviceInfo");
			}

			return await Task.Run(async () =>
			{
				using (bluetoothClient = new BluetoothClient())
				{
					try
					{
						var bluetoothEndPoint = new BluetoothEndPoint(deviceInfo.DeviceAddress, BluetoothService.SerialPort);
						bluetoothClient.Connect(bluetoothEndPoint);
						
						if (bluetoothClient.Connected)
						{
							connect.Text = "Connected";
							connected = true;
							connect.ForeColor = Color.FromArgb(128, 255, 128);
							disconnect.ForeColor = Color.WhiteSmoke;
							connected = bluetoothClient.Connected;

							var localDatum = new byte[4];
							localDatum[0] = 8;
							await Send(bluetoothClient, localDatum);
						}
					} catch
					{
						Console.WriteLine("no connect lol");
					}
				}
				
				return false;
			});
		}

		public async Task<bool> Send(BluetoothClient bluetoothClient, byte[] datum)
		{
			return await Task.Run(() =>
			{
				var bluetoothStream = bluetoothClient.GetStream();

				try
				{
					connected = bluetoothClient.Connected;
					if (bluetoothClient.Connected && bluetoothStream != null)
					{
						bluetoothStream.Write(datum, 0, datum.Length);
						bluetoothStream.Flush();
						bluetoothStream.Close();
					}
				}
				catch
				{
					// you're done lol
					Console.WriteLine("data not sending GG");
					disconnectAll();
				}

				return false;
			});
		}

		bool connected = false;
		bool searching = false;
		bool issue = false;
		bool bluetoothNotConnectedIssue = false;
		bool draggingJoystick = false;

		private async void connect_Click(object sender, EventArgs e)
		{
			if (connected)
			{
				return;
			}

			var bluetoothEnabled = isBluetoothActive();
			if (!bluetoothEnabled)
			{
				if (bluetoothNotConnectedIssue)
				{
					return;
				}

				bluetoothNotConnectedIssue = true;
				connect.Text = "bluetooth is off";
				connect.ForeColor = Color.FromArgb(255, 128, 128);

				return;
			} else
			{
				connect.ForeColor = Color.WhiteSmoke;
				connect.Text = "connect";
				bluetoothNotConnectedIssue = false;
			}

			if (searching || issue || bluetoothNotConnectedIssue) return;

			var brush = new SolidBrush(Color.White);
			var graphics = this.CreateGraphics();
			graphics.FillRectangle(brush, new Rectangle(304, 298, 100, 100));
			brush.Dispose();
			graphics.Dispose();

			searching = true;

			connect.Text = "connecting";
			devices.Items.Clear();

			BluetoothDeviceInfo[] foundBluetoothDevices;
			using (bluetoothClient = new BluetoothClient())
			{
				foundBluetoothDevices = await Task.Run(() => bluetoothClient.DiscoverDevices());
			}

			foreach (var device in foundBluetoothDevices)
			{
				Console.WriteLine(device.DeviceName);
				devices.Items.Add(device.DeviceName);
			}

			foreach (var device in foundBluetoothDevices)
			{
				if (device.DeviceName == "HC-05")
				{
					await Connect(device);
					return;
				}
			}
			
			searching = false;
			issue = false;
			connect.Text = "connection failed";
		}

		private void disconnectAll()
		{
			if (connected)
			{
				connected = false;
				connect.ForeColor = Color.WhiteSmoke;
				disconnect.ForeColor = Color.FromArgb(255, 128, 128);
				connect.Text = "connect";
			}

			if (bluetoothClient.Connected)
			{
				bluetoothClient.Close();
				bluetoothClient.Dispose();
			}
		}

		private void disconnect_Click(object sender, EventArgs e)
		{
			disconnectAll();
		}

		private void Window_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (bluetoothClient != null && bluetoothClient.Connected)
			{
				bluetoothClient.Close();
				bluetoothClient.Dispose();
			}
		}

		bool joystickLocationSaved;
		Point joystickInitialPosition;

		int lastMouseX, lastMouseY;
		int totalXDelta, totalYDelta;

		bool firstMouseMove = true;
		
		private void joystick_MouseDown(object sender, MouseEventArgs e)
		{
			if (!draggingJoystick)
			{
				if (!joystickLocationSaved)
				{
					joystickInitialPosition = joystick.Location;
					joystickLocationSaved = true;
				}
				draggingJoystick = true;
			}
		}

		private void joystick_MouseUp(object sender, MouseEventArgs e)
		{
			if (draggingJoystick)
			{
				totalXDelta = 0; totalYDelta = 0;
				lastMouseX = 0; lastMouseY = 0;
				joystick.Location = joystickInitialPosition;
				firstMouseMove = true;
				draggingJoystick = false;
			}
		}

		private void joystick_MouseMove(object sender, MouseEventArgs e)
		{
			if (draggingJoystick)
			{
				if (firstMouseMove)
				{
					firstMouseMove = false;
					joystick.Location = joystickInitialPosition;
					lastMouseX = e.X;
					lastMouseY = e.Y;
					totalXDelta = 0;
					totalYDelta = 0;
				}

				int xDelta = e.X - lastMouseX;
				int yDelta = e.Y - lastMouseY;

				totalXDelta += xDelta;
				totalYDelta += yDelta;

				joystick.Location = new Point(
					joystickInitialPosition.X + clamp(totalXDelta / 4, -20, 20),
					joystickInitialPosition.Y + clamp(totalYDelta / 4, -20, 20)
				);

				Console.WriteLine("X " + clamp(totalXDelta / 4, -20, 20));
				Console.WriteLine("Y " + -clamp(totalYDelta / 4, -20, 20));

				lastMouseX = e.X;
				lastMouseY = e.Y;
			}
		}

		private void movement_wheels_speed_Scroll(object sender, EventArgs e)
		{
			Console.WriteLine("movement wheel scroll " + movement_wheels_speed.Value.ToString());
		}

		private void launcher_wheels_speed_Scroll(object sender, EventArgs e)
		{
			Console.WriteLine("launcher wheel scroll " + launcher_wheels_speed.Value.ToString());
		}

		private void all_wheels_speed_Scroll(object sender, EventArgs e)
		{
			Console.WriteLine("all wheel scroll " + all_wheels_speed.Value.ToString());
		}

		public int clamp(int x, int y, int z)
		{
			if (x < y) {
				x = y;
			} else if (x > z) {
				x = z;
			}

			return x;
		}
		private void Window_MouseMove(object sender, MouseEventArgs e)
		{
			
		}
	}
}
