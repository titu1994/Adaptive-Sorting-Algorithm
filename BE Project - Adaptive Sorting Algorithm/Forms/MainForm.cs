using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE_Project___Adaptive_Sorting_Algorithm.Managers;

namespace BE_Project___Adaptive_Sorting_Algorithm
{
    public partial class MainForm : Form
    {
        private DataTableManager manager;

        public MainForm()
        {
            InitializeComponent();
            manager = new DataTableManager();


        }

        private void loadArrayButton_Click(object sender, EventArgs e)
        {
            if(manager.Table.Rows.Count > 0) 
                manager.Table.Clear();
            manager.LoadAllResults();
            ArrayGridView.DataSource = manager.Table;

            manager.Codify();
            manager.CreateDecisionTree();
            double error = manager.Learn();

            ErrorLabelValue.Text = Math.Round(error * 100, 4) + " %";
            AccuractyLabelValue.Text = (100 - (Math.Round(error*100, 4))) + " %";
            DataSetSizeValue.Text = manager.Table.Rows.Count + "";

            string[] data = new string[2];
            string bestAlgo;
            for (int i = 0; i < ArrayGridView.RowCount; i++)
            {
                data[0] = (string) ArrayGridView.Rows[i].Cells[0].Value;
                data[1] = (string) ArrayGridView.Rows[i].Cells[1].Value;

                bestAlgo = manager.GetBestAlgorithmForInput(data, false);
                if (bestAlgo.Equals(ArrayGridView.Rows[i].Cells["Selected Sorting Algorithm"].Value))
                {
                    ArrayGridView.Rows[i].Cells["Selected Sorting Algorithm"].Style.BackColor = Color.ForestGreen;
                }
                else
                {
                    ArrayGridView.Rows[i].Cells["Selected Sorting Algorithm"].Style.BackColor = Color.OrangeRed;
                    ArrayGridView.Rows[i].Cells["Selected Sorting Algorithm"].ToolTipText = "Calculated : " + bestAlgo;
                }
            }

            //manager.SaveTreeFunction();
        }

        private void TestCalculateButton_Click(object sender, EventArgs e)
        {
            string[] data = {TestArraySizeTextBox.Text, TestRunsFactorTextBox.Text};
            string bestAlgo = manager.GetBestAlgorithmForInput(data, false);

            if (string.IsNullOrEmpty(bestAlgo))
            {
                Console.WriteLine("Data {0}, {1} has empty output : {2}", data[0], data[1], manager.GetBestAlgorithmForInput(data, true));
            }

            TestBestArrayValue.Text = bestAlgo;
        }
    }
}
