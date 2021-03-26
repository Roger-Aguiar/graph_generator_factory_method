using System.Collections.Generic;

abstract class GraphCreator
{
    private List<Graph> _graphs = new List<Graph>();

    public GraphCreator() => this.CreateGraph();

    public abstract void CreateGraph();

    public abstract string GetLayoutGraph(int [,] graph);
    
    internal List<Graph> Graphs { get => _graphs;}
}