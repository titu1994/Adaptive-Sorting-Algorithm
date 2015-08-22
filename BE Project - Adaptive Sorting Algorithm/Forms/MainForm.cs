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
            if (manager.Table.Rows.Count > 0)
                manager.Table.Clear();
            manager.LoadAllResults();
            ArrayGridView.DataSource = manager.Table;

            manager.Codify();
            manager.CreateDecisionTree();
            double error = manager.TreeLearn();

            ErrorLabelValue.Text = Math.Round(error*100, 4) + " %";
            AccuracyLabelValue.Text = (100 - (Math.Round(error*100, 4))) + " %";
            DataSetSizeValue.Text = manager.Table.Rows.Count + "";

            string[] data = new string[2];
            string bestAlgo;
            for (int i = 0; i < ArrayGridView.RowCount; i++)
            {
                data[0] = (string) ArrayGridView.Rows[i].Cells[0].Value;
                data[1] = (string) ArrayGridView.Rows[i].Cells[1].Value;

                bestAlgo = manager.GetBestAlgorithmForInputTree(data, false);
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

        private void LoadMCSVMArray_Click(object sender, EventArgs e)
        {
            if (manager.Table.Rows.Count > 0)
                manager.Table.Clear();
            manager.LoadAllResults();
            MCSVMGridView.DataSource = manager.Table;

            manager.Codify();
            manager.CreateMCSVM();
            double error = manager.MCSVMLearn();

            ErrorMCSVMValue.Text = Math.Round(error * 100, 4) + " %";
            AccuracyMCSVMValue.Text = (100 - (Math.Round(error * 100, 4))) + " %";
            DataSetMCSVMValue.Text = manager.Table.Rows.Count + "";

            string[] data = new string[2];
            string bestAlgo;
            for (int i = 0; i < MCSVMGridView.RowCount; i++)
            {
                data[0] = (string)MCSVMGridView.Rows[i].Cells[0].Value;
                data[1] = (string)MCSVMGridView.Rows[i].Cells[1].Value;

                bestAlgo = manager.GetBestAlgorithmForInputMCSVM(data, false);
                if (bestAlgo.Equals(MCSVMGridView.Rows[i].Cells["Selected Sorting Algorithm"].Value))
                {
                    MCSVMGridView.Rows[i].Cells["Selected Sorting Algorithm"].Style.BackColor = Color.ForestGreen;
                }
                else
                {
                    MCSVMGridView.Rows[i].Cells["Selected Sorting Algorithm"].Style.BackColor = Color.OrangeRed;
                    MCSVMGridView.Rows[i].Cells["Selected Sorting Algorithm"].ToolTipText = "Calculated : " + bestAlgo;
                }
            }

        }

        private void LoadNaiveBayesArray_Click(object sender, EventArgs e)
        {
            if (manager.Table.Rows.Count > 0)
                manager.Table.Clear();
            manager.LoadAllResults();
            NaiveBayesGridView.DataSource = manager.Table;

            manager.Codify();
            manager.CreateNaiveBayes();
            double error = manager.LearnNaiveBayes();

            ErrorNaiveBayesValue.Text = Math.Round(error * 100, 4) + " %";
            AccuracyNaiveBayesValue.Text = (100 - (Math.Round(error * 100, 4))) + " %";
            DataSetSizeNaiveBayes.Text = manager.Table.Rows.Count + "";

            string[] data = new string[2];
            string bestAlgo;
            for (int i = 0; i < NaiveBayesGridView.RowCount; i++)
            {
                data[0] = (string)NaiveBayesGridView.Rows[i].Cells[0].Value;
                data[1] = (string)NaiveBayesGridView.Rows[i].Cells[1].Value;

                bestAlgo = manager.GetBestAlgorithmForInputNaiveBayes(data, false);
                if (bestAlgo.Equals(NaiveBayesGridView.Rows[i].Cells["Selected Sorting Algorithm"].Value))
                {
                    NaiveBayesGridView.Rows[i].Cells["Selected Sorting Algorithm"].Style.BackColor = Color.ForestGreen;
                }
                else
                {
                    NaiveBayesGridView.Rows[i].Cells["Selected Sorting Algorithm"].Style.BackColor = Color.OrangeRed;
                    NaiveBayesGridView.Rows[i].Cells["Selected Sorting Algorithm"].ToolTipText = "Calculated : " + bestAlgo;
                }
            }
        }


        private void TestCalculateButton_Click(object sender, EventArgs e)
        {
            string[] data = { TestArraySizeTextBox.Text, TestRunsFactorTextBox.Text };
            string bestAlgo = manager.GetBestAlgorithmForInputTree(data, false);

            if (string.IsNullOrEmpty(bestAlgo))
            {
                Console.WriteLine("Data {0}, {1} has empty output : {2}", data[0], data[1],
                    manager.GetBestAlgorithmForInputTree(data, true));
            }

            TestBestArrayValue.Text = bestAlgo;
        }
    }
}
