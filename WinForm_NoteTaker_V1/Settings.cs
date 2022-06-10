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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void ClrDataBtn_Click(object sender, EventArgs e)
        {
            DialogResult warning = MessageBox.Show("This will delete all data in the table. Do you want to proceed?", "Delete Table Data",
                MessageBoxButtons.YesNo);
            if (warning == DialogResult.Yes)
            {
                DbControls.DeleteTblData();
                MessageBox.Show("Data has been Deleted");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Navigation.BackNav(this);
        }
    }
}
