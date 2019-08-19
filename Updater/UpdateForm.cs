using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
	public partial class UpdateForm : System.Windows.Forms.Form, IProgress<string>
	{
		string[] _args;
		public UpdateForm(string[] args)
		{
			_args = args;
			InitializeComponent();
			
		}
		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			var exeName = _args[0];
			Status = "Downloading...";
			WebRequest wrq = WebRequest.Create(_args[1]);
			WebResponse wrs = wrq.GetResponse();
			using (var stm = wrs.GetResponseStream())
			{
				// equiv of this. but not available on this platform:
				//zip.ExtractToDirectory(Environment.CurrentDirectory, true);
				var zip = new ZipArchive(stm);
				foreach(var entry in zip.Entries)
				{
					Status = string.Concat("Unzipping " , entry.Name,"...");
					try
					{
						File.Delete(entry.FullName);
					}
					catch { }
					var d = Path.GetDirectoryName(entry.FullName);
					if (!string.IsNullOrEmpty(d))
					{
						try
						{
							Directory.CreateDirectory(d);
						}
						catch { }
					}
					using (var stm1 = entry.Open())
						using(var stm2 = File.OpenWrite(entry.FullName))
							stm1.CopyTo(stm2);
				}
				
				
			}
			Status = "Launching application...";
			var psi = new ProcessStartInfo();
			var args = new StringBuilder();
			var delim = "";
			for (var i = 2; i < _args.Length; i++)
			{
				args.Append(delim);
				args.Append(_Esc(_args[i]));
				args.Append(' ');
			}
			psi.FileName = exeName;
			psi.Arguments = args.ToString();
			var proc = Process.Start(psi);
			Close();
		}
		public string Status {
			get { return label1.Text; }
			set { label1.Text = value; Refresh(); }
		}

		void IProgress<string>.Report(string value)
		{
			Status = value;
		}
		static string _Esc(string arg)
		{
			return string.Concat("\"", arg.Replace("\"", "\"\""), "\"");
		}
	}
	
	
}
