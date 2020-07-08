using BookStore.Data;
using BookStore.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreDbContex contex;

        public BookRepository(BookStoreDbContex contex)
        {
            this.contex = contex;
        }

        public void Create(Book book)
        {
            contex.Books.Add(book);
            contex.SaveChanges();
        }

        public void Delete(Book book)
        {
            contex.Books.Remove(book);
            contex.SaveChanges();
        }

        public List<Book> GetAll()
        {
           return contex.Books.ToList();
        }

        public List<Book> GetByAuthor(string author)
        {
            return contex.Books.Where(x => x.Author == author).ToList();
        }

        public Book GetById(int id)
        {
            return contex.Books.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Book dbBook)
        {
            contex.Books.Update(dbBook);
            contex.SaveChanges();
        }
    }
}
