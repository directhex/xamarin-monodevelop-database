// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Database.Sql.Npgsql {
    
    public partial class NpgsqlCreateDatabaseWidget {
        
        private Gtk.Table table1;
        
        private Gtk.ComboBoxEntry comboEncoding;
        
        private Gtk.ComboBoxEntry comboOwner;
        
        private Gtk.ComboBoxEntry comboTablespace;
        
        private Gtk.ComboBoxEntry comboTemplate;
        
        private Gtk.Label labelEncoding;
        
        private Gtk.Label labelOwner;
        
        private Gtk.Label labelTablespace;
        
        private Gtk.Label labelTemplate;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Database.Sql.Npgsql.NpgsqlCreateDatabaseWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Database.Sql.Npgsql.NpgsqlCreateDatabaseWidget";
            // Container child MonoDevelop.Database.Sql.Npgsql.NpgsqlCreateDatabaseWidget.Gtk.Container+ContainerChild
            this.table1 = new Gtk.Table(((uint)(4)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.comboEncoding = new Gtk.ComboBoxEntry();
            this.comboEncoding.Name = "comboEncoding";
            this.table1.Add(this.comboEncoding);
            Gtk.Table.TableChild w1 = ((Gtk.Table.TableChild)(this.table1[this.comboEncoding]));
            w1.TopAttach = ((uint)(2));
            w1.BottomAttach = ((uint)(3));
            w1.LeftAttach = ((uint)(1));
            w1.RightAttach = ((uint)(2));
            w1.XOptions = ((Gtk.AttachOptions)(4));
            w1.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.comboOwner = new Gtk.ComboBoxEntry();
            this.comboOwner.Name = "comboOwner";
            this.table1.Add(this.comboOwner);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table1[this.comboOwner]));
            w2.LeftAttach = ((uint)(1));
            w2.RightAttach = ((uint)(2));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.comboTablespace = new Gtk.ComboBoxEntry();
            this.comboTablespace.Name = "comboTablespace";
            this.table1.Add(this.comboTablespace);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table1[this.comboTablespace]));
            w3.TopAttach = ((uint)(3));
            w3.BottomAttach = ((uint)(4));
            w3.LeftAttach = ((uint)(1));
            w3.RightAttach = ((uint)(2));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.comboTemplate = new Gtk.ComboBoxEntry();
            this.comboTemplate.Name = "comboTemplate";
            this.table1.Add(this.comboTemplate);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table1[this.comboTemplate]));
            w4.TopAttach = ((uint)(1));
            w4.BottomAttach = ((uint)(2));
            w4.LeftAttach = ((uint)(1));
            w4.RightAttach = ((uint)(2));
            w4.XOptions = ((Gtk.AttachOptions)(4));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.labelEncoding = new Gtk.Label();
            this.labelEncoding.Name = "labelEncoding";
            this.labelEncoding.LabelProp = AddinCatalog.GetString("Encoding");
            this.table1.Add(this.labelEncoding);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table1[this.labelEncoding]));
            w5.TopAttach = ((uint)(2));
            w5.BottomAttach = ((uint)(3));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.labelOwner = new Gtk.Label();
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.LabelProp = AddinCatalog.GetString("Owner");
            this.table1.Add(this.labelOwner);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.table1[this.labelOwner]));
            w6.XOptions = ((Gtk.AttachOptions)(4));
            w6.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.labelTablespace = new Gtk.Label();
            this.labelTablespace.Name = "labelTablespace";
            this.labelTablespace.LabelProp = AddinCatalog.GetString("Tablespace");
            this.table1.Add(this.labelTablespace);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table1[this.labelTablespace]));
            w7.TopAttach = ((uint)(3));
            w7.BottomAttach = ((uint)(4));
            w7.XOptions = ((Gtk.AttachOptions)(4));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.labelTemplate = new Gtk.Label();
            this.labelTemplate.Name = "labelTemplate";
            this.labelTemplate.LabelProp = AddinCatalog.GetString("Template");
            this.table1.Add(this.labelTemplate);
            Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.table1[this.labelTemplate]));
            w8.TopAttach = ((uint)(1));
            w8.BottomAttach = ((uint)(2));
            w8.XOptions = ((Gtk.AttachOptions)(4));
            w8.YOptions = ((Gtk.AttachOptions)(4));
            this.Add(this.table1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}
