// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Database.Designer {
    
    public partial class CheckConstraintEditorWidget {
        
        private Gtk.VPaned vpaned;
        
        private Gtk.HBox hbox;
        
        private Gtk.ScrolledWindow windowCheck;
        
        private Gtk.TreeView listCheck;
        
        private Gtk.VButtonBox vbuttonbox;
        
        private Gtk.Button buttonAdd;
        
        private Gtk.Button buttonRemove;
        
        private Gtk.Frame frame;
        
        private Gtk.Alignment alignment;
        
        private MonoDevelop.Database.Components.SqlEditorWidget sqlEditor;
        
        private Gtk.Label GtkLabel2;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Database.Designer.CheckConstraintEditorWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Database.Designer.CheckConstraintEditorWidget";
            // Container child MonoDevelop.Database.Designer.CheckConstraintEditorWidget.Gtk.Container+ContainerChild
            this.vpaned = new Gtk.VPaned();
            this.vpaned.CanFocus = true;
            this.vpaned.Name = "vpaned";
            this.vpaned.Position = 189;
            // Container child vpaned.Gtk.Paned+PanedChild
            this.hbox = new Gtk.HBox();
            this.hbox.Name = "hbox";
            this.hbox.Spacing = 6;
            // Container child hbox.Gtk.Box+BoxChild
            this.windowCheck = new Gtk.ScrolledWindow();
            this.windowCheck.CanFocus = true;
            this.windowCheck.Name = "windowCheck";
            this.windowCheck.ShadowType = ((Gtk.ShadowType)(1));
            // Container child windowCheck.Gtk.Container+ContainerChild
            this.listCheck = new Gtk.TreeView();
            this.listCheck.CanFocus = true;
            this.listCheck.Name = "listCheck";
            this.windowCheck.Add(this.listCheck);
            this.hbox.Add(this.windowCheck);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox[this.windowCheck]));
            w2.Position = 0;
            // Container child hbox.Gtk.Box+BoxChild
            this.vbuttonbox = new Gtk.VButtonBox();
            this.vbuttonbox.Name = "vbuttonbox";
            this.vbuttonbox.Spacing = 6;
            this.vbuttonbox.LayoutStyle = ((Gtk.ButtonBoxStyle)(3));
            // Container child vbuttonbox.Gtk.ButtonBox+ButtonBoxChild
            this.buttonAdd = new Gtk.Button();
            this.buttonAdd.CanFocus = true;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseStock = true;
            this.buttonAdd.UseUnderline = true;
            this.buttonAdd.Label = "gtk-add";
            this.vbuttonbox.Add(this.buttonAdd);
            Gtk.ButtonBox.ButtonBoxChild w3 = ((Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox[this.buttonAdd]));
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbuttonbox.Gtk.ButtonBox+ButtonBoxChild
            this.buttonRemove = new Gtk.Button();
            this.buttonRemove.Sensitive = false;
            this.buttonRemove.CanFocus = true;
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.UseStock = true;
            this.buttonRemove.UseUnderline = true;
            this.buttonRemove.Label = "gtk-remove";
            this.vbuttonbox.Add(this.buttonRemove);
            Gtk.ButtonBox.ButtonBoxChild w4 = ((Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox[this.buttonRemove]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            this.hbox.Add(this.vbuttonbox);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox[this.vbuttonbox]));
            w5.Position = 1;
            w5.Expand = false;
            w5.Fill = false;
            this.vpaned.Add(this.hbox);
            Gtk.Paned.PanedChild w6 = ((Gtk.Paned.PanedChild)(this.vpaned[this.hbox]));
            w6.Resize = false;
            // Container child vpaned.Gtk.Paned+PanedChild
            this.frame = new Gtk.Frame();
            this.frame.Name = "frame";
            this.frame.ShadowType = ((Gtk.ShadowType)(0));
            // Container child frame.Gtk.Container+ContainerChild
            this.alignment = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.alignment.Name = "alignment";
            this.alignment.LeftPadding = ((uint)(12));
            // Container child alignment.Gtk.Container+ContainerChild
            this.sqlEditor = new MonoDevelop.Database.Components.SqlEditorWidget();
            this.sqlEditor.Events = ((Gdk.EventMask)(256));
            this.sqlEditor.Name = "sqlEditor";
            this.sqlEditor.Editable = false;
            this.alignment.Add(this.sqlEditor);
            this.frame.Add(this.alignment);
            this.GtkLabel2 = new Gtk.Label();
            this.GtkLabel2.Name = "GtkLabel2";
            this.GtkLabel2.LabelProp = AddinCatalog.GetString("Check Condition");
            this.GtkLabel2.UseMarkup = true;
            this.frame.LabelWidget = this.GtkLabel2;
            this.vpaned.Add(this.frame);
            this.Add(this.vpaned);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.buttonAdd.Clicked += new System.EventHandler(this.AddClicked);
            this.buttonRemove.Clicked += new System.EventHandler(this.RemoveClicked);
        }
    }
}
