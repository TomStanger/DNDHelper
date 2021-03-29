using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonMasterHelper
{
    public class Sqlmanagement
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DungeonMasterDB.mdf;Integrated Security=True;Connect Timeout=60";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public SqlDataReader Start(string cmd)
        {
            // Starts the connection to the database
            this.connection = new SqlConnection(connectionString);
            // This runs the open connection method (In built to C#)
            this.connection.Open();
            // Creating command from data given
            this.command = new SqlCommand(cmd);
            // Attaching the command to the connection provided
            this.command.Connection = this.connection;


            //TROUBLESHOOTING
            try
            {
                this.reader = this.command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL ERROR:\n" + ex.Message);
                return null;
            }

            return this.reader;
        }

        public void Close()
        {
            // Check if the READER is on or not,
            if (reader != null)
            {
                // if it's on, turn it off.
                reader.Close();
            }

            // Compare the state of the current CONNECTION set to open
            if (connection.State == System.Data.ConnectionState.Open)
            {
                // if it is, turn it off.
                this.connection.Close();
            }
        }
    }

}

