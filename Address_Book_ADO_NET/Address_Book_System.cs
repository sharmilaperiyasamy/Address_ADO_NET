using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Address_Book_ADO_NET
{
    internal class Address_Book_System
    {
        public static string connectionString = "Data Source = DESKTOP-VMLSH89\\SQLEXPRESS;Database = Address_Book_Service;Trusted_Connection=true";
        //uc2 Retrieving record from the database address_book
        public void getDataFromDB()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            Book_Definition book = new Book_Definition();
            using (connection)
            {
                connection.Open();
                string query = "Select * from Address_Book";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Console.WriteLine("PersonId|FirstName|LastName|Address|City\t|State\t|Zip\t|Phone_no\t|Email\t|name\t|Persontype");
                    while (reader.Read())
                    {
                        book.PersonId = reader.GetInt32(0);
                        book.FirstName = reader.GetString(1);
                        book.LastName = reader.GetString(2);
                        book.Address = reader.GetString(3);
                        book.City = reader.GetString(4);
                        book.State = reader.GetString(5);
                        book.Zip = reader.GetInt32(6);
                        book.Phone_no = reader.GetString(7);
                        book.Email = reader.GetString(8);
                        book.name = reader.GetString(9);
                        book.Persontype = reader.GetString(10);
                        Console.WriteLine(book.PersonId + "\t" + book.FirstName + "\t" + book.LastName + "\t" + book.Address + "\t" + book.City + "\t" +
                            book.State + "\t" + book.Zip + "\t" + book.Phone_no + "\t" + book.Email + "\t" + book.name + "\t" + book.Persontype);
                    }
                }
                else
                {
                    Console.WriteLine("No records in database.");
                }
                reader.Close();
                connection.Close();
            }
        }
    }
}
