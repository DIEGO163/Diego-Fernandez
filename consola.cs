using System;

namespace diegofernandez
{

    class Programcd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.Write("Ingrese su Nombre: ");
            var nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            string edad = Console.ReadLine();
            int edad1 = int.Parse(edad);
            Console.Write("Ingrese su peso: ");
            float peso = float.Parse(Console.ReadLine());
            var persona = new Persona();
            persona.nombre = nombre;
            persona.edad = edad1; 
            persona.peso  = peso; 
            Console.WriteLine("Usted ingreso lo siguiente: ");
            Console.WriteLine("Nombre: "+ persona.nombre);
            Console.Write("edad: "+persona.edad +"\n");
            Console.Write("peso: "+persona.peso + "\n\n");
            Console.Write("Muchas gracias:) \ndigite cualquier tecla para terminar.");
            Console.ReadKey();
        }
        public void Metodo(string[] args)
        {
            if (args.Length > 0)
                Console.WriteLine("Hola " + args[0]);
            else
            {
                Console.WriteLine("Hola Desconocido");

            }
            Console.WriteLine("Como Estas");
            var estado = Console.ReadLine();
            Console.WriteLine("mmmm, entiendo");
            Console.ReadLine();
        }

    }






}