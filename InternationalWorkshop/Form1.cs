using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Net.NetworkInformation;

namespace InternationalWorkshop
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnChangeServer_ClickHandler(object sender, EventArgs e)
		{
			string driveletter = "T:";
			string ipAdress = tbx_IP.Text;
			string sharedFolder = @"\Videos";
			string networkPath = @"\\" + ipAdress + sharedFolder;

			string boCashTask = "thunderbird";
			lbx_details.Items.Clear();
			lbx_details.Items.Add("Prüfe, ob BoCash geöffnet ist ...");
			lbx_details.Update();
			if (Process.GetProcessesByName(boCashTask).Length > 0)
			{
				MessageBox.Show(this, "ACHTUNG! BoCash ist noch geöffnet! Bitte die Anwendung schließen!");
			}
			else
			{
				lbx_details.Items.Add("BoCash ist nicht geöffnet.");
				lbx_details.Update();
				DriveInfo drive = new DriveInfo(driveletter);
				lbx_details.Items.Add("Prüfe, ob bereits ein Netzlaufwerk verbunden ist ...");
				lbx_details.Update();
				if (drive.IsReady)
				{
					lbx_details.Items.Add("Es ist bereits eine Netzlaufwerk verbunden.");
					lbx_details.Update();
					lbx_details.Items.Add("Prüfe, ob Server erreichbar ist ...");
					lbx_details.Update();
					Ping computerIsOnline = new Ping();
					PingReply reply = computerIsOnline.Send(ipAdress);
					if (reply.Status == IPStatus.Success)
					{
						lbx_details.Items.Add("Server ist im Netzwerk erreichbar.");
						lbx_details.Update();
						lbx_details.Items.Add("Vorhandene Netzlaufwerke werden entfernt.");
						lbx_details.Update();
						MapNetworkDrive.Disconnect(driveletter);
						Thread.Sleep(5000);
						lbx_details.Items.Add("Netzlaufwerke werden verbunden.");
						lbx_details.Update();
						MapNetworkDrive.Connect(driveletter, networkPath);
						Thread.Sleep(5000);
						string driveName = tbx_sharedFolderName.Text;
						Thread.Sleep(5000);
						PowerShell PowerShellInstance = PowerShell.Create();
						lbx_details.Items.Add("Benenne Netzlaufwerk um.");
						lbx_details.Update();
						PowerShellInstance.AddScript("$shell = New-Object -ComObject Shell.Application");
						PowerShellInstance.Invoke();
						PowerShellInstance.AddScript("$shell.NameSpace('T:').Self.Name = '" + driveName + "'");
						PowerShellInstance.Invoke();
						Thread.Sleep(5000);
						DriveInfo newdrive = new DriveInfo(driveletter);
						if (newdrive.IsReady)
						{
							MessageBox.Show("Zuweisung auf neuen Server mit der IP " + ipAdress + " erfolgreich durchgeführt.");
						}
					}
					else
					{
						MessageBox.Show("Fehler: Der Rechner mit der IP: "+ipAdress+" ist nicht erreichbar! Bitte Netzwerkeinstellungen prüfen.");
					}
					
					
				}
				else
				{
					MapNetworkDrive.Connect(driveletter, networkPath);
				}
			}
			// Shutdown.Restart();
		}

		private void llb_showDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (lbx_details.Visible)
			{
				lbx_details.Hide();
				llb_showDetails.Text = "Details einblenden ...";
			}
			else
			{
				lbx_details.Show();
				llb_showDetails.Text = "Details ausblenden ...";
			}
		}
	}
}
