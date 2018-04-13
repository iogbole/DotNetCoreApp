using System;

namespace DotNetCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new System.Collections.Generic.List<string> { "Ojo", "Ana", "Chelly" };
            Console.WriteLine();
            names.Add("Luke");
            names.Add("Ehi");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine("AppDynamics .Net Core Windows Instrumentation test");
        }
    }
}
