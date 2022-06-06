using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using WinForm_NoteTaker_V1.Library;





namespace WinForm_NoteTaker_V1
{
    public partial class NoteTaker : Form
    {
        public static string dbDetail;
        public static int tblPos;
        public static string dbTitle;
        public NoteTaker()
        {
            InitializeComponent();

            DbControls.DgvLoad(NoteDgv);

            //NoteDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //DataGridViewColumn column = NoteDgv.Columns[0];
            //column.Width = 156;

        }
        
        public void NoteTaker_Load(object sender, EventArgs e)
        {
            Database db = new Database();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            Navigation.NewNoteNav(this);
        }

        public void ViewBtn_Click(object sender, EventArgs e)
        {
            Navigation.ViewNoteNav(this);
        }

        public void DeleteBtn_Click(object sender, EventArgs e)
        {
            
            DbControls.DeleteNote(dbTitle);
            DbControls.DgvLoad(NoteDgv);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Navigation.ExitNav();
        }

        public void NoteDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tblPos = NoteDgv.CurrentCell.RowIndex;

            if (e.ColumnIndex == 0)
            {
                dbTitle = NoteDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                Console.WriteLine(tblPos);
                Console.WriteLine(dbTitle);
            }

        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Navigation.SettingsNav(this);
        }

        
    }
}
