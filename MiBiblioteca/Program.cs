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
                bool pude;
                for (i = 1; i <= cantidad; i++)
                {
                    pude = biblioteca.agregarLibro("Libro" + i, "Autor" + i, "Editorial" + i);
                    if (pude)
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



        }
    }
}