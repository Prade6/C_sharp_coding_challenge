using Petpals.Model;
using Petpals.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petpals.Repository
{
    internal class donationrepository:Idonation
    {
        SqlConnection sqlConnection = null;
        SqlCommand sqlCommand = null;

        Pets pets = new Pets();
        public donationrepository()
        {
            sqlConnection = new SqlConnection(Udbconnect.Getconnectstring());
            sqlCommand = new SqlCommand();
        }

        public int cashdonation(string name, string type, decimal amount, DateTime dateTime, int id, string item)
        {
            int check = 0;
            try
            {
                sqlCommand.CommandText = "insert into Donations values(@name,@type,@amount,@item,@date,@sid)";
                sqlCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                sqlCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
                sqlCommand.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                sqlCommand.Parameters.Add("@item", SqlDbType.VarChar).Value = item;
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = dateTime;
                sqlCommand.Parameters.Add("@sid", SqlDbType.Int).Value = id;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                check = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return check;
        }

        public int itemdonation(string name, string type, decimal amount, DateTime dateTime, int id, string item)
        { int check = 0;
            try
            {
                sqlCommand.CommandText = "insert into Donations values(@name,@type,@amount,@item,@date,@sid)";
                sqlCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                sqlCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
                sqlCommand.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                sqlCommand.Parameters.Add("@item", SqlDbType.VarChar).Value = item;
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = dateTime;
                sqlCommand.Parameters.Add("@sid", SqlDbType.Int).Value = id;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                check = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return check;
        }
    }
}
