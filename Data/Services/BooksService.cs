using WebApi_ASA.Data.ViewModels;
using WebApi_ASA.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace WebApi_ASA.Data.Services
{
    public class BooksService
    {
        private AppDbContext _context;

        public BooksService(AppDbContext context)
        {
            _context = context;
        }

        //Metodo para guardar libro en BD

        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                Titulo = book.Titulo,
                Descripciom = book.Descripciom,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Genero,
                Autor = book.Autor,
                CoverUrl = book.CoverUrl,
                DateAdded = System.DateTime.Now
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }

        //Metodo que nos permite obtener una lista de todos los libros en BD
        public List<Book> GetAllBks() => _context.Books.ToList();

        //Metodo para Obtener libro en BD
        public Book GetBookById(int bookid) => _context.Books.FirstOrDefault(n => n.id == bookid);

        //Metodo que nos permite Editar una lista de todos los libros en BD

        public Book UpdateBookById(int bookid, BookVM book)
        {
            var _book = _context.Books.FirstOrDefault(n => n.id == bookid);

            if(_book != null)
            {
                _book.Titulo = book.Titulo;
                _book.Descripciom = book.Descripciom;
                _book.IsRead = book.IsRead;
                _book.DateRead = book.DateRead;
                _book.Rate = book.Rate;
                _book.Genero = book.Genero;
                _book.Autor = book.Autor;
                _book.CoverUrl = book.CoverUrl;
                _book.DateAdded = System.DateTime.Now;

                _context.SaveChanges();
            }
            return _book;
        }

        public void DeleteBookById(int bookid)
        {
            var _book = _context.Books.FirstOrDefault(n => n.id == bookid);

            if(_book != null)
            {
                _context.Books.Remove(_book);
                _context.SaveChanges();
            }
        }

    }
}
