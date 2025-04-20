using System;
using System.Collections.Generic;
using System.Text;

namespace MiBiblioteca
{
    internal class Lector
    {
        private string nombre, dni;

        private List<Libro> libros;

        private int prestamo;

        public Lector(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.prestamo = 0;
            this.libros = new List<Libro>();
        }
        public string Nombre { get { return nombre; } }
        public string Dni { get { return dni; } }

        public int Prestamo { get { return prestamo; } set { prestamo = value; } }
        public override string ToString()
        {
            return $"NOMBRE: {nombre}\nDNI: {dni}\nLIBROS PRESTADOS: {prestamo}";
        }
    }
}