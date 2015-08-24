namespace BE_Project___Adaptive_Sorting_Algorithm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ArrayGridView = new System.Windows.Forms.DataGridView();
            this.loadArrayButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ErrorLabelValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataSetSizeValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccuracyLabelValue = new System.Windows.Forms.Label();
            this.TabController = new System.Windows.Forms.TabControl();
            this.TrainingTab = new System.Windows.Forms.TabPage();
            this.TrainingProgressBarDecisionTrees = new System.Windows.Forms.ProgressBar();
            this.NaiveBayes = new System.Windows.Forms.TabPage();
            this.TrainingProgressBarNaiveBayes = new System.Windows.Forms.ProgressBar();
            this.DataSetSizeNaiveBayes = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ErrorNaiveBayesValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AccuracyNaiveBayesValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NaiveBayesGridView = new System.Windows.Forms.DataGridView();
            this.LoadNaiveBayesArray = new System.Windows.Forms.Button();
            this.MCSVMTab = new System.Windows.Forms.TabPage();
            this.TrainingProgressBarMCSVM = new System.Windows.Forms.ProgressBar();
            this.DataSetMCSVMValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ErrorMCSVMValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AccuracyMCSVMValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MCSVMGridView = new System.Windows.Forms.DataGridView();
            this.LoadMCSVMArray = new System.Windows.Forms.Button();
            this.TestingPage = new System.Windows.Forms.TabPage();
            this.TestBestArrayValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TestCalculateButton = new System.Windows.Forms.Button();
            this.TestRunsFactorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TestArraySizeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBoxDecisionTrees = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayGridView)).BeginInit();
            this.TabController.SuspendLayout();
            this.TrainingTab.SuspendLayout();
            this.NaiveBayes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NaiveBayesGridView)).BeginInit();
            this.MCSVMTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MCSVMGridView)).BeginInit();
            this.TestingPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArrayGridView
            // 
            this.ArrayGridView.AllowUserToAddRows = false;
            this.ArrayGridView.AllowUserToDeleteRows = false;
            this.ArrayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArrayGridView.GridColor = System.Drawing.Color.White;
            this.ArrayGridView.Location = new System.Drawing.Point(3, 66);
            this.ArrayGridView.Name = "ArrayGridView";
            this.ArrayGridView.ReadOnly = true;
            this.ArrayGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ArrayGridView.Size = new System.Drawing.Size(759, 445);
            this.ArrayGridView.TabIndex = 0;
            // 
            // loadArrayButton
            // 
            this.loadArrayButton.BackColor = System.Drawing.Color.White;
            this.loadArrayButton.Location = new System.Drawing.Point(8, 6);
            this.loadArrayButton.Name = "loadArrayButton";
            this.loadArrayButton.Size = new System.Drawing.Size(111, 45);
            this.loadArrayButton.TabIndex = 1;
            this.loadArrayButton.Text = "Train Arrays";
            this.loadArrayButton.UseVisualStyleBackColor = false;
            this.loadArrayButton.Click += new System.EventHandler(this.loadArrayButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.White;
            this.ErrorLabel.Location = new System.Drawing.Point(563, 6);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(29, 13);
            this.ErrorLabel.TabIndex = 2;
            this.ErrorLabel.Text = "Error";
            // 
            // ErrorLabelValue
            // 
            this.ErrorLabelValue.AutoSize = true;
            this.ErrorLabelValue.BackColor = System.Drawing.Color.White;
            this.ErrorLabelValue.Location = new System.Drawing.Point(664, 9);
            this.ErrorLabelValue.Name = "ErrorLabelValue";
            this.ErrorLabelValue.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabelValue.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data Set Size";
            // 
            // DataSetSizeValue
            // 
            this.DataSetSizeValue.AutoSize = true;
            this.DataSetSizeValue.Location = new System.Drawing.Point(667, 40);
            this.DataSetSizeValue.Name = "DataSetSizeValue";
            this.DataSetSizeValue.Size = new System.Drawing.Size(16, 13);
            this.DataSetSizeValue.TabIndex = 5;
            this.DataSetSizeValue.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Accuracy";
            // 
            // AccuracyLabelValue
            // 
            this.AccuracyLabelValue.AutoSize = true;
            this.AccuracyLabelValue.Location = new System.Drawing.Point(474, 6);
            this.AccuracyLabelValue.Name = "AccuracyLabelValue";
            this.AccuracyLabelValue.Size = new System.Drawing.Size(0, 13);
            this.AccuracyLabelValue.TabIndex = 7;
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.TrainingTab);
            this.TabController.Controls.Add(this.NaiveBayes);
            this.TabController.Controls.Add(this.MCSVMTab);
            this.TabController.Controls.Add(this.TestingPage);
            this.TabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabController.Location = new System.Drawing.Point(0, 0);
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(784, 561);
            this.TabController.TabIndex = 9;
            // 
            // TrainingTab
            // 
            this.TrainingTab.BackColor = System.Drawing.Color.White;
            this.TrainingTab.Controls.Add(this.CheckBoxDecisionTrees);
            this.TrainingTab.Controls.Add(this.TrainingProgressBarDecisionTrees);
            this.TrainingTab.Controls.Add(this.ArrayGridView);
            this.TrainingTab.Controls.Add(this.AccuracyLabelValue);
            this.TrainingTab.Controls.Add(this.loadArrayButton);
            this.TrainingTab.Controls.Add(this.label2);
            this.TrainingTab.Controls.Add(this.DataSetSizeValue);
            this.TrainingTab.Controls.Add(this.ErrorLabel);
            this.TrainingTab.Controls.Add(this.label1);
            this.TrainingTab.Controls.Add(this.ErrorLabelValue);
            this.TrainingTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainingTab.Location = new System.Drawing.Point(4, 22);
            this.TrainingTab.Name = "TrainingTab";
            this.TrainingTab.Padding = new System.Windows.Forms.Padding(3);
            this.TrainingTab.Size = new System.Drawing.Size(776, 535);
            this.TrainingTab.TabIndex = 0;
            this.TrainingTab.Text = "Train (Decision Trees)";
            // 
            // TrainingProgressBarDecisionTrees
            // 
            this.TrainingProgressBarDecisionTrees.BackColor = System.Drawing.Color.White;
            this.TrainingProgressBarDecisionTrees.Location = new System.Drawing.Point(600, 512);
            this.TrainingProgressBarDecisionTrees.Name = "TrainingProgressBarDecisionTrees";
            this.TrainingProgressBarDecisionTrees.Size = new System.Drawing.Size(162, 23);
            this.TrainingProgressBarDecisionTrees.TabIndex = 8;
            this.TrainingProgressBarDecisionTrees.Visible = false;
            // 
            // NaiveBayes
            // 
            this.NaiveBayes.Controls.Add(this.TrainingProgressBarNaiveBayes);
            this.NaiveBayes.Controls.Add(this.DataSetSizeNaiveBayes);
            this.NaiveBayes.Controls.Add(this.label11);
            this.NaiveBayes.Controls.Add(this.ErrorNaiveBayesValue);
            this.NaiveBayes.Controls.Add(this.label10);
            this.NaiveBayes.Controls.Add(this.AccuracyNaiveBayesValue);
            this.NaiveBayes.Controls.Add(this.label9);
            this.NaiveBayes.Controls.Add(this.NaiveBayesGridView);
            this.NaiveBayes.Controls.Add(this.LoadNaiveBayesArray);
            this.NaiveBayes.Location = new System.Drawing.Point(4, 22);
            this.NaiveBayes.Name = "NaiveBayes";
            this.NaiveBayes.Size = new System.Drawing.Size(776, 535);
            this.NaiveBayes.TabIndex = 3;
            this.NaiveBayes.Text = "Train (Naive Bayes)";
            this.NaiveBayes.UseVisualStyleBackColor = true;
            // 
            // TrainingProgressBarNaiveBayes
            // 
            this.TrainingProgressBarNaiveBayes.BackColor = System.Drawing.Color.White;
            this.TrainingProgressBarNaiveBayes.Location = new System.Drawing.Point(606, 509);
            this.TrainingProgressBarNaiveBayes.Name = "TrainingProgressBarNaiveBayes";
            this.TrainingProgressBarNaiveBayes.Size = new System.Drawing.Size(162, 23);
            this.TrainingProgressBarNaiveBayes.TabIndex = 9;
            this.TrainingProgressBarNaiveBayes.Visible = false;
            // 
            // DataSetSizeNaiveBayes
            // 
            this.DataSetSizeNaiveBayes.AutoSize = true;
            this.DataSetSizeNaiveBayes.Location = new System.Drawing.Point(667, 45);
            this.DataSetSizeNaiveBayes.Name = "DataSetSizeNaiveBayes";
            this.DataSetSizeNaiveBayes.Size = new System.Drawing.Size(0, 13);
            this.DataSetSizeNaiveBayes.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(572, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Data Set Size";
            // 
            // ErrorNaiveBayesValue
            // 
            this.ErrorNaiveBayesValue.AutoSize = true;
            this.ErrorNaiveBayesValue.Location = new System.Drawing.Point(629, 12);
            this.ErrorNaiveBayesValue.Name = "ErrorNaiveBayesValue";
            this.ErrorNaiveBayesValue.Size = new System.Drawing.Size(0, 13);
            this.ErrorNaiveBayesValue.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(572, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Error";
            // 
            // AccuracyNaiveBayesValue
            // 
            this.AccuracyNaiveBayesValue.AutoSize = true;
            this.AccuracyNaiveBayesValue.Location = new System.Drawing.Point(512, 12);
            this.AccuracyNaiveBayesValue.Name = "AccuracyNaiveBayesValue";
            this.AccuracyNaiveBayesValue.Size = new System.Drawing.Size(0, 13);
            this.AccuracyNaiveBayesValue.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Accuracy";
            // 
            // NaiveBayesGridView
            // 
            this.NaiveBayesGridView.AllowUserToAddRows = false;
            this.NaiveBayesGridView.AllowUserToDeleteRows = false;
            this.NaiveBayesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NaiveBayesGridView.Location = new System.Drawing.Point(9, 78);
            this.NaiveBayesGridView.Name = "NaiveBayesGridView";
            this.NaiveBayesGridView.ReadOnly = true;
            this.NaiveBayesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NaiveBayesGridView.Size = new System.Drawing.Size(759, 430);
            this.NaiveBayesGridView.TabIndex = 1;
            // 
            // LoadNaiveBayesArray
            // 
            this.LoadNaiveBayesArray.BackColor = System.Drawing.Color.White;
            this.LoadNaiveBayesArray.Location = new System.Drawing.Point(8, 12);
            this.LoadNaiveBayesArray.Name = "LoadNaiveBayesArray";
            this.LoadNaiveBayesArray.Size = new System.Drawing.Size(105, 46);
            this.LoadNaiveBayesArray.TabIndex = 0;
            this.LoadNaiveBayesArray.Text = "Load Arrays";
            this.LoadNaiveBayesArray.UseVisualStyleBackColor = false;
            this.LoadNaiveBayesArray.Click += new System.EventHandler(this.LoadNaiveBayesArray_Click);
            // 
            // MCSVMTab
            // 
            this.MCSVMTab.Controls.Add(this.TrainingProgressBarMCSVM);
            this.MCSVMTab.Controls.Add(this.DataSetMCSVMValue);
            this.MCSVMTab.Controls.Add(this.label8);
            this.MCSVMTab.Controls.Add(this.ErrorMCSVMValue);
            this.MCSVMTab.Controls.Add(this.label7);
            this.MCSVMTab.Controls.Add(this.AccuracyMCSVMValue);
            this.MCSVMTab.Controls.Add(this.label6);
            this.MCSVMTab.Controls.Add(this.MCSVMGridView);
            this.MCSVMTab.Controls.Add(this.LoadMCSVMArray);
            this.MCSVMTab.Location = new System.Drawing.Point(4, 22);
            this.MCSVMTab.Name = "MCSVMTab";
            this.MCSVMTab.Size = new System.Drawing.Size(776, 535);
            this.MCSVMTab.TabIndex = 2;
            this.MCSVMTab.Text = "Train (Multi Class SVM)";
            this.MCSVMTab.UseVisualStyleBackColor = true;
            // 
            // TrainingProgressBarMCSVM
            // 
            this.TrainingProgressBarMCSVM.BackColor = System.Drawing.Color.White;
            this.TrainingProgressBarMCSVM.Location = new System.Drawing.Point(592, 512);
            this.TrainingProgressBarMCSVM.Name = "TrainingProgressBarMCSVM";
            this.TrainingProgressBarMCSVM.Size = new System.Drawing.Size(162, 23);
            this.TrainingProgressBarMCSVM.TabIndex = 9;
            this.TrainingProgressBarMCSVM.Visible = false;
            // 
            // DataSetMCSVMValue
            // 
            this.DataSetMCSVMValue.AutoSize = true;
            this.DataSetMCSVMValue.Location = new System.Drawing.Point(643, 44);
            this.DataSetMCSVMValue.Name = "DataSetMCSVMValue";
            this.DataSetMCSVMValue.Size = new System.Drawing.Size(0, 13);
            this.DataSetMCSVMValue.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(561, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Data Set Size";
            // 
            // ErrorMCSVMValue
            // 
            this.ErrorMCSVMValue.AutoSize = true;
            this.ErrorMCSVMValue.Location = new System.Drawing.Point(608, 15);
            this.ErrorMCSVMValue.Name = "ErrorMCSVMValue";
            this.ErrorMCSVMValue.Size = new System.Drawing.Size(0, 13);
            this.ErrorMCSVMValue.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Error";
            // 
            // AccuracyMCSVMValue
            // 
            this.AccuracyMCSVMValue.AutoSize = true;
            this.AccuracyMCSVMValue.Location = new System.Drawing.Point(468, 15);
            this.AccuracyMCSVMValue.Name = "AccuracyMCSVMValue";
            this.AccuracyMCSVMValue.Size = new System.Drawing.Size(0, 13);
            this.AccuracyMCSVMValue.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Accuracy";
            // 
            // MCSVMGridView
            // 
            this.MCSVMGridView.AllowUserToAddRows = false;
            this.MCSVMGridView.AllowUserToDeleteRows = false;
            this.MCSVMGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MCSVMGridView.Location = new System.Drawing.Point(9, 64);
            this.MCSVMGridView.Name = "MCSVMGridView";
            this.MCSVMGridView.ReadOnly = true;
            this.MCSVMGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MCSVMGridView.Size = new System.Drawing.Size(745, 447);
            this.MCSVMGridView.TabIndex = 1;
            // 
            // LoadMCSVMArray
            // 
            this.LoadMCSVMArray.BackColor = System.Drawing.Color.White;
            this.LoadMCSVMArray.Location = new System.Drawing.Point(9, 14);
            this.LoadMCSVMArray.Name = "LoadMCSVMArray";
            this.LoadMCSVMArray.Size = new System.Drawing.Size(108, 43);
            this.LoadMCSVMArray.TabIndex = 0;
            this.LoadMCSVMArray.Text = "Load Arrays";
            this.LoadMCSVMArray.UseVisualStyleBackColor = false;
            this.LoadMCSVMArray.Click += new System.EventHandler(this.LoadMCSVMArray_Click);
            // 
            // TestingPage
            // 
            this.TestingPage.BackColor = System.Drawing.Color.White;
            this.TestingPage.Controls.Add(this.TestBestArrayValue);
            this.TestingPage.Controls.Add(this.label5);
            this.TestingPage.Controls.Add(this.TestCalculateButton);
            this.TestingPage.Controls.Add(this.TestRunsFactorTextBox);
            this.TestingPage.Controls.Add(this.label4);
            this.TestingPage.Controls.Add(this.TestArraySizeTextBox);
            this.TestingPage.Controls.Add(this.label3);
            this.TestingPage.Location = new System.Drawing.Point(4, 22);
            this.TestingPage.Name = "TestingPage";
            this.TestingPage.Padding = new System.Windows.Forms.Padding(3);
            this.TestingPage.Size = new System.Drawing.Size(776, 535);
            this.TestingPage.TabIndex = 1;
            this.TestingPage.Text = "Test";
            // 
            // TestBestArrayValue
            // 
            this.TestBestArrayValue.AutoSize = true;
            this.TestBestArrayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestBestArrayValue.Location = new System.Drawing.Point(490, 65);
            this.TestBestArrayValue.Name = "TestBestArrayValue";
            this.TestBestArrayValue.Size = new System.Drawing.Size(0, 24);
            this.TestBestArrayValue.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Best Array : ";
            // 
            // TestCalculateButton
            // 
            this.TestCalculateButton.BackColor = System.Drawing.Color.White;
            this.TestCalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestCalculateButton.Location = new System.Drawing.Point(50, 160);
            this.TestCalculateButton.Name = "TestCalculateButton";
            this.TestCalculateButton.Size = new System.Drawing.Size(238, 43);
            this.TestCalculateButton.TabIndex = 4;
            this.TestCalculateButton.Text = "Calculate";
            this.TestCalculateButton.UseVisualStyleBackColor = false;
            this.TestCalculateButton.Click += new System.EventHandler(this.TestCalculateButton_Click);
            // 
            // TestRunsFactorTextBox
            // 
            this.TestRunsFactorTextBox.Location = new System.Drawing.Point(176, 111);
            this.TestRunsFactorTextBox.Name = "TestRunsFactorTextBox";
            this.TestRunsFactorTextBox.Size = new System.Drawing.Size(112, 20);
            this.TestRunsFactorTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Runs Factor";
            // 
            // TestArraySizeTextBox
            // 
            this.TestArraySizeTextBox.Location = new System.Drawing.Point(176, 70);
            this.TestArraySizeTextBox.Name = "TestArraySizeTextBox";
            this.TestArraySizeTextBox.Size = new System.Drawing.Size(112, 20);
            this.TestArraySizeTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Array Size";
            // 
            // CheckBoxDecisionTrees
            // 
            this.CheckBoxDecisionTrees.AutoSize = true;
            this.CheckBoxDecisionTrees.BackColor = System.Drawing.Color.White;
            this.CheckBoxDecisionTrees.Location = new System.Drawing.Point(306, 6);
            this.CheckBoxDecisionTrees.Name = "CheckBoxDecisionTrees";
            this.CheckBoxDecisionTrees.Size = new System.Drawing.Size(73, 17);
            this.CheckBoxDecisionTrees.TabIndex = 9;
            this.CheckBoxDecisionTrees.Text = "Sort Runs";
            this.CheckBoxDecisionTrees.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TabController);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adaptive Sorting";
            ((System.ComponentModel.ISupportInitialize)(this.ArrayGridView)).EndInit();
            this.TabController.ResumeLayout(false);
            this.TrainingTab.ResumeLayout(false);
            this.TrainingTab.PerformLayout();
            this.NaiveBayes.ResumeLayout(false);
            this.NaiveBayes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NaiveBayesGridView)).EndInit();
            this.MCSVMTab.ResumeLayout(false);
            this.MCSVMTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MCSVMGridView)).EndInit();
            this.TestingPage.ResumeLayout(false);
            this.TestingPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ArrayGridView;
        private System.Windows.Forms.Button loadArrayButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label ErrorLabelValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DataSetSizeValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AccuracyLabelValue;
        private System.Windows.Forms.TabControl TabController;
        private System.Windows.Forms.TabPage TrainingTab;
        private System.Windows.Forms.TabPage TestingPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TestRunsFactorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TestArraySizeTextBox;
        private System.Windows.Forms.Button TestCalculateButton;
        private System.Windows.Forms.Label TestBestArrayValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage MCSVMTab;
        private System.Windows.Forms.DataGridView MCSVMGridView;
        private System.Windows.Forms.Button LoadMCSVMArray;
        private System.Windows.Forms.Label AccuracyMCSVMValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ErrorMCSVMValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DataSetMCSVMValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage NaiveBayes;
        private System.Windows.Forms.Button LoadNaiveBayesArray;
        private System.Windows.Forms.DataGridView NaiveBayesGridView;
        private System.Windows.Forms.Label AccuracyNaiveBayesValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ErrorNaiveBayesValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label DataSetSizeNaiveBayes;
        private System.Windows.Forms.ProgressBar TrainingProgressBarDecisionTrees;
        private System.Windows.Forms.ProgressBar TrainingProgressBarNaiveBayes;
        private System.Windows.Forms.ProgressBar TrainingProgressBarMCSVM;
        private System.Windows.Forms.CheckBox CheckBoxDecisionTrees;
    }
}

