using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinForm_NoteTaker_V1.Library
{
    public partial class DbControls
    {
        public static void CreateTbl()
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=./NoteTakerDB.sqlite3");
            conn.Open();
            string tbl = "create TABLE Note (ID integer primary key AUTOINCREMENT, Title text, Detail text)";
            SQLiteCommand command = new SQLiteCommand(tbl, conn);
            command.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Table Created");
        }

        public static void DeleteTbl()
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=./NoteTakerDB.sqlite3");
            conn.Open();
            string tbl = "DROP TABLE Note ";
            SQLiteCommand command = new SQLiteCommand(tbl, conn);
            command.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Table Deleted");
            MessageBox.Show("Table has been Deleted");
        }

        public static void DeleteTblData()
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=./NoteTakerDB.sqlite3");
            conn.Open();
            string tbl = "DELETE FROM Note ";
            SQLiteCommand command = new SQLiteCommand(tbl, conn);
            command.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Table Data Deleted");
            MessageBox.Show("Table Data has been Deleted");
        }

        //public static void DBControl(string commandText)
        //{
        //    SQLiteConnection conn;
        //    conn = new SQLiteConnection("Data Source=./NoteTakerDB.sqlite3");
        //    conn.Open();
        //    SQLiteCommand command = new SQLiteCommand(commandText , conn);
        //    command.ExecuteNonQuery();
        //    conn.Close();

        //    Console.WriteLine("Entry Saved");
        //    MessageBox.Show("Entry has been saved");
        //}
        

        //public static void DgvLoad(object dgv)
        //{
        //    //SQLiteConnection conn;
        //    //conn = new SQLiteConnection("Data Source=./database.sqlite3");
        //    //conn.Open();
        //    //string load = "SELECT Title FROM Note";
        //    //SQLiteCommand command = new SQLiteCommand(load, conn);
        //    //command.ExecuteNonQuery();
        //    //conn.Close();

        //    SQLiteConnection conn;
        //    conn = new SQLiteConnection("Data Source=./NoteTakerDB.sqlite3");
        //    conn.Open();
        //    string load = "SELECT Title FROM Note";
        //    SQLiteCommand command = new SQLiteCommand(load, conn);
        //    SQLiteDataAdapter da = new SQLiteDataAdapter(load, conn);
        //    DataSet ds = new DataSet();
        //    ds.Reset();
        //    da.Fill(ds);
        //    DataTable dt = ds.Tables[0];
        //    ((DataGridView)dgv).DataSource = dt;
        //    conn.Close();

        //    DataGridViewColumn column = ((DataGridView)dgv).Columns[0];
        //    column.Width = 155;

        //    //((DataGridView)dgv).AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        //    //DataGridViewColumn column = dataGridView.Columns[0];
        //    //column.Width = 60;
        //}
        
        //public static void NoteDisp(string title)
        //{
            
        //    SQLiteConnection conn;
        //    conn = new SQLiteConnection("Data Source=./NoteTakerDB.sqlite3");
        //    conn.Open();
        //    //string load = "SELECT Title FROM Note WHERE ID = @id";
        //    SQLiteCommand command = new SQLiteCommand("SELECT Title, Detail FROM Note WHERE Title = @title", conn);
        //    command.Parameters.AddWithValue("title", title);
        //    SQLiteDataReader reader = command.ExecuteReader();
        //        if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Console.WriteLine(NoteTaker.dbTitle);
                    
        //            Console.WriteLine("{0}", reader.GetString(1));
        //            NoteTaker.dbDetail = reader.GetString(1);
        //        }

                
        //    }
        //    else
        //    {
        //        Console.WriteLine("No rows found.");
        //    }
        //    reader.Close();

            



        //    //SQLiteDataAdapter da = new SQLiteDataAdapter(load, conn);
        //    //DataSet ds = new DataSet();
        //    //ds.Reset();
        //    //da.Fill(ds);
        //    //string result = ds.Tables[0].ToString;
        //    //string result = ds.ToString;
        //    conn.Close();
        //}
    }
}
