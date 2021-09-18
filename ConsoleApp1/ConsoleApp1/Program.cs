using ConsoleApp1.Entities;
using ConsoleApp1.Negocio;
using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsNegocio per = new ClsNegocio();
            Persona persona = new Persona();

            persona.Usuario = "Jose";
            persona.Pass = "123";

            int valor = per.Log(persona);

            Console.WriteLine(valor);

            if (valor == 1)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine();
        }
    }
}
