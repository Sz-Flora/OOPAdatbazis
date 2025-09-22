using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdatbazis.Services
{
    internal class TableBooks : ISqlStatements
    {
        public List<object> GetAllBooks()
        {
            List<object> result = new List<object>();

            Connect conn = new Connect("library");

            conn.Connection.Open();

            string sql = "SELECT * FROM books";

            MySqlCommand cmd = new MySqlCommand(sql, conn.Connection);

            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();

            while (dr.Read()) 
            {
                var book = new
                {
                    Id = dr.GetInt32("id"),
                    Title = dr.GetString("title"),
                    Author = dr.GetString("author"),
                    Release = dr.GetDateTime("releaseDate")
                };

                result.Add(book);
            }

            conn.Connection.Close();

            return result;
        }
    }
}
