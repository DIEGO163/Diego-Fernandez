using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SaludoInicial(args);
            Console.WriteLine("Bienvenido");
            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();

            int edad = IngresarEdad();

            Console.Write("Ingrese su peso: ");
            string peso = Console.ReadLine();
            float peso1 = float.Parse(peso);

            Console.Write("¿Le gusta el Basquet?: ");
            bool pregunta = Console.ReadLine().ToUpper() == "SI";

            Console.Write("¿Que fecha es hoy?: ");
            string fecha = Console.ReadLine();
            DateTime fecha1 = DateTime.Parse(fecha);

            Console.Write("¿Cual es su altura?: ");
            string altura = Console.ReadLine();
            float altura1 = float.Parse(altura);

            Console.Write("¿Cual es su deporte favorito?: ");
            string deporte = Console.ReadLine();

            Console.Write("¿Cual es su juego favorito?: ");
            string pasatiempo = Console.ReadLine();

            Console.Write("¿Cual es su sueldo?: ");
            string sueldo = Console.ReadLine();
            double sueldo1 = double.Parse(sueldo);

            Console.Write("¿En que semestre esta?: ");
            string semestre = Console.ReadLine();

            var persona = new Persona
            {
                nombre = nombre,
                edad = edad,
                peso = peso1,
                esAficionadoAlFutbol = pregunta,
                fechaDeCreacionRegistro = fecha1,
                estatura = altura1,
                deporteFavorito = deporte,
                pasatiempoFavorito = pasatiempo,
                sueldoMensual = sueldo1,
                semestre = semestre
            };

            Console.WriteLine("Su información es la siguiente: ");
            Console.Write($"nombre: {persona.nombre} ");
            Console.Write($"edad: {persona.edad} ");
            Console.Write($"peso: {persona.peso} ");
            Console.Write($"¿es aficionado al futbol?: {persona.esAficionadoAlFutbol} ");
            Console.Write($"fecha De Creacion Del Registro: {persona.fechaDeCreacionRegistro} ");
            Console.Write($"altura: {persona.estatura} ");
            Console.Write($"deporte: {persona.deporteFavorito} ");
            Console.Write($"pasatiempo:{persona.pasatiempoFavorito} ");
            Console.Write($"sueldo: {persona.sueldoMensual} ");
            Console.Write($"semestre: {persona.semestre} ");
            Console.WriteLine("Gracias por participar");
            Console.ReadKey();
        }

        static void SaludoInicial(string[] args)
        {
            if (args.Length > 3)
            {
                Console.WriteLine("Hola " + args[0] + ' ' + args[1] + ' ' + args[2] + ' ' + args[3]);
            }
            else
            {
                Console.WriteLine("hola desconocido");
            }
            Console.WriteLine("¿Cómo estas?");
            var estado = Console.ReadLine();
            Console.WriteLine("mmmmm,entiendo");
            Console.ReadKey();
        }
        static int IngresarEdad()
        {
            Console.Write("Ingrese su edad: ");
            int edad1;
            while (true)
            {
                string edad = Console.ReadLine();
                if (!int.TryParse(edad, out edad1))
                {
                    Console.Write("Ingrese un valor numerico");
                }
                else
                {
                    break;
                };
            };
            return edad1;
        }

    }
}