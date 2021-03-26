using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchAlgorithmsGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphCreator [] graphs = new GraphCreator[2];
            graphs[0] = new UndirectedGraph();
            graphs[1] = new DirectedGraph();

            graphs.ToList().ForEach(graph => Console.WriteLine(graph.GetType().Name + " was successfully generated.\n"));
        }
    }
}
