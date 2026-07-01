using System;
using System.Collections.Generic;

namespace RebarGenerator
{
    public static class CsvReaderExample        
    {
        public static void Run()
        {
            string csvPath = @"D:\OneDrive\#N101\2. Working\#Girder and Tendon Model Update\Rebar Model Update\9a_link.csv";

            List<CsvVertex> vertices = CsvReader.Read(csvPath);

            foreach (CsvVertex v in vertices)
            {
                Console.WriteLine($"{v.LinkID} | {v.VertexNo} | X:{v.X} Y:{v.Y} Z:{v.Z}");            
            }

            Console.WriteLine($"Total Vertices: {vertices.Count}");

        }
        

    }
    
}
