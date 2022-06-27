

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribir su nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("\nHola " + name);

            DateTime horaDePc = DateTime.Now;
            Console.Write("\nLa hora actual es: ");
            Console.WriteLine(horaDePc.Hour + ":" + horaDePc.Minute + ":" + horaDePc.Second);

            
        }
    }
}