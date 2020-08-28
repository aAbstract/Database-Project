using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_project
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            bool debug_mode = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        start:
            if (debug_mode)
            {
                Application.Run(new main("super_user:0"));
            }
            else
            {
                Form1 login_page = new Form1();
                Application.Run(login_page);
                string login_string = login_page.login_string;
                login_page = null;
                if (login_string != string.Empty)
                {

                    main main_wind = new main(login_string);
                    Application.Run(main_wind);
                    if (main_wind.is_lggedout)
                    {
                        goto start;
                    }
                }
            }
        }
    }
}