using Petpals.Model;
using Petpals.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Petpals.Repository
{
    internal class petshelterrepository:Ipetshelterrepository
    {
        SqlConnection sqlConnection = null;
        SqlCommand sqlCommand = null;

        Pets pets = new Pets();
        public petshelterrepository()
        {
            sqlConnection=new SqlConnection(Udbconnect.Getconnectstring());
            sqlCommand = new SqlCommand();
        }

       public int addpet(Pets pets)
        {
            int check = 0;
            try
            {
                sqlCommand.CommandText = "insert into pets values(@name,@age,@breed,@type,@available,@id)";
                sqlCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = pets.Name;
                sqlCommand.Parameters.Add("@age", SqlDbType.VarChar).Value = pets.Age;
                sqlCommand.Parameters.Add("@breed", SqlDbType.VarChar).Value = pets.Breed;
                sqlCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = pets.Type;
                sqlCommand.Parameters.Add("@available", SqlDbType.VarChar).Value = pets.Available;
                sqlCommand.Parameters.Add("@id", SqlDbType.VarChar).Value = pets.Owner_id;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                check = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
      
            return check;
        }

        public int removepet(int id)
        {
            int check = 0;
            try
            {
                sqlCommand.CommandText = "delete from pets where petid=@id";
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        public List<Pets> getpet( )
        {               
            List<Pets> pets = new List<Pets>();
            try
            {
                sqlCommand.CommandText = "Select * from Pets";
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                int i = 0;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    Pets pets1 = new Pets();
                    pets1.Name = (string)reader["Name"];
                    pets1.Age = (int)reader["Age"];
                    pets1.Breed = (string)reader["Breed"];
                    pets1.Type = (string)reader["Type"];
                    pets1.Available = (int)reader["Availableforadoption"];
                    pets1.Owner_id = (int)reader["Owner_id"];
                    pets.Add(pets1);
                }
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        
            return pets ;

        }

        public List<Pets> getavailablepet(int available)
        {
            List<Pets> pets = new List<Pets>();
            try
            {
                sqlCommand.CommandText = "Select * from Pets where availableforadoption=@available";
                sqlCommand.Parameters.Add("@available", SqlDbType.Int).Value = available;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                int i = 0;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    Pets pets1 = new Pets();
                    pets1.Name = (string)reader["Name"];
                    pets1.Age = (int)reader["Age"];
                    pets1.Breed = (string)reader["Breed"];
                    pets1.Type = (string)reader["Type"];
                    pets1.Available = (int)reader["Availableforadoption"];
                    pets1.Owner_id = (int)reader["Owner_id"];
                    pets.Add(pets1);
                }
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        
            return pets;
        }
    }
}
