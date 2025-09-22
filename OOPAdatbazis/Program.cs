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
            ISqlStatements sqlStatements = new TableCars();

            //Feladat 1
            /*
            foreach (var item in sqlStatements.GetAllBooks())
            {
                var book = item.GetType().GetProperties();
                Console.WriteLine($"{book[0].Name} = {book[0].GetValue(item)}, {book[1].Name}={book[1].GetValue(item)}");
            }
            */

            //Feladat 2 
            /*
            Console.Write("Kérem a rekord id-t: ");

            var item = sqlStatements.GetById(int.Parse(Console.ReadLine()));
            var book = item.GetType().GetProperties();

            Console.WriteLine($"{book[1].Name}, {book[1].GetValue(item)}");
            */

            //Feladat 3
            /*
            Console.Write("Kérem a könyv címét: ");
            string cim = Console.ReadLine();
            Console.Write("Kérem a könyv szerzőjét: ");
            string szerzo = Console.ReadLine();
            Console.Write("Kérem a könyv kiadási dátumát: ");
            string datum = Console.ReadLine();

            var book = new
            {
                Title = cim,
                Author = szerzo,
                Release = datum,
            };

            sqlStatements.AddNewRecord(book);
            */

            //Feladat 4
            /*
            Console.Write("Kérem a törlendő rekord id-t: ");
            Console.WriteLine(sqlStatements.DeleteRecord(int.Parse(Console.ReadLine())));
            */

            //Feladat 5
            /*
            Console.Write("Kérem a könyv id-t: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Kérem a könyv címét: ");
            string cim = Console.ReadLine();
            Console.Write("Kérem a könyv szerzőjét: ");
            string szerzo = Console.ReadLine();
            Console.Write("Kérem a könyv kiadási dátumát: ");
            string datum = Console.ReadLine();

            var book = new
            {
                Title = cim,
                Author = szerzo,
                Release = datum,
            };

            Console.WriteLine(sqlStatements.UpdateRecord(id, book));
            */
            Console.Write("Márka: ");
            string marka = Console.ReadLine();
            Console.Write("Tipus: ");
            string tipus = Console.ReadLine();
            Console.Write("Dátum: ");
            string datum = Console.ReadLine();

            var car = new
            {
                Brand = marka,
                Type = tipus,
                MDate = datum,
            };

            sqlStatements.AddNewRecord(car);

            Console.ReadKey();
        }
    }
}
