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
            this.AccuractyLabelValue = new System.Windows.Forms.Label();
            this.TabController = new System.Windows.Forms.TabControl();
            this.TrainingTab = new System.Windows.Forms.TabPage();
            this.TestingPage = new System.Windows.Forms.TabPage();
            this.TestBestArrayValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TestCalculateButton = new System.Windows.Forms.Button();
            this.TestRunsFactorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TestArraySizeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayGridView)).BeginInit();
            this.TabController.SuspendLayout();
            this.TrainingTab.SuspendLayout();
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
            // AccuractyLabelValue
            // 
            this.AccuractyLabelValue.AutoSize = true;
            this.AccuractyLabelValue.Location = new System.Drawing.Point(474, 6);
            this.AccuractyLabelValue.Name = "AccuractyLabelValue";
            this.AccuractyLabelValue.Size = new System.Drawing.Size(0, 13);
            this.AccuractyLabelValue.TabIndex = 7;
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.TrainingTab);
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
            this.TrainingTab.Controls.Add(this.ArrayGridView);
            this.TrainingTab.Controls.Add(this.AccuractyLabelValue);
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
        private System.Windows.Forms.Label AccuractyLabelValue;
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
    }
}

