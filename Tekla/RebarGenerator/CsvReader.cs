using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RebarGenerator
{
    public static class CsvReader
    {
       
        public static List<CsvVertex> Read(string filePath)
        {

            List<CsvVertex> vertices = new List<CsvVertex>();

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length ==0)             
               return vertices;
            
            string[] headers = lines[0].Split(',');

            Dictionary<string, int> headerMap = new Dictionary<string, int>();

            for (int i = 0; i < headers.Length; i++)                
            {
                string headerName = headers[i].Trim();
                headerMap[headerName] = i;
            }

            foreach (string line in lines.Skip(1))
            { 
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split(',');

                CsvVertex vertex = new CsvVertex
                {
                    LinkID = parts[headerMap["LinkID"]].Trim(),
                    VertexNo = int.Parse(parts[headerMap["VertexNo"]].Trim()),
                    X = double.Parse(parts[headerMap["X"]].Trim(), CultureInfo.InvariantCulture),
                    Y = double.Parse(parts[headerMap["Y"]].Trim(), CultureInfo.InvariantCulture),
                    Z = double.Parse(parts[headerMap["Z"]].Trim(), CultureInfo.InvariantCulture)
                };

                vertices.Add(vertex);
            }

            return vertices;
        }
    }
}