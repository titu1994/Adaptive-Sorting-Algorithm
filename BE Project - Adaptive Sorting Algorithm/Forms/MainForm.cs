using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        //private DataTableManager manager;
        private ExtendedDataTableManager manager;

        private double errorDecisionTree, errorMCSVM, errorNaiveBayes, errorLinearRegression;

        public MainForm()
        {
            InitializeComponent();

            //manager = new DataTableManager();
            manager = new ExtendedDataTableManager();

            TrainingProgressBarDecisionTrees.Minimum =
                TrainingProgressBarMCSVM.Minimum = TrainingProgressBarNaiveBayes.Minimum = 0;
        }


        private void loadArrayButton_Click(object sender, EventArgs e)
        {
            TrainingProgressBarDecisionTrees.Visible = true;
            LoadDecisionTree();
        }

        private void LoadDecisionTree()
        {
            if (manager.Table.Rows.Count > 0)
                manager.Table.Clear();
            
            manager.LoadAllResults();
            manager.SortTable(CheckBoxDecisionTrees.Checked);

            ArrayGridView.DataSource = manager.Table;
            DataSetSizeValue.Text = manager.Table.Rows.Count + "";
            TrainingProgressBarDecisionTrees.Maximum =
              TrainingProgressBarMCSVM.Maximum = TrainingProgressBarNaiveBayes.Maximum = ArrayGridView.RowCount;


            manager.Codify();
            manager.CreateDecisionTree();
            errorDecisionTree = manager.TreeLearn();

            string[] data = new string[2];
            string bestAlgo;
            for (int i = 0; i < ArrayGridView.RowCount; i++)
            {
                data[0] = (string)ArrayGridView.Rows[i].Cells[0].Value;
                data[1] = (string)ArrayGridView.Rows[i].Cells[1].Value;

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

                //Publish Progress
                TrainingProgressBarDecisionTrees.Value = i;
            }

            //manager.SaveTreeFunction();

            TrainingProgressBarDecisionTrees.Visible = false;
            ErrorLabelValue.Text = Math.Round(errorDecisionTree * 100, 4) + " %";
            AccuracyLabelValue.Text = (100 - (Math.Round(errorDecisionTree * 100, 4))) + " %";

        }

        private void LoadMCSVMArray_Click(object sender, EventArgs e)
        {
            TrainingProgressBarMCSVM.Visible = true;
            LoadMCSVM();
        }

        private void LoadMCSVM()
        {
            if (manager.Table.Rows.Count > 0)
                manager.Table.Clear();
            manager.LoadAllResults();

            MCSVMGridView.DataSource = manager.Table;

            TrainingProgressBarDecisionTrees.Maximum =
              TrainingProgressBarMCSVM.Maximum = TrainingProgressBarNaiveBayes.Maximum = MCSVMGridView.RowCount;

            manager.Codify();
            manager.CreateMCSVM();
            errorMCSVM = manager.MCSVMLearn();

            string[] data = new string[2];
            string bestAlgo;
            TrainingProgressBarMCSVM.Value = 0;
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

                //Publish Progress
                TrainingProgressBarMCSVM.Value = i;
            }

            TrainingProgressBarMCSVM.Visible = false;
            ErrorMCSVMValue.Text = Math.Round(errorMCSVM * 100, 4) + " %";
            AccuracyMCSVMValue.Text = (100 - (Math.Round(errorMCSVM * 100, 4))) + " %";
            DataSetMCSVMValue.Text = manager.Table.Rows.Count + "";
        }

        private void LoadNaiveBayesArray_Click(object sender, EventArgs e)
        {
            TrainingProgressBarNaiveBayes.Visible = true;
            LoadNaiveBayes();
        }

        private void LoadNaiveBayes()
        {
            if (manager.Table.Rows.Count > 0)
                manager.Table.Clear();
            manager.LoadAllResults();
            manager.SortTable(CheckBoxDecisionTrees.Checked);

            NaiveBayesGridView.DataSource = manager.Table;

            TrainingProgressBarDecisionTrees.Maximum =
              TrainingProgressBarMCSVM.Maximum = TrainingProgressBarNaiveBayes.Maximum = NaiveBayesGridView.RowCount;

            manager.Codify();
            manager.CreateNaiveBayes();
            errorNaiveBayes = manager.LearnNaiveBayes();

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

                //Publish Progress
                TrainingProgressBarNaiveBayes.Value = i;
            }

            TrainingProgressBarNaiveBayes.Visible = false;
            ErrorNaiveBayesValue.Text = Math.Round(errorNaiveBayes * 100, 4) + " %";
            AccuracyNaiveBayesValue.Text = (100 - (Math.Round(errorNaiveBayes * 100, 4))) + " %";
            DataSetSizeNaiveBayes.Text = manager.Table.Rows.Count + "";
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

        private void NBButten_Click(object sender, EventArgs e)
        {
            string[] data = { TestArraySizeTextBox.Text, TestRunsFactorTextBox.Text };
            string bestAlgo = manager.GetBestAlgorithmForNaiveBayes(data, false);

            if (string.IsNullOrEmpty(bestAlgo))
            {
                Console.WriteLine("Data {0}, {1} has empty output : {2}", data[0], data[1],
                    manager.GetBestAlgorithmForInputTree(data, true));
            }

            TestBestArrayValue.Text = bestAlgo;
        }

    }
}
