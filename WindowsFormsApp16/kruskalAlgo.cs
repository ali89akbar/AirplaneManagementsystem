using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static WindowsFormsApp16.kruskalAlgo.Graph;

namespace WindowsFormsApp16
{
    public partial class kruskalAlgo : Form
    {
        private Graph flightGraph;
        private List<Edge> minimumSpanningTree;

        public kruskalAlgo()
        {
            InitializeComponent();

            // Initialize the flight graph and populate it with flight details
            flightGraph = new Graph();


            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.airportConnectionString))
            {
                connection.Open();

                // Retrieve data from the flight_detail table
                string query = "SELECT sources, destination, distance FROM flight_details";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Iterate over the retrieved data
                while (reader.Read())
                {
                    string sources = reader.GetString(0);
                    string destination = reader.GetString(1);
                    int distance = reader.GetInt32(2);

                    // Add edges to the flightGraph object
                    flightGraph.AddEdge(sources, destination, distance);
                }

                reader.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call Kruskal's algorithm to get the minimum spanning tree
            minimumSpanningTree = KruskalAlgorithm(flightGraph);

            // Display the minimum spanning tree in the DataGridView
            DisplayMinimumSpanningTree();
        }

        private List<Edge> KruskalAlgorithm(Graph graph)
        {
            // Create a list to store the minimum spanning tree edges
            List<Edge> minimumSpanningTree = new List<Edge>();

            // Get all the edges from the graph
            List<Edge> allEdges = graph.GetAllEdges();

            // Sort the edges in ascending order by weight
            allEdges.Sort((e1, e2) => e1.Weight.CompareTo(e2.Weight));

            // Create a union-find data structure to keep track of disjoint sets
            UnionFind<string> unionFind = new UnionFind<string>(graph.GetVertices());

            foreach (Edge edge in allEdges)
            {
                // Check if adding the edge creates a cycle in the minimum spanning tree
                if (!unionFind.AreVerticesConnected(edge.Source, edge.Destination))
                {
                    // Add the edge to the minimum spanning tree
                    minimumSpanningTree.Add(edge);

                    // Merge the sets of the vertices in the edge
                    unionFind.Union(edge.Source, edge.Destination);
                }
            }

            return minimumSpanningTree;
        }

        private void DisplayMinimumSpanningTree()
        {
            // Create a DataTable to hold the data for the DataGridView
            DataTable dt = new DataTable();
            dt.Columns.Add("Source");
            dt.Columns.Add("Destination");
            dt.Columns.Add("Weight");

            // Populate the DataTable with the minimum spanning tree data
            foreach (Edge edge in minimumSpanningTree)
            {
                DataRow row = dt.NewRow();
                row["Source"] = edge.Source;
                row["Destination"] = edge.Destination;
                row["Weight"] = edge.Weight;
                dt.Rows.Add(row);
            }

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dt;
        }

        public class Graph
        {
            private Dictionary<string, List<Edge>> adjacencyList;

            public Graph()
            {
                adjacencyList = new Dictionary<string, List<Edge>>();
            }

            public void AddEdge(string source, string destination, int weight)
            {
                Edge edge = new Edge(source, destination, weight);

                if (!adjacencyList.ContainsKey(source))
                {
                    adjacencyList[source] = new List<Edge>();
                }

                if (!adjacencyList.ContainsKey(destination))
                {
                    adjacencyList[destination] = new List<Edge>();
                }

                adjacencyList[source].Add(edge);
                adjacencyList[destination].Add(edge);
            }

            public List<string> GetVertices()
            {
                return adjacencyList.Keys.ToList();
            }

            public List<Edge> GetNeighbors(string vertex)
            {
                if (adjacencyList.ContainsKey(vertex))
                {
                    return adjacencyList[vertex];
                }

                return new List<Edge>();
            }

            public int GetEdgeWeight(string source, string destination)
            {
                if (adjacencyList.ContainsKey(source))
                {
                    List<Edge> edges = adjacencyList[source];
                    foreach (Edge edge in edges)
                    {
                        if (edge.Source == source && edge.Destination == destination)
                        {
                            return edge.Weight;
                        }
                    }
                }

                return int.MaxValue; // Return a large weight if the edge is not found
            }

            public List<Edge> GetAllEdges()
            {
                List<Edge> edges = new List<Edge>();

                foreach (var vertex in adjacencyList)
                {
                    edges.AddRange(vertex.Value);
                }

                return edges;
            }

            public class UnionFind<T>
            {
                private Dictionary<T, T> parent;
                private Dictionary<T, int> rank;

                public UnionFind(IEnumerable<T> elements)
                {
                    parent = new Dictionary<T, T>();
                    rank = new Dictionary<T, int>();

                    foreach (T element in elements)
                    {
                        parent[element] = element;
                        rank[element] = 0;
                    }
                }

                public T Find(T element)
                {
                    if (!parent.ContainsKey(element))
                        throw new ArgumentException("Element not found in the union-find data structure.");

                    if (!element.Equals(parent[element]))
                        parent[element] = Find(parent[element]);

                    return parent[element];
                }

                public void Union(T element1, T element2)
                {
                    T root1 = Find(element1);
                    T root2 = Find(element2);

                    if (root1.Equals(root2))
                        return;

                    if (rank[root1] < rank[root2])
                    {
                        parent[root1] = root2;
                    }
                    else if (rank[root1] > rank[root2])
                    {
                        parent[root2] = root1;
                    }
                    else
                    {
                        parent[root1] = root2;
                        rank[root2]++;
                    }
                }

                public bool AreVerticesConnected(T element1, T element2)
                {
                    T root1 = Find(element1);
                    T root2 = Find(element2);
                    return root1.Equals(root2);
                }
            }
        }

        public class Edge
        {
            public string Source { get; }
            public string Destination { get; }
            public int Weight { get; }

            public Edge(string source, string destination, int weight)
            {
                Source = source;
                Destination = destination;
                Weight = weight;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
