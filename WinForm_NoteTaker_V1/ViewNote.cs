using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        }

        private void ViewNote_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=./NoteTakerDB.sqlite3");
            conn.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT Title, Detail FROM Note WHERE Title = @title", conn);
            command.Parameters.AddWithValue("title", NoteTaker.dbTitle);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine(NoteTaker.dbTitle);

                    Console.WriteLine("{0}", reader.GetString(1));
                    NoteTaker.dbDetail = reader.GetString(1);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
            conn.Close();

            ViewTitle.Text = NoteTaker.dbTitle;
            ViewDetail.Text = NoteTaker.dbDetail;
        }

            public void UpdateBtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=./NoteTakerDB.sqlite3");
            conn.Open();
            string update = "UPDATE Note SET Title = @Title, Detail = @Detail WHERE Title = @dbTitle";
            SQLiteCommand command = new SQLiteCommand(update, conn);
            command.Parameters.AddWithValue("dbtitle", NoteTaker.dbTitle);
            command.Parameters.AddWithValue("Detail", ViewDetail.Text);
            command.Parameters.AddWithValue("Title", ViewTitle.Text);
            command.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Entry Saved");
            MessageBox.Show("Entry has been saved");

            Navigation.BackNav(this);
        }

        public void BackBtn_Click(object sender, EventArgs e)
        {
            Navigation.BackNav(this);
        }

        public void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
