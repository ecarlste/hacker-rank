using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenTree
{
    class Edge
    {
        int vertexOne;
        public int VertexOne
        {
            get { return vertexOne; }
            set { vertexOne = value; }
        }

        int vertexTwo;
        public int VertexTwo
        {
            get { return vertexTwo; }
            set { vertexTwo = value; }
        }

        public Edge(int vertexOne, int vertexTwo)
        {
            this.vertexOne = vertexOne;
            this.vertexTwo = vertexTwo;
        }
    }

    class Vertex
    {
        int key;
        public int Key
        {
            get { return key; }
            set { key = value; }
        }

        List<Vertex> connectedTo;
        public List<Vertex> ConnectedTo
        {
            get { return connectedTo; }
        }

        public Vertex(int key)
        {
            this.key = key;
            connectedTo = new List<Vertex>();
        }

        public void AddChild(Vertex child)
        {
            connectedTo.Add(child);
        }

        public void RemoveChild(Vertex child)
        {
            connectedTo.Remove(child);
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int numberOfVertices = Int32.Parse(input[0]);
            int numberOfEdges = Int32.Parse(input[1]);
            Vertex[] vertices = new Vertex[numberOfVertices];

            for (int i = 0; i < numberOfEdges; i++)
            {
                input = Console.ReadLine().Split(' ');
                Edge edge = new Edge(Int32.Parse(input[1]), Int32.Parse(input[0]));

                AddEdgeToGraph(ref vertices, edge);
            }

            int maxEdgeCuts = FindMaxEdgeCutsEvenTreeForest(vertices[0]);
            Console.WriteLine(maxEdgeCuts);
        }

        private static int FindMaxEdgeCutsEvenTreeForest(Vertex vertex)
        {
            int maxEdgeCuts = 0;

            FindTreeSizeAndPruneEdges(vertex, ref maxEdgeCuts);

            return maxEdgeCuts;
        }

        private static int FindTreeSizeAndPruneEdges(Vertex vertex, ref int edgeCutsMade)
        {
            int treeSize = 1;

            foreach (Vertex connectedTo in vertex.ConnectedTo)
            {
                int subTreeSize = FindTreeSizeAndPruneEdges(connectedTo, ref edgeCutsMade);

                if (subTreeSize % 2 == 0)
                {
                    edgeCutsMade++;
                }
                else
                {
                    treeSize += subTreeSize;
                }
            }

            return treeSize;
        }

        private static void AddEdgeToGraph(ref Vertex[] vertices, Edge edge)
        {
            if (vertices[edge.VertexOne-1] == null)
            {
                vertices[edge.VertexOne-1] = new Vertex(edge.VertexOne);
            }

            if (vertices[edge.VertexTwo-1] == null)
            {
                vertices[edge.VertexTwo-1] = new Vertex(edge.VertexTwo);
            }

            vertices[edge.VertexOne-1].AddChild(vertices[edge.VertexTwo-1]);
        }
    }
}
