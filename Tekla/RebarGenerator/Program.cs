using System;
using Tekla.Structures.Model;

namespace RebarGenerator
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            CsvReaderExample.Run();
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); 
        }    
    
}
}