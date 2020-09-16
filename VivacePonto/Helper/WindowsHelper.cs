using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace VivacePonto.Helper
{
    public class WindowsHelper
    {

		// The ShowWindowAsync method alters the windows show state through the nCmdShow parameter.
		// The nCmdShow parameter can have any of the SW values.
		// See http://msdn.microsoft.com/library/en-us/winui/winui/windowsuserinterface/windowing/windows/windowreference/windowfunctions/showwindowasync.asp
		// for full documentation.
		[DllImport("user32.dll")]
		public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

		// An enumeration containing all the possible SW values.
		public enum SW : int
		{
			HIDE = 0,
			SHOWNORMAL = 1,
			SHOWMINIMIZED = 2,
			SHOWMAXIMIZED = 3,
			SHOWNOACTIVATE = 4,
			SHOW = 5,
			MINIMIZE = 6,
			SHOWMINNOACTIVE = 7,
			SHOWNA = 8,
			RESTORE = 9,
			SHOWDEFAULT = 10
		}


		public static void MinimizeAll()
		{
			System.Diagnostics.Process thisProcess = System.Diagnostics.Process.GetCurrentProcess();
			System.Diagnostics.Process[] processes =
			   System.Diagnostics.Process.GetProcesses();
			foreach (System.Diagnostics.Process process in processes)
			{
				if (process == thisProcess) continue;
				System.IntPtr handle = process.MainWindowHandle;
				if (handle == System.IntPtr.Zero) continue;
				ShowWindowAsync(handle, (int)SW.MINIMIZE);
			}
		}
	}
}
