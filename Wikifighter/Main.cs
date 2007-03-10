// project created on 08.03.2007 at 15:01
using System;
using Gtk;
using Gecko;

namespace Wikifighter
{
	class MainClass
	{
	
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
			WikifighterBackend b = new WikifighterBackend(win);
		}
	}
}