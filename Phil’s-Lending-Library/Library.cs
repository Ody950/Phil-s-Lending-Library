using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Phil_s_Lending_Library
{
    public class Library : ILibrary
    {
        private Dictionary<string, Book> BookList = new Dictionary<string, Book>();

        public int Count { get; set; }
        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            Book NewBook = new Book(title, firstName, lastName, numberOfPages);
            BookList.Add(title, NewBook);
            Count++;
        }

        public Book Borrow(string title)
        {
        
        if(BookList.ContainsKey(title))
            {

                Book Thebook = BookList[title];
                BookList.Remove(title);
                Count--;
                return Thebook;
            }
            else return null;
        }

       public void Return(Book book)
        {
            BookList.Add(book.Title, book);
            Count++;
        }



        //is an implementation of the IEnumerable<Book> interface
        public IEnumerator<Book> GetEnumerator()
        {
            foreach (Book book in BookList.Values)
            {
                yield return book;
            }
        }

        // implementation of the non-generic IEnumerable interface.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        

       



    }
}
