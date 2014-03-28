using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;

namespace JointChatApp
{
    class DBConnect
    {
        private MySqlConnection connection;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.Write("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.Write("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(string sID, string rID, string passphrase)
        {

            string query = "INSERT INTO keystore(sID,rID,passphrase) VALUES(@val1,@val2,@val3)";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@val1", sID);
                cmd.Parameters.AddWithValue("@val2", rID);
                cmd.Parameters.AddWithValue("@val3", passphrase);
                cmd.Prepare();

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(string sID, string rID)
        {
            string query = "UPDATE keystore SET authenticated = 1 WHERE sID = @val1 AND rID = @val2";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@val1", sID);
                cmd.Parameters.AddWithValue("@val2", rID);
                cmd.Prepare();

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string sID, string rID, string passphrase)
        {
            string query = "DELETE FROM keystore where sID = @val1 AND rID = @val2 AND passphrase = @val3";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@val1", sID);
                cmd.Parameters.AddWithValue("@val2", rID);
                cmd.Parameters.AddWithValue("@val3", passphrase);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void DeleteAllFromUser(string name)
        {
            string query = "DELETE from keystore where sID = @val1 OR rID = @val1";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@val1", name);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //retrive passphrase
        public string retrievePass(string sID, string rID)
        {
            string passphrase = "";
            string query = "SELECT passphrase FROM keystore WHERE sID = @val1 AND rID = @val2";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@val1", sID);
                cmd.Parameters.AddWithValue("@val2", rID);
                cmd.Prepare();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    passphrase = (String)dataReader["passphrase"];
                }

                dataReader.Close();
                this.CloseConnection();

            }
            return passphrase;
        }

        //retrive authenticated
        public int retrieveStatus(string sID, string rID)
        {
            int status = 0;
            string query = "SELECT authenticated FROM keystore WHERE sID = @val1 AND rID = @val2";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@val1", sID);
                cmd.Parameters.AddWithValue("@val2", rID);
                cmd.Prepare();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    status = (int)dataReader["authenticated"];
                }

                dataReader.Close();
                this.CloseConnection();

            }
            return status;
        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM keystore";

            //Create a list to store the result
            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["sID"] + "");
                    list[1].Add(dataReader["rID"] + "");
                    list[2].Add(dataReader["passphrase"] + "");
                    list[3].Add(dataReader["authenticated"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM keystore";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        ////Backup
        //public void Backup()
        //{
        //    try
        //    {
        //        DateTime Time = DateTime.Now;
        //        int year = Time.Year;
        //        int month = Time.Month;
        //        int day = Time.Day;
        //        int hour = Time.Hour;
        //        int minute = Time.Minute;
        //        int second = Time.Second;
        //        int millisecond = Time.Millisecond;

        //        //Save file to C:\ with the current date as a filename
        //        string path;
        //        path = "C:\\MySqlBackup" + year + "-" + month + "-" + day +
        //    "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
        //        StreamWriter file = new StreamWriter(path);


        //        ProcessStartInfo psi = new ProcessStartInfo();
        //        psi.FileName = "mysqldump";
        //        psi.RedirectStandardInput = false;
        //        psi.RedirectStandardOutput = true;
        //        psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
        //            uid, password, server, database);
        //        psi.UseShellExecute = false;

        //        Process process = Process.Start(psi);

        //        string output;
        //        output = process.StandardOutput.ReadToEnd();
        //        file.WriteLine(output);
        //        process.WaitForExit();
        //        file.Close();
        //        process.Close();
        //    }
        //    catch (IOException ex)
        //    {
        //        Console.Write(ex.Message);
        //    }
        //}

        ////Restore
        //public void Restore()
        //{
        //    try
        //    {
        //        //Read file from C:\
        //        string path;
        //        path = "C:\\MySqlBackup.sql";
        //        StreamReader file = new StreamReader(path);
        //        string input = file.ReadToEnd();
        //        file.Close();

        //        ProcessStartInfo psi = new ProcessStartInfo();
        //        psi.FileName = "mysql";
        //        psi.RedirectStandardInput = true;
        //        psi.RedirectStandardOutput = false;
        //        psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
        //            uid, password, server, database);
        //        psi.UseShellExecute = false;


        //        Process process = Process.Start(psi);
        //        process.StandardInput.WriteLine(input);
        //        process.StandardInput.Close();
        //        process.WaitForExit();
        //        process.Close();
        //    }
        //    catch (IOException ex)
        //    {
        //        Console.Write(ex.Message);
        //    }
        //}
    }
}
