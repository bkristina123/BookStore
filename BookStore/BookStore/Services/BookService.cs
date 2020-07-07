using BookStore.Data;
using BookStore.Helpers;
using BookStore.ModelDtos;
using BookStore.Repositories.Interfaces;
using BookStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepo;

        public BookService(IBookRepository bookRepo)
        {
            this.bookRepo = bookRepo;
        }

        public List<BookDto> GetAll()
        {
            var dbBooks = bookRepo.GetAll();
            return dbBooks.Select(x => x.ToBookDto()).ToList();
        }

        public Book GetById(int id)
        {
            return bookRepo.GetById(id);
        }
    }
}
