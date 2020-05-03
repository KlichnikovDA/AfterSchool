using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace AfterSchool
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DBOperations.DBConn = new SQLiteConnection("Data Source=" + DBOperations.DBPath + ";Version=3;");
            DBOperations.DBComm = new SQLiteCommand();
            DBOperations.DBComm.Connection = DBOperations.DBConn;
            if (!File.Exists(DBOperations.DBPath))
                try
                {
                    DBOperations.CreateDB();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Не удалось развернуть базу данных. Error: " + ex.Message);
                }
            Application.Run(new FormLogIn());
        }
    }
}