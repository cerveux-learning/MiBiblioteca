using System;

namespace MiBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            cargarLibros(10);
            cargarLibros(2);
            biblioteca.listarLibros();
            biblioteca.eliminarLibro("Libro5");
            biblioteca.listarLibros();
            void cargarLibros(int cantidad)
            {
                int i;
                bool creacionExitosa = false;
                for (i = 1; i <= cantidad; i++)
                {
                    creacionExitosa = biblioteca.agregarLibro("Libro" + i, "Autor" + i, "Editorial" + i);
                    if (creacionExitosa)
                        Console.WriteLine("libro" + i + " agragado correctamente.");
                    else
                        Console.WriteLine("libro" + i + " Ya existe en la biblioteca.");
                }
            }

            biblioteca.altaLector("Diego", "31558644");
            biblioteca.altaLector("Cynthia", "35283980");
            biblioteca.altaLector("Cynthia2", "35283980");

            biblioteca.listarLectores();

            string libroInexistente = biblioteca.prestarLibro("El libro de la selva", "31558644");
            Console.WriteLine(libroInexistente); 
            string lectorInexistente = biblioteca.prestarLibro("Libro8", "31558645");
            Console.WriteLine(lectorInexistente);
            string prestamoExitoso = biblioteca.prestarLibro("Libro8", "31558644");
            Console.WriteLine(prestamoExitoso);
            string prestamoExitoso2 = biblioteca.prestarLibro("Libro7", "31558644");
            Console.WriteLine(prestamoExitoso2);
            string prestamoExitoso3 = biblioteca.prestarLibro("Libro6", "31558644");
            Console.WriteLine(prestamoExitoso3);
            string limiteAlcanzado = biblioteca.prestarLibro("Libro4", "31558644");
            Console.WriteLine(limiteAlcanzado);

            biblioteca.listarLibros();
            biblioteca.listarLectores();

            string devolucionLibro = biblioteca.devolucionLibro("Libro8", "31558644");
            Console.WriteLine(devolucionLibro);
            string devolucionSinExito = biblioteca.devolucionLibro("Libro inexistente", "31558644");
            Console.WriteLine(devolucionSinExito);
            string lectorNoRegistrado = biblioteca.devolucionLibro("Libro7", "malDNI");
            Console.WriteLine(lectorNoRegistrado);

            biblioteca.listarLibros();
            biblioteca.listarLectores();
        }
    }
}