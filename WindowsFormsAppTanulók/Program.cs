using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTanulók
{
    internal static class Program
    {
        static public FormTanuloUpdate formTanuloUpdate=null;
        static public FormTanuloDelete formTanuloDelete=null;
        static public FormTanuloInsert formTanuloInsert=null;
        static public FormNyito formNyito = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formTanuloUpdate = new FormTanuloUpdate();
            formTanuloDelete = new FormTanuloDelete();
            formTanuloInsert = new FormTanuloInsert();
            formNyito = new FormNyito();
            Application.Run(formNyito);
        }
    }
}
