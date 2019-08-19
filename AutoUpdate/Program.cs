using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoUpdate
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			// setup the auto update, and exit if there was an update
			Updater.GitHubRepo = "/codewitch-honey-crisis/AutoUpdate";
			if (Updater.AutoUpdate(args))
				return;
			// if we got here, just run the app
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new AutoUpdateDemo(args));
		}
	}
}
