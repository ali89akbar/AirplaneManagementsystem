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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace WindowsFormsApp16
{
    public partial class djikstra : Form
    {
        private Graph flightGraph;
        public djikstra()
        {
            InitializeComponent();

            // Initialize the flight graph and populate it with flight details
            flightGraph = new Graph();

            // Add vertices and edges to the graph based on flight details
            // Example:
            /*flightGraph.AddEdge("Hyderabad", "Spain", 10000);
            flightGraph.AddEdge("Manchestar", "Islamabad", 20000);
            flightGraph.AddEdge("Germany", "Karachi", 15000);
            flightGraph.AddEdge("London", "Lahore", 18000);
            flightGraph.AddEdge("Berlin", "Manchestar", 12000);
            flightGraph.AddEdge("Multan", "Rawalpindi", 9000);
            flightGraph.AddEdge("Islamabad", "Multan", 8000);
            flightGraph.AddEdge("Sydney", "Tokyo", 30000);
            flightGraph.AddEdge("California", "Beijing", 25000);*/

            // ...

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

        private void djikstra_Load(object sender, EventArgs e)
        {

        }
        private string GetDistanceText(Dictionary<string, int> distances, string cityName)
        {
            if (distances.ContainsKey(cityName))
            {
                int distance = distances[cityName];
                return $"Distance to {cityName}: {distance} km";
            }
            else
            {
                return $"No distance information available for {cityName}";
            }
        }
        private Dictionary<string, int> DijkstraAlgorithm(Graph graph, string source)
        {
            Dictionary<string, int> distance = new Dictionary<string, int>();

            // Initialize distances to all cities as infinity except the source city
            foreach (var city in graph.GetVertices())
            {
                if (city == source)
                    distance[city] = 0;
                else
                    distance[city] = int.MaxValue;
            }


            // Create a priority queue to store the vertices
            PriorityQueue<string> queue = new PriorityQueue<string>();
            queue.Enqueue(source, 0);

            while (!queue.IsEmpty())
            {
                string currentCity = queue.Dequeue();

                foreach (var neighbor in graph.GetNeighbors(currentCity))
                {
                    int edgeWeight = graph.GetEdgeWeight(currentCity, neighbor);
                    int newDistance = distance[currentCity] + edgeWeight;

                    if (newDistance < distance[neighbor])
                    {
                        distance[neighbor] = newDistance;
                        queue.Enqueue(neighbor, newDistance);
                    }
                }
            }

            return distance;
        }

        private void btnrundjikstra_Click(object sender, EventArgs e)
        {
            string sourceCity = txtSourceCity.Text;

            // Call Dijkstra's algorithm to get the distances
            Dictionary<string, int> distance = DijkstraAlgorithm(flightGraph, sourceCity);

            // Display the distances to the destination cities
            lblDestination1.Text = GetDistanceText(distance, "Spain");
            lblDestination2.Text = GetDistanceText(distance, "Islamabad");
            lblDestination3.Text = GetDistanceText(distance, "lahore");
            lblDestination4.Text = GetDistanceText(distance, "Manchester");
            lblDestination5.Text = GetDistanceText(distance, "Rawalpindi");
            lblDestination6.Text = GetDistanceText(distance, "Multan");
            lblDestination7.Text = GetDistanceText(distance, "Karachi");

        }

        public class PriorityQueue<T>
        {
            private SortedDictionary<int, Queue<T>> priorityQueue;

            public PriorityQueue()
            {
                priorityQueue = new SortedDictionary<int, Queue<T>>();
            }

            public void Enqueue(T item, int priority)
            {
                if (!priorityQueue.ContainsKey(priority))
                {
                    priorityQueue[priority] = new Queue<T>();
                }
                priorityQueue[priority].Enqueue(item);
            }

            public T Dequeue()
            {
                var item = priorityQueue.First().Value.Dequeue();
                if (priorityQueue.First().Value.Count == 0)
                {
                    priorityQueue.Remove(priorityQueue.First().Key);
                }
                return item;
            }

            public bool IsEmpty()
            {
                return priorityQueue.Count == 0;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}