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

            ErrorLabelValue.Text = error + " %";
            DataSetSizeValue.Text = manager.Table.Rows.Count + "";
        }
    }
}
