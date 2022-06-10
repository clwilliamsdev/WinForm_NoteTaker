using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_NoteTaker_V1.Library
{
    public class Navigation
    {
        
        public static void BackNav(object page)
        {
            ((Control)page).Hide();
            NoteTaker nt = new NoteTaker();
            nt.ShowDialog();
        }
        public static void NewNoteNav(object page)
        {
            ((Control)page).Hide();
            NewNote nt = new NewNote();
            nt.ShowDialog();
        }
        
        public static void ViewNoteNav(object page)
        {
            ((Control)page).Hide();
            ViewNote nt = new ViewNote();
            nt.ShowDialog();
        }
        public static void SettingsNav(object page)
        {
            ((Control)page).Hide();
            Settings nt = new Settings();
            nt.ShowDialog();
        }
        //    public static void ExitNav()
        //{
        //    Application.Exit();
        //}
    }
}
