using System;
using System.Collections.Generic;
using System.Text;

namespace MiBiblioteca
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;
        
        public Biblioteca()
        {
            this.libros = new List<Libro>();
            this.lectores = new List<Lector>();
        }

        public Libro buscarLibro(string titulo)
        {
            Libro libroBuscado = null;
            int i = 0;
            while (i < libros.Count && !libros[i].getTitulo().Equals(titulo))
                i++;
            if (i != libros.Count)
                libroBuscado = libros[i];
            return libroBuscado;
        }

        public bool agregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro == null)
            {
                libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                resultado = true;
            }

            return resultado;
        }

        public void listarLibros()
        {
            foreach (var libro in libros)
                Console.WriteLine(libro);
        }

        public bool eliminarLibro(string titulo)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                resultado = true;
            }
            return resultado;
        }

        public Lector buscarLector(string dni)
        {
            Lector lector = null;
            lector = lectores.Find(lector => lector.Dni == dni);
            return lector;
        }

        public bool altaLector(string nombre, string dni) {
            bool resultado = false;

            Lector existeLector = buscarLector(dni);

            if(existeLector != null)
            {
                Console.WriteLine($"Ya existe un lector con el dni {dni}.");
                return resultado;
            }
            Lector lector = new Lector(nombre, dni);
            lectores.Add(lector);
            Console.WriteLine($"Nuevo lector {nombre} agregado con éxito.");
            resultado = true;
            return resultado;
        }

        public void listarLectores()
        {
            foreach (var lector in lectores)
            {
                Console.WriteLine(lector + "\n");
            }
        }

        public string prestarLibro(string titulo, string dni)
        {
            Libro libro = buscarLibro(titulo);
            if (libro == null) { return "LIBRO INEXISTENTE"; };

            Lector lector = buscarLector(dni);
            if (lector == null) { return "LECTOR INEXISTENTE"; };

            if (lector.Libros.Count > 2) { return "TOPE DE PRESTAMO ALCANZADO"; };

            this.libros.Remove(libro);
            lector.agregarLibro(libro);
            return "PRESTAMO EXITOSO";
        }

        public string devolucionLibro(string titulo, string dni)
        {
            Lector lector = buscarLector(dni);
            if (lector == null) { return "LECTOR INEXISTENTE"; };

            Libro libro = lector.devolverLibro(titulo);
            if (libro == null) { return "LIBRO INEXISTENTE"; };

            lector.eliminarLibro(libro);
            libros.Add(libro);

            return "LIBRO DEVUELTO CON EXITO";
        }

    }
}