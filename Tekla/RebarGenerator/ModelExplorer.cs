using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;

namespace RebarGenerator
{
    public static class ModelExplorer
    {
        public static void Run()
        {
            Model model = new Model();
            // UIApplication uiapp = commandData.Application;
            // UIDocument uidoc = uiapp.ActiveUIDocument;
            // Document doc = uidoc.Document;
            /*(Make an object classfied UIapplication and the object is the class defieind in commonData namespace. */


            if (!model.GetConnectionStatus())
            {
                Console.WriteLine("Not Coonnected.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Connected!");

            
            ModelObjectSelector selector = model.GetModelObjectSelector();
            // == FilteredElementCollector collector = new FilteredElementCollector(doc);
            ModelObjectEnumerator objects = selector.GetAllObjects();

            int count = 0;

            while (objects.MoveNext()) // == foreach(Element e in collector) {}
            /*
             MoveNext() method is used to move the enumerator to the next element in the collection. 
            It returns true if there are more elements to enumerate, and false if the end of the collection has been reached.
            */

            {
                ModelObject obj = objects.Current;
                Console.WriteLine(obj.GetType().Name);
                count++;
            }

            Console.WriteLine($"Model Object Count: {count}");
            Console.ReadKey();
        }
    }
}


