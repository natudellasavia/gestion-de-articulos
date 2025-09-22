using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_17A
{
    public class Categoria
    {
        // ATRIBUTOS
        public int Id { get; set; }
        public string Descripcion { get; set; }

        // CONSTRUCTOR
        public Categoria() { }
          
        public Categoria(int id, string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }
    }
}
