using System.Collections.Generic;

namespace WebApi_ASA.Data.Models
{
    public class Author
    {
        public int Id { get; set; } 
        public string FullName { get; set; }
        
        //Propiedades de Navegacion
        public List<Book_Author> Book_Authors { get; set; }

    }
}
