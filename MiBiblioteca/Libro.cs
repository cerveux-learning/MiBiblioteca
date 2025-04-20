﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MiBiblioteca
{
    internal class Libro
    {
        private string titulo, autor, editorial;

        public Libro(string titulo, string autor, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
        }

        public string getTitulo()
        {
            return titulo;
        }
        public override string ToString()
        {
            return $"TITULO: {titulo} AUTOR: {autor} EDITORIAL: {editorial}";
        }
    }
}