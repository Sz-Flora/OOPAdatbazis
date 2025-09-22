using OOPAdatbazis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdatbazis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISqlStatements sqlStatements = new TableBooks();

            foreach (var item in sqlStatements.GetAllBooks())
            {
                var book = item.GetType().GetProperties();
                Console.WriteLine($"{book[0].Name} = {book[0].GetValue(item)}, {book[1].Name}={book[1].GetValue(item)}");
            }
            Console.ReadKey();
        }
    }
}
