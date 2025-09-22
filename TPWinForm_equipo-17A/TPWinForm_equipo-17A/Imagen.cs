﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_17A
{
    public class Imagen
    {
        /// ATRIBUTOS:
        public int Id { get; set; }
        public int IdArticulo { get; set; }

        public string ImagenURL { get; set; }

        /// CONSTRUCTOR:
        public Imagen(int id, int idArticulo, string imagenURL)
        {
            Id = id;
            IdArticulo = idArticulo;
            ImagenURL = imagenURL;
        }
    }
}
