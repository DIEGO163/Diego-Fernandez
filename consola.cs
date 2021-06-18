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
            Console.Write("Ingrese su telefono: ");
            int telefono = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su estado civil: ");
            var estadocivil = Console.ReadLine();
            Console.Write("Digite su numero de cuenta: ");
            int numerocuenta = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su Color favorito: ");
            var colorfavorito = Console.ReadLine();
            Console.Write("Ingrese su tipo de sangre: ");
            var sangre = Console.ReadLine();
             Console.Write("Ingrese su nacionalidad: ");
            var nacionalidad = Console.ReadLine();
             Console.Write("Ingrese su nivel de instruccion: ");
            var instruccion = Console.ReadLine();


            var persona = new Persona();
            persona.nombre = nombre;
            persona.edad = edad1; 
            persona.peso  = peso; 
            persona.telefono = telefono;
            persona.estadocivil = estadocivil;
            persona.numerocuenta = numerocuenta;
            persona.colorfavorito = colorfavorito;
            persona.sangre = sangre;
            persona.nacionalidad = nacionalidad;
            persona.instruccion = instruccion;

            Console.WriteLine("Usted ingreso lo siguiente: ");
            Console.WriteLine("Nombre: "+ persona.nombre);
            Console.Write("edad: "+persona.edad +"\n");
            Console.Write("peso: "+persona.peso + "\n");
            Console.Write("telefono: "+persona.telefono+"\n");
            Console.WriteLine("su estado civil es: "+persona.estadocivil);
            Console.Write("su numero de cuenta es: "+persona.numerocuenta+"\n");
            Console.WriteLine("color favorito: "+ persona.colorfavorito);
            Console.WriteLine("tipo de sangre: "+ persona.sangre); 
            Console.WriteLine("su Nacionalidad es: "+ persona.nacionalidad);
            Console.WriteLine("su nivel de instruccion es: "+ persona.instruccion+"\n\n");


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