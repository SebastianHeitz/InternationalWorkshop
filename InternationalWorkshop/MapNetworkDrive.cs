using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace InternationalWorkshop
{
	class MapNetworkDrive
	{
		/// <summary>
		/// Disconnects a network drive
		/// </summary>
		/// <param name="drive">Drive (z.B. L:)</param>
		public static void Disconnect(string drive)
		{
			Process p = new Process();
			p.StartInfo.FileName = "net";
			p.StartInfo.Arguments = string.Format("use {0} /DELETE /Y", drive);
			p.StartInfo.UseShellExecute = false;
			p.Start();
		}
		/// <summary>
		/// Connects a network drive
		/// </summary>
		/// <param name="drive">The drive letter (e.g. L:)</param>
		/// <param name="server">The UNC path to the remote drive (e.g. \\MyServer\MyPrinter)</param>
		/// <param name="user">The User</param>
		/// <param name="password">The Password Used For Login</param>
		public static void Connect(string drive, string server)
		{
			Process p = new Process();
			p.StartInfo.FileName = "net";
			p.StartInfo.Arguments = string.Format("use {0} {1}", drive, server);
			string test = p.StartInfo.Arguments.ToString();
			p.StartInfo.UseShellExecute = false;
			p.Start();
		}
	}
}
