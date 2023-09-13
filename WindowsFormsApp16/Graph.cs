using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
    public class Graph
    {
        private Dictionary<string, Dictionary<string, int>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<string, Dictionary<string, int>>();
        }

        public void AddEdge(string source, string destination, int weight)
        {
            if (!adjacencyList.ContainsKey(source))
            {
                adjacencyList[source] = new Dictionary<string, int>();
            }
            adjacencyList[source][destination] = weight;

            if (!adjacencyList.ContainsKey(destination))
            {
                adjacencyList[destination] = new Dictionary<string, int>();
            }
            adjacencyList[destination][source] = weight;
        }

        public IEnumerable<string> GetVertices()
        {
            return adjacencyList.Keys;
        }

        public IEnumerable<string> GetNeighbors(string vertex)
        {
            if (adjacencyList.ContainsKey(vertex))
            {
                return adjacencyList[vertex].Keys;
            }
            return new List<string>();
        }

        public int GetEdgeWeight(string source, string destination)
        {
            if (adjacencyList.ContainsKey(source) && adjacencyList[source].ContainsKey(destination))
            {
                return adjacencyList[source][destination];
            }
            return int.MaxValue; // Return a large value for non-existent edges or disconnected vertices
        }



    }
}
