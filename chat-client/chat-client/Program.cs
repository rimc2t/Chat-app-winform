using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace chat_client
{
	class Program
	{
		public static ConnectServer con = new ConnectServer();
		public static HandleClient han = new HandleClient();
		public static string username = null;
		public static string password = null;
		public static List<string> listUsername = new List<string>();
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new fLogin());
		}
	}
}
