using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class EFBookListRepository : IBookListRepository
    {
        private BookDBContext _context;
        public EFBookListRepository(BookDBContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
