using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class laguage : Form
    {
        private List<LuggageItem> luggageItems;

        public laguage()
        {
            InitializeComponent();
            luggageItems = new List<LuggageItem>();
        }

        private void deletePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      

        private static List<LuggageItem> Knapsack(List<LuggageItem> items, int maxWeight)
        {

            int itemCount = items.Count;

            int[,] dp = new int[itemCount + 1, maxWeight + 1];

            for (int i = 1; i <= itemCount; i++)
            {
                for (int w = 1; w <= maxWeight; w++)
                {
                    if (items[i - 1].Weight <= w)
                    {
                        dp[i, w] = Math.Max(dp[i - 1, w], dp[i - 1, w - items[i - 1].Weight] + items[i - 1].Value);
                    }
                    else
                    {
                        dp[i, w] = dp[i - 1, w];
                    }
                }
            }

            List<LuggageItem> packedItems = new List<LuggageItem>();

            int itemIndex = itemCount;
            int remainingWeight = maxWeight;

            while (itemIndex > 0 && remainingWeight > 0)
            {
                if (dp[itemIndex, remainingWeight] != dp[itemIndex - 1, remainingWeight])
                {
                    LuggageItem packedItem = items[itemIndex - 1];
                    packedItems.Add(packedItem);
                    remainingWeight -= packedItem.Weight;
                }

                itemIndex--;
            }

            return packedItems;
        }

        private void Luggage_Load(object sender, EventArgs e)
        {
            luggageItems = new List<LuggageItem>();
        }

        private void calculate_Click(object sender, EventArgs e)
        {

        }
        private void calculate_Click_1(object sender, EventArgs e)
        {
            int maxWeightLimit = 30;

            if (luggageItems.Sum(item => item.Weight) > maxWeightLimit)
            {
                MessageBox.Show("Total weight exceeds the maximum weight limit.", "Weight Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<LuggageItem> packedItems = Knapsack(luggageItems, maxWeightLimit);
            int totalWeight = 0;
            int totalCost = 0;
            List<string> packedItemNames = new List<string>();
            string message = "Optimal Solution:\n\n";
            foreach (var item in packedItems)
            {
                packedItemNames.Add(item.Name); // Add the name of the packed item to the list

                message += $"Item: {item.Name}\n";
                message += $"Weight: {item.Weight} kg\n";
                message += $"Cost: {item.Value} units\n\n";

                totalWeight += item.Weight;
                totalCost += item.Value;
            }

            message += $"Total Weight: {totalWeight} kg\n";
            message += $"Total Cost: {totalCost} units\n\n";
            List<string> availableItemNames = luggageItems.Select(item => item.Name).Except(packedItemNames).ToList();

            MessageBox.Show(message, "Optimal Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int weight = int.Parse(textBox2.Text);
            int cost = int.Parse(textBox3.Text);
            LuggageItem item = new LuggageItem(name, weight, cost);
            luggageItems.Add(item);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            // Display added item in the DataGridView
            dataGridView2.Rows.Add(item.Name, item.Weight, item.Value);

        }
    }
    }

