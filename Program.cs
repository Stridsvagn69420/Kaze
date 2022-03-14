using System;
using Gtk;

namespace Kaze
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0) {
                GUI();
            }
        }
        [STAThread]
        public static int GUI() {
            try
            {
                Application.Init();

                var app = new Application("org.Kaze.Kaze", GLib.ApplicationFlags.None);
                app.Register(GLib.Cancellable.Current);

                var win = new MainWindow();
                app.AddWindow(win);

                win.Show();
                Application.Run();
                return 0;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return 1;
            }
        }
    }
}
