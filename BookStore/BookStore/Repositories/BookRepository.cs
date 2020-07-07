using BookStore.Data;
using BookStore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreDbContex contex;

        public BookRepository(BookStoreDbContex contex)
        {
            this.contex = contex;
        }

        public List<Book> GetAll()
        {
           return contex.Books.ToList();
        }

        public Book GetById(int id)
        {
            return contex.Books.FirstOrDefault(x => x.Id == id);
        }
    }
}
