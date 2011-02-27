
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action FilterAction;

	private global::Gtk.Action LanguageAction;

	private global::Gtk.Action UserAction;

	private global::Gtk.Action SaveRatingsAsAction;

	private global::Gtk.Action SaveRatingsAnonymouslyAction;

	private global::Gtk.Action DiscardRatingsAction;

	private global::Gtk.ToggleAction OnlyShowRatedItemsAction;

	private global::Gtk.ToggleAction OnlyShowRatedMoviesAction;

	private global::Gtk.ToggleAction DoNotShowRatedMoviesAction;

	private global::Gtk.ToggleAction OnlyShow200MostPopularMoviesAction;

	private global::Gtk.Action ByGenreAction;

	private global::Gtk.ToggleAction ActionAction;

	private global::Gtk.Action TODORestByProgramAction;

	private global::Gtk.RadioAction EnglishAction;

	private global::Gtk.RadioAction DeutschAction;

	private global::Gtk.VBox vbox1;

	private global::Gtk.Entry filter_entry;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TreeView treeview1;

	private global::Gtk.MenuBar menubar1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FilterAction = new global::Gtk.Action ("FilterAction", global::Mono.Unix.Catalog.GetString ("Filter"), null, null);
		this.FilterAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Filter");
		w1.Add (this.FilterAction, null);
		this.LanguageAction = new global::Gtk.Action ("LanguageAction", global::Mono.Unix.Catalog.GetString ("Language"), null, null);
		this.LanguageAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Language");
		w1.Add (this.LanguageAction, null);
		this.UserAction = new global::Gtk.Action ("UserAction", global::Mono.Unix.Catalog.GetString ("User"), null, null);
		this.UserAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("User");
		w1.Add (this.UserAction, null);
		this.SaveRatingsAsAction = new global::Gtk.Action ("SaveRatingsAsAction", global::Mono.Unix.Catalog.GetString ("Save Ratings As ..."), null, null);
		this.SaveRatingsAsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save Ratings As ...");
		w1.Add (this.SaveRatingsAsAction, null);
		this.SaveRatingsAnonymouslyAction = new global::Gtk.Action ("SaveRatingsAnonymouslyAction", global::Mono.Unix.Catalog.GetString ("Save Ratings Anonymously"), null, null);
		this.SaveRatingsAnonymouslyAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save Ratings Anonymously");
		w1.Add (this.SaveRatingsAnonymouslyAction, null);
		this.DiscardRatingsAction = new global::Gtk.Action ("DiscardRatingsAction", global::Mono.Unix.Catalog.GetString ("Discard Ratings"), null, null);
		this.DiscardRatingsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Discard Ratings");
		w1.Add (this.DiscardRatingsAction, null);
		this.OnlyShowRatedItemsAction = new global::Gtk.ToggleAction ("OnlyShowRatedItemsAction", global::Mono.Unix.Catalog.GetString ("Only Show Rated Items"), null, null);
		this.OnlyShowRatedItemsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Only Show Rated Items");
		w1.Add (this.OnlyShowRatedItemsAction, null);
		this.OnlyShowRatedMoviesAction = new global::Gtk.ToggleAction ("OnlyShowRatedMoviesAction", global::Mono.Unix.Catalog.GetString ("Only Show Rated Movies"), null, null);
		this.OnlyShowRatedMoviesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Only Show Rated Movies");
		w1.Add (this.OnlyShowRatedMoviesAction, null);
		this.DoNotShowRatedMoviesAction = new global::Gtk.ToggleAction ("DoNotShowRatedMoviesAction", global::Mono.Unix.Catalog.GetString ("Do Not Show Rated Movies"), null, null);
		this.DoNotShowRatedMoviesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Do Not Show Rated Movies");
		w1.Add (this.DoNotShowRatedMoviesAction, null);
		this.OnlyShow200MostPopularMoviesAction = new global::Gtk.ToggleAction ("OnlyShow200MostPopularMoviesAction", global::Mono.Unix.Catalog.GetString ("Only Show 200 Most Popular Movies "), null, null);
		this.OnlyShow200MostPopularMoviesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Only Show 200 Most Popular Movies ");
		w1.Add (this.OnlyShow200MostPopularMoviesAction, null);
		this.ByGenreAction = new global::Gtk.Action ("ByGenreAction", global::Mono.Unix.Catalog.GetString ("By Genre ..."), null, null);
		this.ByGenreAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("By Genre ...");
		w1.Add (this.ByGenreAction, null);
		this.ActionAction = new global::Gtk.ToggleAction ("ActionAction", global::Mono.Unix.Catalog.GetString ("Action"), null, null);
		this.ActionAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Action");
		w1.Add (this.ActionAction, null);
		this.TODORestByProgramAction = new global::Gtk.Action ("TODORestByProgramAction", global::Mono.Unix.Catalog.GetString ("TODO: rest by program ..."), null, null);
		this.TODORestByProgramAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("TODO: rest by program ...");
		w1.Add (this.TODORestByProgramAction, null);
		this.EnglishAction = new global::Gtk.RadioAction ("EnglishAction", global::Mono.Unix.Catalog.GetString ("English"), null, null, 0);
		this.EnglishAction.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.EnglishAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("English");
		w1.Add (this.EnglishAction, null);
		this.DeutschAction = new global::Gtk.RadioAction ("DeutschAction", global::Mono.Unix.Catalog.GetString ("Deutsch"), null, null, 0);
		this.DeutschAction.Group = this.EnglishAction.Group;
		this.DeutschAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Deutsch");
		w1.Add (this.DeutschAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MyMediaLite Movie Demo");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.filter_entry = new global::Gtk.Entry ();
		this.filter_entry.CanFocus = true;
		this.filter_entry.Name = "filter_entry";
		this.filter_entry.IsEditable = true;
		this.filter_entry.InvisibleChar = '●';
		this.vbox1.Add (this.filter_entry);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.filter_entry]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.treeview1 = new global::Gtk.TreeView ();
		this.treeview1.CanFocus = true;
		this.treeview1.Name = "treeview1";
		this.GtkScrolledWindow.Add (this.treeview1);
		this.vbox1.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
		w4.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='FilterAction' action='FilterAction'><menuitem name='OnlyShowRatedMoviesAction' action='OnlyShowRatedMoviesAction'/><menuitem name='DoNotShowRatedMoviesAction' action='DoNotShowRatedMoviesAction'/><menuitem name='OnlyShow200MostPopularMoviesAction' action='OnlyShow200MostPopularMoviesAction'/><menu name='ByGenreAction' action='ByGenreAction'><menuitem name='ActionAction' action='ActionAction'/><menuitem name='TODORestByProgramAction' action='TODORestByProgramAction'/></menu></menu><menu name='LanguageAction' action='LanguageAction'><menuitem name='EnglishAction' action='EnglishAction'/><menuitem name='DeutschAction' action='DeutschAction'/></menu><menu name='UserAction' action='UserAction'><menuitem name='SaveRatingsAsAction' action='SaveRatingsAsAction'/><menuitem name='SaveRatingsAnonymouslyAction' action='SaveRatingsAnonymouslyAction'/><menuitem name='DiscardRatingsAction' action='DiscardRatingsAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add (this.menubar1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 721;
		this.DefaultHeight = 945;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.SaveRatingsAsAction.Activated += new global::System.EventHandler (this.OnSaveRatingsAsActionActivated);
		this.SaveRatingsAnonymouslyAction.Activated += new global::System.EventHandler (this.OnSaveRatingsAnonymouslyActionActivated);
		this.DiscardRatingsAction.Activated += new global::System.EventHandler (this.OnDiscardRatingsActionActivated);
		this.EnglishAction.Activated += new global::System.EventHandler (this.OnEnglishActionActivated);
		this.DeutschAction.Activated += new global::System.EventHandler (this.OnDeutschActionActivated);
	}
}
