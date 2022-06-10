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
        }
        
        public void NoteTaker_Load(object sender, EventArgs e)
        {
            Database db = new Database();

            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=./NoteTakerDB.sqlite3");
            conn.Open();
            string load = "SELECT Title FROM Note";
            SQLiteCommand command = new SQLiteCommand(load, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(load, conn);
            DataSet ds = new DataSet();
            ds.Reset();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            ((DataGridView)NoteDgv).DataSource = dt;
            conn.Close();

            DataGridViewColumn column = ((DataGridView)NoteDgv).Columns[0];
            column.Width = 155;
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
            DialogResult warning = MessageBox.Show("This will delete the note titled " + dbTitle + ". Do you want to proceed?", "Delete Note",
                MessageBoxButtons.YesNo);
            if (warning == DialogResult.Yes)
            {
                SQLiteConnection conn1;
                conn1 = new SQLiteConnection("Data Source=./NoteTakerDB.sqlite3");
                conn1.Open();
                string delete = "DELETE FROM Note WHERE Title = @title";
                SQLiteCommand command1 = new SQLiteCommand(delete, conn1);
                command1.Parameters.AddWithValue("title", dbTitle);
                command1.ExecuteNonQuery();
                conn1.Close();

                Console.WriteLine("Note Deleted");
                MessageBox.Show("Note has been Deleted");
            }

            
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=./NoteTakerDB.sqlite3");
            conn.Open();
            string load = "SELECT Title FROM Note";
            SQLiteCommand command = new SQLiteCommand(load, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(load, conn);
            DataSet ds = new DataSet();
            ds.Reset();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            ((DataGridView)NoteDgv).DataSource = dt;
            conn.Close();

            DataGridViewColumn column = ((DataGridView)NoteDgv).Columns[0];
            column.Width = 155;


        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Navigation.SettingsNav(this);
        }

        private void NoteDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tblPos = NoteDgv.CurrentCell.RowIndex;

            if (e.ColumnIndex == 0)
            {
                dbTitle = NoteDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                Console.WriteLine(tblPos);
                Console.WriteLine(dbTitle);
            }
        }
    }
}
