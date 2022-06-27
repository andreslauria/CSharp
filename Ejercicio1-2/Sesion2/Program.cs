namespace Sesion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1

            string nombre;
            string apellido;
            int edad;
            bool sabeProgramar;

            Console.Write("Escriba su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Escriba su apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Escriba su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Usted sabe Programar: true o false");
            sabeProgramar = Convert.ToBoolean(Console.ReadLine());

            string msj = nombre + " " + apellido + "\nEdad: " + edad + "\nSabe Programar?:  " + sabeProgramar;

            Console.WriteLine(msj);

            Console.WriteLine();
            //Ejercicio 2

            //Coche
            int cantidadPuertas = 4;
            int cantRuedas = 4;
            string marca = "Ford";
            bool itvVigente = true;

            //Mesa
            int peso = 25;
            float largo = 1.80f;
            string material = "Madera";
            string color = "Blanca";

            //Ejercicio 3

            int numero1 = 15;
            char caracter = 'b';

            Console.WriteLine(numero1 >= 18);
            Console.WriteLine(caracter == 'a');
            Console.WriteLine(caracter != 'c' && numero1 < 18);
            Console.WriteLine(caracter == 'b' || numero1 > 15);

        }
    }
}