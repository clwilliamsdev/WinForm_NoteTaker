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
    public partial class ViewNote : Form
    {
        public  ViewNote()
        {
            InitializeComponent();
            DbControls.NoteDisp(NoteTaker.dbTitle);
            ViewTitle.Text = NoteTaker.dbTitle;
            ViewDetail.Text = NoteTaker.dbDetail;
        }

        public void UpdateBtn_Click(object sender, EventArgs e)
        {
            DbControls.UpdateNote(ViewTitle.Text, ViewDetail.Text, NoteTaker.dbTitle);

            Navigation.BackNav(this);
        }

        public void BackBtn_Click(object sender, EventArgs e)
        {
            Navigation.BackNav(this);
        }

        public void ExitBtn_Click(object sender, EventArgs e)
        {
            Navigation.ExitNav();
        }
    }
}
