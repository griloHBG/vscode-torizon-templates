
//------------------------------------------------------------------------------

//  <auto-generated>
//      This code was generated by:
//        TerminalGuiDesigner v1.0.24.0
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// -----------------------------------------------------------------------------
namespace tui {
    using System;
    using Terminal.Gui;
    
    
    public partial class Tui : Terminal.Gui.Window {
        
        public Terminal.Gui.FrameView frameView;
        
        public Terminal.Gui.ScrollView scrollBarView;
        
        public Terminal.Gui.ListView listView;
        
        public Terminal.Gui.FrameView frameView2;
        
        public Terminal.Gui.ScrollView scrollBarView2;
        
        public Terminal.Gui.Label label;
        
        public Terminal.Gui.Label label2;
        
        public Terminal.Gui.Label label3;
        
        public Terminal.Gui.Label label4;
        
        public Terminal.Gui.Label label5;
        
        public Terminal.Gui.FrameView frameView3;
        
        public Terminal.Gui.TextValidateField textValidateField;
        
        public Terminal.Gui.FrameView frameView4;
        
        public Terminal.Gui.TextValidateField textValidateField2;
        
        public Terminal.Gui.Button button;
        
        public Terminal.Gui.Button button2;
        
        public void InitializeComponent() {
            this.button2 = new Terminal.Gui.Button();
            this.button = new Terminal.Gui.Button();
            this.textValidateField2 = new Terminal.Gui.TextValidateField();
            this.frameView4 = new Terminal.Gui.FrameView();
            this.textValidateField = new Terminal.Gui.TextValidateField();
            this.frameView3 = new Terminal.Gui.FrameView();
            this.label5 = new Terminal.Gui.Label();
            this.label4 = new Terminal.Gui.Label();
            this.label3 = new Terminal.Gui.Label();
            this.label2 = new Terminal.Gui.Label();
            this.label = new Terminal.Gui.Label();
            this.scrollBarView2 = new Terminal.Gui.ScrollView();
            this.frameView2 = new Terminal.Gui.FrameView();
            this.listView = new Terminal.Gui.ListView();
            this.scrollBarView = new Terminal.Gui.ScrollView();
            this.frameView = new Terminal.Gui.FrameView();
            this.Width = Dim.Fill(0);
            this.Height = Dim.Fill(0);
            this.X = 0;
            this.Y = 0;
            this.Modal = false;
            this.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
            this.Border.BorderBrush = Terminal.Gui.Color.White;
            this.Border.Effect3D = false;
            this.Border.Effect3DBrush = null;
            this.Border.DrawMarginFrame = true;
            this.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Title = "";
            this.frameView.Width = Dim.Percent(30f);
            this.frameView.Height = Dim.Fill(0);
            this.frameView.X = 0;
            this.frameView.Y = 0;
            this.frameView.Data = "frameView";
            this.frameView.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
            this.frameView.Border.BorderBrush = Terminal.Gui.Color.White;
            this.frameView.Border.Effect3D = false;
            this.frameView.Border.Effect3DBrush = null;
            this.frameView.Border.DrawMarginFrame = true;
            this.frameView.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.frameView.Title = "Select a Template";
            this.Add(this.frameView);
            this.scrollBarView.Width = Dim.Fill(0);
            this.scrollBarView.Height = Dim.Fill(0);
            this.scrollBarView.X = 0;
            this.scrollBarView.Y = 0;
            this.scrollBarView.ContentSize = new Size(0,0);
            this.scrollBarView.Data = "scrollBarView";
            this.scrollBarView.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.frameView.Add(this.scrollBarView);
            this.listView.Width = Dim.Fill(0);
            this.listView.Height = Dim.Fill(0);
            this.listView.X = 0;
            this.listView.Y = 0;
            this.listView.Data = "listView";
            this.listView.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.listView.Source = new Terminal.Gui.ListWrapper(new string[] {
                        "Item1",
                        "Item2",
                        "Item3"});
            this.listView.AllowsMarking = false;
            this.listView.AllowsMultipleSelection = false;
            this.scrollBarView.Add(this.listView);
            this.frameView2.Width = Dim.Fill(0);
            this.frameView2.Height = Dim.Fill(0);
            this.frameView2.X = 39;
            this.frameView2.Y = 0;
            this.frameView2.Data = "frameView2";
            this.frameView2.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
            this.frameView2.Border.BorderBrush = Terminal.Gui.Color.White;
            this.frameView2.Border.Effect3D = false;
            this.frameView2.Border.Effect3DBrush = null;
            this.frameView2.Border.DrawMarginFrame = true;
            this.frameView2.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.frameView2.Title = "Create from Template";
            this.Add(this.frameView2);
            this.scrollBarView2.Width = Dim.Fill(0);
            this.scrollBarView2.Height = Dim.Fill(0);
            this.scrollBarView2.X = 0;
            this.scrollBarView2.Y = 0;
            this.scrollBarView2.ContentSize = new Size(0,0);
            this.scrollBarView2.Data = "scrollBarView2";
            this.scrollBarView2.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.frameView2.Add(this.scrollBarView2);
            this.label.Width = Dim.Fill(0);
            this.label.Height = 0;
            this.label.X = 2;
            this.label.Y = 1;
            this.label.Data = "label";
            this.label.Text = "Template: ";
            this.label.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.scrollBarView2.Add(this.label);
            this.label2.Width = Dim.Fill(0);
            this.label2.Height = 0;
            this.label2.X = Pos.Left(label);
            this.label2.Y = 2;
            this.label2.Data = "label2";
            this.label2.Text = "Description:";
            this.label2.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.scrollBarView2.Add(this.label2);
            this.label3.Width = Dim.Fill(0);
            this.label3.Height = 1;
            this.label3.X = Pos.Left(label2);
            this.label3.Y = 3;
            this.label3.Data = "label3";
            this.label3.Text = "Language:";
            this.label3.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.scrollBarView2.Add(this.label3);
            this.label4.Width = Dim.Fill(0);
            this.label4.Height = 1;
            this.label4.X = Pos.Left(label2);
            this.label4.Y = 4;
            this.label4.Data = "label4";
            this.label4.Text = "Runtime:";
            this.label4.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.scrollBarView2.Add(this.label4);
            this.label5.Width = Dim.Fill(0);
            this.label5.Height = 1;
            this.label5.X = Pos.Left(label2);
            this.label5.Y = 5;
            this.label5.Data = "label5";
            this.label5.Text = "Maintainer:";
            this.label5.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.scrollBarView2.Add(this.label5);
            this.frameView3.Width = Dim.Fill(0);
            this.frameView3.Height = 3;
            this.frameView3.X = 2;
            this.frameView3.Y = 7;
            this.frameView3.Data = "frameView3";
            this.frameView3.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
            this.frameView3.Border.BorderBrush = Terminal.Gui.Color.White;
            this.frameView3.Border.Effect3D = false;
            this.frameView3.Border.Effect3DBrush = null;
            this.frameView3.Border.DrawMarginFrame = true;
            this.frameView3.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.frameView3.Title = "Project Name:";
            this.scrollBarView2.Add(this.frameView3);
            this.textValidateField.Width = Dim.Fill(0);
            this.textValidateField.Height = 1;
            this.textValidateField.X = 0;
            this.textValidateField.Y = 0;
            this.textValidateField.Provider = new Terminal.Gui.TextValidateProviders.TextRegexProvider("^[a-zA-Z][a-zA-Z0-9]*$");
            this.textValidateField.Data = "textValidateField";
            this.textValidateField.Text = "";
            this.textValidateField.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.frameView3.Add(this.textValidateField);
            this.frameView4.Width = Dim.Fill(0);
            this.frameView4.Height = 3;
            this.frameView4.X = 2;
            this.frameView4.Y = 10;
            this.frameView4.Data = "frameView4";
            this.frameView4.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
            this.frameView4.Border.BorderBrush = Terminal.Gui.Color.White;
            this.frameView4.Border.Effect3D = false;
            this.frameView4.Border.Effect3DBrush = null;
            this.frameView4.Border.DrawMarginFrame = true;
            this.frameView4.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.frameView4.Title = "Container Name:";
            this.scrollBarView2.Add(this.frameView4);
            this.textValidateField2.Width = Dim.Fill(0);
            this.textValidateField2.Height = 1;
            this.textValidateField2.X = 0;
            this.textValidateField2.Y = 0;
            this.textValidateField2.Provider = new Terminal.Gui.TextValidateProviders.TextRegexProvider("^[a-z0-9_\\-\\/]+$");
            this.textValidateField2.Data = "textValidateField2";
            this.textValidateField2.Text = "";
            this.textValidateField2.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.frameView4.Add(this.textValidateField2);
            this.button.Width = 20;
            this.button.Height = 1;
            this.button.X = 2;
            this.button.Y = 14;
            this.button.Data = "button";
            this.button.Text = "Create Projet";
            this.button.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.button.IsDefault = true;
            this.scrollBarView2.Add(this.button);
            this.button2.Width = 10;
            this.button2.Height = 1;
            this.button2.X = 23;
            this.button2.Y = 14;
            this.button2.Data = "button2";
            this.button2.Text = "Cancel";
            this.button2.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.button2.IsDefault = false;
            this.scrollBarView2.Add(this.button2);
        }
    }
}
