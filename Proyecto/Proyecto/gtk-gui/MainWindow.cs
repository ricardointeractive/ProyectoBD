
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Frame frame2;
	private global::Gtk.Fixed fixed2;
	private global::Gtk.Frame frame3;
	private global::Gtk.Alignment GtkAlignment;
	private global::Gtk.Button Nuevo;
	private global::Gtk.Frame frame4;
	private global::Gtk.Alignment GtkAlignment1;
	private global::Gtk.Button Exportar;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.frame2 = new global::Gtk.Frame ();
		this.frame2.Name = "frame2";
		this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame2.Gtk.Container+ContainerChild
		this.fixed2 = new global::Gtk.Fixed ();
		this.fixed2.Name = "fixed2";
		this.fixed2.HasWindow = false;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.frame3 = new global::Gtk.Frame ();
		this.frame3.WidthRequest = 100;
		this.frame3.Name = "frame3";
		this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame3.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.Nuevo = new global::Gtk.Button ();
		this.Nuevo.CanFocus = true;
		this.Nuevo.Name = "Nuevo";
		this.Nuevo.UseUnderline = true;
		this.Nuevo.Label = global::Mono.Unix.Catalog.GetString ("Nuevo");
		this.GtkAlignment.Add (this.Nuevo);
		this.frame3.Add (this.GtkAlignment);
		this.fixed2.Add (this.frame3);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.frame3]));
		w3.X = 842;
		w3.Y = 15;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.frame4 = new global::Gtk.Frame ();
		this.frame4.WidthRequest = 100;
		this.frame4.Name = "frame4";
		this.frame4.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame4.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.Exportar = new global::Gtk.Button ();
		this.Exportar.CanFocus = true;
		this.Exportar.Name = "Exportar";
		this.Exportar.UseUnderline = true;
		this.Exportar.Label = global::Mono.Unix.Catalog.GetString ("Exportar");
		this.GtkAlignment1.Add (this.Exportar);
		this.frame4.Add (this.GtkAlignment1);
		this.fixed2.Add (this.frame4);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.frame4]));
		w6.X = 750;
		w6.Y = 15;
		this.frame2.Add (this.fixed2);
		this.Add (this.frame2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 1088;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.Nuevo.Clicked += new global::System.EventHandler (this.OnNuevoClicked);
		this.Exportar.Clicked += new global::System.EventHandler (this.OnExportarClicked);
	}
}
