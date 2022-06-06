using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_NoteTaker_V1.Library;

namespace WinForm_NoteTaker_V1
{
    public partial class NewNote : Form
    {
        public NewNote()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            DbControls.SaveNote(NewTitleEntry.Text, NewDetailEntry.Text);

            NewDetailEntry.Clear();
            NewTitleEntry.Clear();

            Navigation.BackNav(this);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Navigation.BackNav(this);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Navigation.ExitNav();
        }
    }
}
