using System;
using System.Collections.Generic;
using System.Text;

namespace MiBiblioteca
{
    internal class Lector
    {
        private string nombre, dni;

        private List<Libro> libros;

        public Lector(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.libros = new List<Libro>();
        }
        public string Nombre { get { return nombre; } }
        public string Dni { get { return dni; } }

        public List<Libro> Libros { get { return libros; } }

        public override string ToString()
        {
            return $"NOMBRE: {nombre}\nDNI: {dni}\nLIBROS: \n   {string.Join("\n    ", libros)}";
        }

        public void agregarLibro(Libro libro)
        {
             libros.Add(libro);
        }

        public void eliminarLibro(Libro libro)
        {
            libros.Remove(libro);
        }

        public Libro devolverLibro(string titulo)
        {
            Libro libro = null;
            libro = libros.Find(libro => libro.getTitulo() == titulo);
            return libro;
        }
    }
}