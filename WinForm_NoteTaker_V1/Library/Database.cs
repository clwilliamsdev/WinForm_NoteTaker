using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace WinForm_NoteTaker_V1.Library
{
    public class Database
    {  
        public Database()
        {            
            SQLiteConnection conn = new SQLiteConnection("Data Source=NoteTakerDB.sqlite3");

            if (!File.Exists("./NoteTakerDB.sqlite3"))
            { 
                SQLiteConnection.CreateFile("NoteTakerDB.sqlite3");
                Console.WriteLine("Database Created");
            }
            else
            {
                Console.WriteLine("db already exists");
            }
        } 
    }
}
