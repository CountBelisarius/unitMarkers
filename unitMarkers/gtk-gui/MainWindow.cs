
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Label lblName;

	private global::Gtk.Button btnCreateUnit;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(3));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblName = new global::Gtk.Label();
		this.lblName.Name = "lblName";
		this.lblName.Xalign = 0F;
		this.lblName.LabelProp = global::Mono.Unix.Catalog.GetString("Name");
		this.fixed1.Add(this.lblName);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblName]));
		w1.X = 40;
		w1.Y = 40;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnCreateUnit = new global::Gtk.Button();
		this.btnCreateUnit.CanFocus = true;
		this.btnCreateUnit.Name = "btnCreateUnit";
		this.btnCreateUnit.UseUnderline = true;
		this.btnCreateUnit.Label = global::Mono.Unix.Catalog.GetString("Create Unit");
		this.fixed1.Add(this.btnCreateUnit);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnCreateUnit]));
		w2.X = 40;
		w2.Y = 203;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.btnCreateUnit.Clicked += new global::System.EventHandler(this.click);
	}
}
