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

    class Node
    {
        List<Node> children;
        public List<Node> Children
        {
            get { return children; }
        }

        public Node()
        {
            children = new List<Node>();
        }

        public void AddChild(Node child)
        {
            children.Add(child);
        }

        public void RemoveChild(Node child)
        {
            children.Remove(child);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int numberOfVertices = Int32.Parse(input[0]);
            int numberOfEdges = Int32.Parse(input[1]);
            Edge[] edges = new Edge[numberOfEdges];

            for (int i = 0; i < numberOfEdges; i++)
            {
                input = Console.ReadLine().Split(' ');
                edges[i] = new Edge(Int32.Parse(input[0]), Int32.Parse(input[1]));
            }
        }
    }
}
