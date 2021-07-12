using System;

namespace ConsoleAppDwependencyInjection
{

    class Program
    {

        static void Main(string[] args)
        {
            Libreria libreria = new Libreria();
            var libro = new Libro { LibroId = 1, Titulo = "El varon domado", Autor = "Esther Vilar" };
            libreria.Libros.Add(libro);


            libreria.Imprimir(libro.LibroId);

            Console.WriteLine(libreria.Imprimir(libro.LibroId));




        }








    }








}


