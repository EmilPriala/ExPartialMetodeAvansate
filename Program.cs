 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPartialMetodeAvansate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            Graph graph = matrix.ToGraph();
            graph.SaveToFile("Graph.txt");

            Console.ReadKey();
        }
    }
}
