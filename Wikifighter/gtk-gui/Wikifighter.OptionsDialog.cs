// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Wikifighter {
    
    
    public partial class OptionsDialog {
        
        private Gtk.VBox vbox3;
        
        private Gtk.Expander username_password_expander;
        
        private Gtk.Table table1;
        
        private Gtk.Entry password_entry_1;
        
        private Gtk.Entry password_entry_2;
        
        private Gtk.Label password_label;
        
        private Gtk.Entry username_entry;
        
        private Gtk.Label username_label;
        
        private Gtk.Label username_password_label;
        
        private Gtk.Expander rcconfig_expander;
        
        private Gtk.Table table2;
        
        private Gtk.Label rcconfig_label;
        
        private Gtk.Button options_help_button;
        
        private Gtk.Button options_cancel_button;
        
        private Gtk.Button options_apply_button;
        
        private Gtk.Button options_ok_button;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize();
            // Widget Wikifighter.OptionsDialog
            this.Events = ((Gdk.EventMask)(256));
            this.Name = "Wikifighter.OptionsDialog";
            this.Title = Mono.Unix.Catalog.GetString("Options");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.AllowShrink = true;
            this.HasSeparator = false;
            // Internal child Wikifighter.OptionsDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Events = ((Gdk.EventMask)(256));
            w1.Name = "dialog_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog_VBox.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            // Container child vbox3.Gtk.Box+BoxChild
            this.username_password_expander = new Gtk.Expander(null);
            this.username_password_expander.CanFocus = true;
            this.username_password_expander.Name = "username_password_expander";
            this.username_password_expander.Expanded = true;
            // Container child username_password_expander.Gtk.Container+ContainerChild
            this.table1 = new Gtk.Table(((uint)(3)), ((uint)(2)), false);
            this.table1.Name = "table1";
            // Container child table1.Gtk.Table+TableChild
            this.password_entry_1 = new Gtk.Entry();
            this.password_entry_1.CanFocus = true;
            this.password_entry_1.Name = "password_entry_1";
            this.password_entry_1.IsEditable = true;
            this.password_entry_1.Visibility = false;
            this.table1.Add(this.password_entry_1);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table1[this.password_entry_1]));
            w2.TopAttach = ((uint)(1));
            w2.BottomAttach = ((uint)(2));
            w2.LeftAttach = ((uint)(1));
            w2.RightAttach = ((uint)(2));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.password_entry_2 = new Gtk.Entry();
            this.password_entry_2.CanFocus = true;
            this.password_entry_2.Name = "password_entry_2";
            this.password_entry_2.IsEditable = true;
            this.password_entry_2.Visibility = false;
            this.table1.Add(this.password_entry_2);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table1[this.password_entry_2]));
            w3.TopAttach = ((uint)(2));
            w3.BottomAttach = ((uint)(3));
            w3.LeftAttach = ((uint)(1));
            w3.RightAttach = ((uint)(2));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.password_label = new Gtk.Label();
            this.password_label.Name = "password_label";
            this.password_label.LabelProp = Mono.Unix.Catalog.GetString("Passwort");
            this.table1.Add(this.password_label);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table1[this.password_label]));
            w4.TopAttach = ((uint)(1));
            w4.BottomAttach = ((uint)(2));
            w4.XOptions = ((Gtk.AttachOptions)(4));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.username_entry = new Gtk.Entry();
            this.username_entry.CanFocus = true;
            this.username_entry.Name = "username_entry";
            this.username_entry.IsEditable = true;
            this.table1.Add(this.username_entry);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table1[this.username_entry]));
            w5.LeftAttach = ((uint)(1));
            w5.RightAttach = ((uint)(2));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.username_label = new Gtk.Label();
            this.username_label.Name = "username_label";
            this.username_label.LabelProp = Mono.Unix.Catalog.GetString("Benutzername");
            this.table1.Add(this.username_label);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.table1[this.username_label]));
            w6.XOptions = ((Gtk.AttachOptions)(4));
            w6.YOptions = ((Gtk.AttachOptions)(4));
            this.username_password_expander.Add(this.table1);
            this.username_password_label = new Gtk.Label();
            this.username_password_label.Name = "username_password_label";
            this.username_password_label.LabelProp = Mono.Unix.Catalog.GetString("Benutzername / Passwort");
            this.username_password_label.UseUnderline = true;
            this.username_password_expander.LabelWidget = this.username_password_label;
            this.vbox3.Add(this.username_password_expander);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox3[this.username_password_expander]));
            w8.Position = 1;
            w8.Expand = false;
            w8.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.rcconfig_expander = new Gtk.Expander(null);
            this.rcconfig_expander.CanFocus = true;
            this.rcconfig_expander.Name = "rcconfig_expander";
            this.rcconfig_expander.Expanded = true;
            // Container child rcconfig_expander.Gtk.Container+ContainerChild
            this.table2 = new Gtk.Table(((uint)(2)), ((uint)(2)), false);
            this.table2.Name = "table2";
            this.rcconfig_expander.Add(this.table2);
            this.rcconfig_label = new Gtk.Label();
            this.rcconfig_label.Name = "rcconfig_label";
            this.rcconfig_label.LabelProp = Mono.Unix.Catalog.GetString("Letzte Änderungen");
            this.rcconfig_label.UseUnderline = true;
            this.rcconfig_expander.LabelWidget = this.rcconfig_label;
            this.vbox3.Add(this.rcconfig_expander);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox3[this.rcconfig_expander]));
            w10.Position = 2;
            w1.Add(this.vbox3);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(w1[this.vbox3]));
            w11.Position = 0;
            // Internal child Wikifighter.OptionsDialog.ActionArea
            Gtk.HButtonBox w12 = this.ActionArea;
            w12.Events = ((Gdk.EventMask)(256));
            w12.Name = "Wikifighter.Options_ActionArea";
            w12.Spacing = 10;
            w12.BorderWidth = ((uint)(5));
            w12.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child Wikifighter.Options_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.options_help_button = new Gtk.Button();
            this.options_help_button.CanDefault = true;
            this.options_help_button.CanFocus = true;
            this.options_help_button.Name = "options_help_button";
            this.options_help_button.UseStock = true;
            this.options_help_button.UseUnderline = true;
            this.options_help_button.Label = "gtk-help";
            this.AddActionWidget(this.options_help_button, -11);
            // Container child Wikifighter.Options_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.options_cancel_button = new Gtk.Button();
            this.options_cancel_button.CanDefault = true;
            this.options_cancel_button.CanFocus = true;
            this.options_cancel_button.Name = "options_cancel_button";
            this.options_cancel_button.UseStock = true;
            this.options_cancel_button.UseUnderline = true;
            this.options_cancel_button.Label = "gtk-cancel";
            this.AddActionWidget(this.options_cancel_button, -6);
            Gtk.ButtonBox.ButtonBoxChild w14 = ((Gtk.ButtonBox.ButtonBoxChild)(w12[this.options_cancel_button]));
            w14.Position = 1;
            w14.Expand = false;
            w14.Fill = false;
            // Container child Wikifighter.Options_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.options_apply_button = new Gtk.Button();
            this.options_apply_button.CanDefault = true;
            this.options_apply_button.CanFocus = true;
            this.options_apply_button.Name = "options_apply_button";
            this.options_apply_button.UseStock = true;
            this.options_apply_button.UseUnderline = true;
            this.options_apply_button.Label = "gtk-apply";
            this.AddActionWidget(this.options_apply_button, -10);
            Gtk.ButtonBox.ButtonBoxChild w15 = ((Gtk.ButtonBox.ButtonBoxChild)(w12[this.options_apply_button]));
            w15.Position = 2;
            w15.Expand = false;
            w15.Fill = false;
            // Container child Wikifighter.Options_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.options_ok_button = new Gtk.Button();
            this.options_ok_button.CanDefault = true;
            this.options_ok_button.CanFocus = true;
            this.options_ok_button.Name = "options_ok_button";
            this.options_ok_button.UseStock = true;
            this.options_ok_button.UseUnderline = true;
            this.options_ok_button.Label = "gtk-ok";
            this.AddActionWidget(this.options_ok_button, -5);
            Gtk.ButtonBox.ButtonBoxChild w16 = ((Gtk.ButtonBox.ButtonBoxChild)(w12[this.options_ok_button]));
            w16.Position = 3;
            w16.Expand = false;
            w16.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 521;
            this.DefaultHeight = 317;
            this.Show();
            this.options_ok_button.Clicked += new System.EventHandler(this.OnOptionsOkButtonClicked);
        }
    }
}
