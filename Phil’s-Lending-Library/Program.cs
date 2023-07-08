using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phil_s_Lending_Library
{ 

class Program
    {
        static void Main(string[] args)
        {
            Library NewLibrary = new Library();
            NewLibrary.Add("One", "Odai", "Al-Obeidat", 5);
            NewLibrary.Add("Two", "Qusai", "Al-Obeidat", 4);
            NewLibrary.Add("Three", "Ahmad", "Al-Obeidat", 4);
            Console.WriteLine();
            Console.WriteLine("The Books was add to the library:");
            foreach (Book book in NewLibrary)
            {
                Console.WriteLine(book.Title);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            Backpack<Book> NewLibraryBackpack = new Backpack<Book>();
            Console.WriteLine("choose one book to Borrow!");
            string bookx = Console.ReadLine();
            NewLibraryBackpack.Pack(NewLibrary.Borrow(bookx));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The Library after the Borrow");

            foreach (Book book in NewLibrary)
            {
                Console.WriteLine(book.Title);
            }
            Console.WriteLine();
        }
    }

}