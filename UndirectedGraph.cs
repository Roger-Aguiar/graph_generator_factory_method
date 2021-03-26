using System;

class UndirectedGraph : GraphCreator
{    
    public override void CreateGraph()
    {
        Console.WriteLine("Undirected Graph Generator\n");
        Console.Write("Enter the number of vertices: "); 
        
        int numberOfVertices = Int32.Parse(Console.ReadLine());

        int [,] graph = new int[numberOfVertices, numberOfVertices];
        
            for(int line = 0; line < graph.GetLength(0); line++)
            {
                for(int column = 0; column < graph.GetLength(1); column++)
                {                                
                    graph[line, column] = ((column == line) ? 0 : (column > line) ? new Random().Next(2) : graph[column, line]);                
                }
            }       
        Console.WriteLine(GetLayoutGraph(graph));                   
            
        Graphs.Add(new NewUndirectedGraph());
    }

    public override string GetLayoutGraph(int[,] graph)
    {
        string layout = null;
        for(int line = 0; line < graph.GetLength(0); line++)
            {
                for(int column = 0; column < graph.GetLength(1); column++)
                {
                    layout += graph[line, column] + "  ";
                }
                layout+= "\n";
            }
        return layout;
    }
}