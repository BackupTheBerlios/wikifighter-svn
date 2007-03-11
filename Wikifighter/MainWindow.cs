using System;
using Gtk;
using Gecko;
using Cairo;
using Wikifighter;
public partial class MainWindow: Gtk.Window
{	
	private WebControl gecko;
	//private Notebook geckoTab;
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		
		//geckoTab = new Notebook();
		gecko = new WebControl();
		
		gecko.Show();
		gecko.LoadUrl("http://www.google.de");
		//Button b = new Button();
		//b.Clicked += new EventHandler(OnGoBack);
		//urlentry.KeyPressEvent += OnKeyPressed;
		
		//Handler for GeckoEvents
		gecko.OpenUri += OnOpenUri;
		//b.Show();
		
		Build ();
		//RC_Liste initialisieren
		this.rc_view.AppendColumn("Editor", new CellRendererText (), "text", 0);
		this.rc_view.AppendColumn("Artikel", new CellRendererText (), "text", 1);
		this.rc_view.AppendColumn("Diff", new CellRendererText (), "text", 2);
		this.rc_view.AppendColumn("Begründung", new CellRendererText (), "text", 3);
		ListStore store = new ListStore (typeof (string),typeof (string), typeof (int),typeof(string));
               for (int i= 100;i>1;i--){
               store.AppendValues ("127.0.0.1","Spielwiese",+9121,"blödsin");
                store.AppendValues ("C-M","Allgemeine Relativitätstheorie",-1231,"revert Vandalismus");
                }
                this.rc_view.Model = store;
		
		//Browser initialisieren
        this.urlentry.InsertText(0,gecko.Location);
		this.geckobox.Add(gecko);
		this.history_treeview.AppendColumn("Verglich", new Gtk.CellRendererToggle(), "text", 0);
		this.history_treeview.AppendColumn("", new Gtk.CellRendererToggle(), "text", 0);
		this.history_treeview.AppendColumn("Revert", new Gtk.CellRendererToggle(), "text", 0);
		this.history_treeview.AppendColumn("Datum/Uhrzeit", new CellRendererText (), "text", 0);
		this.history_treeview.AppendColumn("Verglich", new CellRendererText (), "text", 0);
		this.history_treeview.AppendColumn("Benutzer", new CellRendererText (), "text", 0);
		this.history_treeview.AppendColumn("Kommentar", new CellRendererText (), "text", 0);
		
		ListStore history_store = new ListStore (typeof (Gtk.ToggleButton),typeof (Gtk.ToggleButton), typeof (Gtk.ToggleButton),typeof(string),typeof(string),typeof(string),typeof(string));

		
		this.history_treeview.Model = history_store;
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected virtual void OnGoForward(object sender, System.EventArgs e)
	{
	if (gecko.CanGoForward()) gecko.GoForward();	
	}

	protected virtual void OnGoClicked(object sender, System.EventArgs e)
	{
	
	gecko.LoadUrl(this.urlentry.ActiveText);
	
	}

	protected virtual void onBeenden(object sender, System.EventArgs e)
	{
	Application.Quit();
	}


	protected virtual void OnEditingDone(object sender, System.EventArgs e)
	{
	gecko.LoadUrl(this.urlentry.ActiveText);
	}



	protected virtual void OnGoBack(object sender, System.EventArgs e)
	{
	if (gecko.CanGoBack()) gecko.GoBack();
	}
	

	protected void OnOpenUri(object o, OpenUriArgs args )
	{
	//return false;
		
		//this.urlentry.AppendText(args.AURI);
		this.urlentry.InsertText(0,args.AURI);
		//this.urlentry.Active(0);
		//this.urlentry.ActiveText=args.AURI;
		Console.WriteLine(args.AURI);
	return;
	}

	protected virtual void OnUrlentryKeyReleaseEvent(object o, Gtk.KeyReleaseEventArgs args)
	{
	Console.WriteLine(args.Event.Key.ToString());
	if (args.Event.Key.ToString()=="Return") gecko.LoadUrl(this.urlentry.ActiveText);
	}

	protected virtual void OnEinstellungenActivated(object sender, System.EventArgs e)
	{
		OptionsDialog opt = new OptionsDialog();
	}
}