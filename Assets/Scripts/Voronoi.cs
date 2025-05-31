using System.Collections.Generic;
using UnityEngine;

public class Voronoi
{
    public List<Edge> Edges { get; private set; }

    public Voronoi(List<Vector2> sites, Rect bounds)
    {
        Edges = GenerateVoronoi(sites, bounds);
    }

    private List<Edge> GenerateVoronoi(List<Vector2> sites, Rect bounds)
    {
        // Placeholder for actual Voronoi diagram generation logic
        // You need to implement the algorithm here

        List<Edge> edges = new List<Edge>();

        // Example of creating dummy edges (replace this with actual logic)
        foreach (var site in sites)
        {
            Vector2 start = site;
            Vector2 end = new Vector2(site.x + Random.Range(-1f, 1f), site.y + Random.Range(-1f, 1f));
            edges.Add(new Edge(start, end));
        }

        return edges;
    }
}

public class Edge
{
    public Vector2 Start { get; private set; }
    public Vector2 End { get; private set; }

    public Edge(Vector2 start, Vector2 end)
    {
        Start = start;
        End = end;
    }

    public Dictionary<string, Vector2> ClippedEnds
    {
        get
        {
            return new Dictionary<string, Vector2> { { LR.LEFT, Start }, { LR.RIGHT, End } };
        }
    }
}

public static class LR
{
    public static string LEFT = "left";
    public static string RIGHT = "right";
}
