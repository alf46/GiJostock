using AFPrinting.Report;
using GiJoStock.Frm;
using System;
using System.Windows.Forms;

namespace GiJoStock
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //    var userRepo = new UserRepository();
            //    var user = userRepo.Get(1);

            //var re = new Repository<Invoice>();
            //var inv = re.Get(3);
            //ReportManager.RunInvoice(inv);


            //var entryRepo = new Repository<Invoice>();
            //var entry = entryRepo.Get(7);

            //ReportManager.RunInvoice(entry);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}