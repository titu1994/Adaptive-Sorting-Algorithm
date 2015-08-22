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
            ((System.ComponentModel.ISupportInitialize)(this.ArrayGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ArrayGridView
            // 
            this.ArrayGridView.AllowUserToAddRows = false;
            this.ArrayGridView.AllowUserToDeleteRows = false;
            this.ArrayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArrayGridView.GridColor = System.Drawing.Color.White;
            this.ArrayGridView.Location = new System.Drawing.Point(13, 89);
            this.ArrayGridView.Name = "ArrayGridView";
            this.ArrayGridView.ReadOnly = true;
            this.ArrayGridView.Size = new System.Drawing.Size(759, 445);
            this.ArrayGridView.TabIndex = 0;
            // 
            // loadArrayButton
            // 
            this.loadArrayButton.BackColor = System.Drawing.Color.White;
            this.loadArrayButton.Location = new System.Drawing.Point(13, 13);
            this.loadArrayButton.Name = "loadArrayButton";
            this.loadArrayButton.Size = new System.Drawing.Size(111, 45);
            this.loadArrayButton.TabIndex = 1;
            this.loadArrayButton.Text = "Load Arrays";
            this.loadArrayButton.UseVisualStyleBackColor = false;
            this.loadArrayButton.Click += new System.EventHandler(this.loadArrayButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.White;
            this.ErrorLabel.Location = new System.Drawing.Point(616, 9);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(29, 13);
            this.ErrorLabel.TabIndex = 2;
            this.ErrorLabel.Text = "Error";
            // 
            // ErrorLabelValue
            // 
            this.ErrorLabelValue.AutoSize = true;
            this.ErrorLabelValue.BackColor = System.Drawing.Color.White;
            this.ErrorLabelValue.Location = new System.Drawing.Point(717, 12);
            this.ErrorLabelValue.Name = "ErrorLabelValue";
            this.ErrorLabelValue.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabelValue.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data Set Size";
            // 
            // DataSetSizeValue
            // 
            this.DataSetSizeValue.AutoSize = true;
            this.DataSetSizeValue.Location = new System.Drawing.Point(720, 43);
            this.DataSetSizeValue.Name = "DataSetSizeValue";
            this.DataSetSizeValue.Size = new System.Drawing.Size(16, 13);
            this.DataSetSizeValue.TabIndex = 5;
            this.DataSetSizeValue.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Accuracy";
            // 
            // AccuractyLabelValue
            // 
            this.AccuractyLabelValue.AutoSize = true;
            this.AccuractyLabelValue.Location = new System.Drawing.Point(527, 9);
            this.AccuractyLabelValue.Name = "AccuractyLabelValue";
            this.AccuractyLabelValue.Size = new System.Drawing.Size(0, 13);
            this.AccuractyLabelValue.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.AccuractyLabelValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataSetSizeValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorLabelValue);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.loadArrayButton);
            this.Controls.Add(this.ArrayGridView);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adaptive Sorting";
            ((System.ComponentModel.ISupportInitialize)(this.ArrayGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

