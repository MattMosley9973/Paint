using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows;

namespace Paint
{
    class Class1
    {
        [System.STAThreadAttribute()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public static void Main()
        {
            Paint.App app = new Paint.App();
            app.InitializeComponent();
            MessageBoxResult captain = MessageBox.Show("Hello, this is your captain speaking. We are in Main! I repeat, WE ARE IN MAIN!");
            app.Run();
        }
    }
}
