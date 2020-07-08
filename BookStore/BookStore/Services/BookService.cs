using BookStore.Helpers;
using BookStore.ModelDtos;
using BookStore.Repositories.Interfaces;
using BookStore.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepo;

        public BookService(IBookRepository bookRepo)
        {
            this.bookRepo = bookRepo;
        }

        public void Create(BookDto book)
        {
            bookRepo.Create(book.ToBookEntity());
        }

        public void Delete(int id)
        {
            var book = bookRepo.GetById(id);

            if(book != null)
            {
                bookRepo.Delete(book);
            }
        }

        public List<BookDto> GetAll()
        {
            var dbBooks = bookRepo.GetAll();
            return dbBooks.Select(x => x.ToBookDto()).ToList();
        }

        public List<BookDto> GetByAuthor(string author)
        {
            var books = bookRepo.GetByAuthor(author);
            return books.Select(x => x.ToBookDto()).ToList();
        }

        public BookDto GetById(int id)
        {
            return bookRepo.GetById(id).ToBookDto();
        }

        public void Update(BookDto bookDto)
        {
            var dbBook = bookRepo.GetById(bookDto.Id);

            if(dbBook != null)
            {
                dbBook.Title = bookDto.Title;
                dbBook.Description = bookDto.Description;
                dbBook.Author = bookDto.Author;
                dbBook.Genre = bookDto.Genre;
                dbBook.Price = bookDto.Price;
                dbBook.Quantity = bookDto.Quantity;

                bookRepo.Update(dbBook);
            }
        }
    }
}
