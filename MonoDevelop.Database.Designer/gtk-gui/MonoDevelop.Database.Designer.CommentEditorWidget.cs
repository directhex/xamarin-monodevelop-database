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
    
    public partial class CommentEditorWidget {
        
        private Gtk.ScrolledWindow scrolledwindow;
        
        private Gtk.TextView textComment;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Database.Designer.CommentEditorWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Database.Designer.CommentEditorWidget";
            // Container child MonoDevelop.Database.Designer.CommentEditorWidget.Gtk.Container+ContainerChild
            this.scrolledwindow = new Gtk.ScrolledWindow();
            this.scrolledwindow.CanFocus = true;
            this.scrolledwindow.Name = "scrolledwindow";
            this.scrolledwindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow.Gtk.Container+ContainerChild
            this.textComment = new Gtk.TextView();
            this.textComment.CanFocus = true;
            this.textComment.Name = "textComment";
            this.scrolledwindow.Add(this.textComment);
            this.Add(this.scrolledwindow);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}
