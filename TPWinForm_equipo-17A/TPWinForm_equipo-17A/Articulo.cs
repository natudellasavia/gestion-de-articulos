﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_17A
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int idMarca { get; set; }
        public int idCategoria { get; set; }
        public decimal Precio { get; set; }

        public string ImagenUrl { get; set; }

        //Llamado a otras clases
        public Marca Marca{ get; set; }
        public Categoria Categoria{ get; set; }
        public List<Imagen> Imagenes { get; set; } = new List<Imagen>();
        
        [DisplayName("Marca")]
        public string NombreMarca
        {
            get { return Marca != null ? Marca.descripcion : ""; }
        }
        [DisplayName("Categoria")]
        public string NombreCategoria
        {
            get { return Categoria != null ? Categoria.Descripcion : ""; }
        }

        //Constructores
        public Articulo() { }
        public Articulo(int Id, string Codigo, string Nombre, string Descripcion,decimal Precio, int idMarca, int idCategoria)
        { 
            this.Id = Id;
            this.Codigo = Codigo;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Precio = Precio;
            this.idMarca = idMarca;
            this.idCategoria = idCategoria;

        }
    }

}
