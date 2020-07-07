using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class BookStoreDbContex : DbContext
    {
        public BookStoreDbContex(DbContextOptions<BookStoreDbContex> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

    }
}
