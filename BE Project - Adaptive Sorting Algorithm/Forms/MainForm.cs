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
            manager.LoadAllResults();
            ArrayGridView.DataSource = manager.Table;

            manager.Codify();
            manager.CreateDecisionTree();
            double error = manager.Learn();

            ErrorLabelValue.Text = Math.Round(error * 100, 4) + " %";
            DataSetSizeValue.Text = manager.Table.Rows.Count + "";

            string[] data = new string[2];
            string bestAlgo;
            for (int i = 0; i < ArrayGridView.RowCount; i++)
            {
                data[0] = (string) ArrayGridView.Rows[i].Cells[0].Value;
                data[1] = (string) ArrayGridView.Rows[i].Cells[1].Value;

                bestAlgo = manager.GetBestAlgorithmForInput(data);
                if (bestAlgo.Equals(ArrayGridView.Rows[i].Cells["Selected Sorting Algorithm"].Value))
                {
                    ArrayGridView.Rows[i].Cells["Selected Sorting Algorithm"].Style.BackColor = Color.ForestGreen;
                }
                else
                {
                    ArrayGridView.Rows[i].Cells["Selected Sorting Algorithm"].Style.BackColor = Color.OrangeRed;
                    ArrayGridView.Rows[i].Cells["Selected Sorting Algorithm"].ToolTipText = "Calculated : " + bestAlgo;

                    /*Console.WriteLine("Error at {0} : Best = {1} | Given Best = {2}",
                        i+"", ArrayGridView.Rows[i].Cells["Selected Sorting Algorithm"].Value, bestAlgo);
                        */
                }
            }
        }
    }
}
