using System.Collections.Generic;

namespace WebApi_ASA.Data.Models
{
    public class Publisher
    {

        public int Id { get; set; } 
        public string Name { get; set; }

        //Propiedades de Navegacion

        public List<Book> Book { get; set; }
    }
}
