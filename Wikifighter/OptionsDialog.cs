
using System;

namespace Wikifighter
{
	
	
	public partial class OptionsDialog : Gtk.Dialog
	{
		
		public OptionsDialog()
		{
			this.Build();
		}

	
		protected virtual void OnOptionsOkButtonClicked(object sender, System.EventArgs e)
		{
			this.Destroy();
		}
	}
}
