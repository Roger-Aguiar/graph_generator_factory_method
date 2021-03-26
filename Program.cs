using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchAlgorithmsGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphCreator [] graphs = new GraphCreator[1];
            
            Menu();

            Console.Write("\nChose one option: ");
            int option = Int32.Parse(Console.ReadLine());

            switch(option)
            {
                case 1: 
                    graphs[0] = new UndirectedGraph();
                    break;
                case 2:
                    graphs[0] = new DirectedGraph();
                    break;
            }

            Console.WriteLine(graphs[0].GetType().Name + " was successfully generated!");            
        }

        static void Menu()
        {
            Console.WriteLine("Graph Generator Options");

            Console.WriteLine("1 - Generate undirected graph: ");
            Console.WriteLine("2 - Generate directed graph");
        }
    }
}
