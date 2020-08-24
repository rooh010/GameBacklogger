using System;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace GameBacklogger
{
    class DataConnection
    {
        private SQLiteConnection sqlite;

        public DataConnection()
        {
            sqlite = new SQLiteConnection("Data Source=./games.db");
        }

        public DataTable selectQuery(string query)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            try
            {
                SQLiteCommand cmd;
                sqlite.Open();  //Initiate connection to the db
                cmd = sqlite.CreateCommand();
                cmd.CommandText = query;  //set the passed query
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt); //fill the datasource
            }
            catch (SQLiteException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ErrorCode.ToString() + ": " + ex.Message.ToString());
            }
            sqlite.Close();
            return dt;
        }
    }

}