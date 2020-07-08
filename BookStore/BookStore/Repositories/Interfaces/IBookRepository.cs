﻿using BookStore.Data;
using System.Collections.Generic;

namespace BookStore.Repositories.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetById(int id);
        List<Book> GetByAuthor(string author);
        void Create(Book book);
        void Delete(Book book);
        void Update(Book dbBook);
    }
}
