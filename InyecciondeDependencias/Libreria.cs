using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace ConsoleAppDwependencyInjection
{


    internal class Libreria
    {
        public string Ruta { get; set; } = "C:\\ProgramacionVisual\\libros";
        public Collection<Libro> Libros { get; set; } = new Collection<Libro>();

        internal string Imprimir(int libroId)
        {
            if (Libros.Any(actual => actual.LibroId == libroId))
            {

                var libro = Libros.Single(actual => actual.LibroId == libroId);
                var archivo = $"{Ruta}\\{libro.Titulo.Replace{" ", string.Empty}}.txt";
                FileStream fileStream = File.Create(archivo);
                var contenido = $"Id: {libro.LibroId}\nTitulo: {libro.Titulo"}\nAutor: {libro.Titulo}";
                byte[] buffer = Enconding.UTF8.GetBytes(contenido);
                FileStream.Write(buffer);
                fileStream.Flush();
                filestream.Close();
                return archivo;
            }

            return "No existe el Libro";
        }
    }







}