using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Client_Project
{
    public class MySQL
    {
        string ServerName;
        string DataBase;
        string userid;
        string userpw;
        public MySqlDataReader rdr;
        MySqlConnection connection;

        public MySQL(string ServerName, string DataBase, string userid, string userpw)
        {
            this.ServerName = ServerName;
            this.DataBase = DataBase;
            this.userid = userid;
            this.userpw = userpw;
        }

        public Boolean DBconnection()
        {
            connection = new MySqlConnection("Server=" + ServerName + ";Database=" +DataBase +";Uid="+ userid + ";Pwd="+userpw +";");

            connection.Open();

            Boolean temp = false;

            try
            {
                temp = connection.Ping();
            }
            catch
            {
                return temp;
            }
            
            return temp;
        }

        public Boolean sql(string SQL)
        {
            Boolean connection_result = DBconnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, connection);
                cmd.ExecuteNonQuery();

                
                connection.Close();
                return true;
            }
            catch(Exception)
            {
                connection.Close();
                
                return false;
            }
        }

        public string Select_sql(string SQL)
        {
            Boolean connection_result = DBconnection();
           
            string result = "";

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, connection);
                
                rdr = cmd.ExecuteReader();

               // while(rdr.Read())
               // {
               //    result = Convert.ToString(rdr["Address"]);
               // }

               //connection.Close();

                return result;
            }
            catch(Exception )
            {
                connection.Close();
                result = "실패";
                return result;
            }
        }

    }
}
