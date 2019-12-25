using System;
using System.Windows.Forms;

namespace DaysCounter
{
	/// <summary>
	/// Program
	/// </summary>
	internal static class Program
	{
		/// <summary>
		/// The main entrance point of the application
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			using (MainWindow mainWindow = new MainWindow())
			{
				Application.Run(mainForm: mainWindow);
			}
		}
	}
}
