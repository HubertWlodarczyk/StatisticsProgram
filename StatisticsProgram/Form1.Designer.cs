namespace StatisticsProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.listBoxPoints = new System.Windows.Forms.ListBox();
            this.labelMean = new System.Windows.Forms.Label();
            this.labelVariance = new System.Windows.Forms.Label();
            this.labelStdDev = new System.Windows.Forms.Label();
            this.labelCovariance = new System.Windows.Forms.Label();
            this.labelCorrelation = new System.Windows.Forms.Label();
            this.textBoxMean = new System.Windows.Forms.TextBox();
            this.textBoxVariance = new System.Windows.Forms.TextBox();
            this.textBoxStdDev = new System.Windows.Forms.TextBox();
            this.textBoxCovariance = new System.Windows.Forms.TextBox();
            this.textBoxPearson = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(69, 26);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(84, 23);
            this.xTextBox.TabIndex = 0;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(69, 55);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(84, 23);
            this.yTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(69, 92);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 33);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(35, 29);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 15);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(69, 141);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(84, 33);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // listBoxPoints
            // 
            this.listBoxPoints.FormattingEnabled = true;
            this.listBoxPoints.ItemHeight = 15;
            this.listBoxPoints.Location = new System.Drawing.Point(195, 26);
            this.listBoxPoints.Name = "listBoxPoints";
            this.listBoxPoints.Size = new System.Drawing.Size(79, 214);
            this.listBoxPoints.TabIndex = 7;
            // 
            // labelMean
            // 
            this.labelMean.AutoSize = true;
            this.labelMean.Location = new System.Drawing.Point(354, 29);
            this.labelMean.Name = "labelMean";
            this.labelMean.Size = new System.Drawing.Size(37, 15);
            this.labelMean.TabIndex = 8;
            this.labelMean.Text = "Mean";
            // 
            // labelVariance
            // 
            this.labelVariance.AutoSize = true;
            this.labelVariance.Location = new System.Drawing.Point(340, 71);
            this.labelVariance.Name = "labelVariance";
            this.labelVariance.Size = new System.Drawing.Size(51, 15);
            this.labelVariance.TabIndex = 9;
            this.labelVariance.Text = "Variance";
            // 
            // labelStdDev
            // 
            this.labelStdDev.AutoSize = true;
            this.labelStdDev.Location = new System.Drawing.Point(284, 114);
            this.labelStdDev.Name = "labelStdDev";
            this.labelStdDev.Size = new System.Drawing.Size(107, 15);
            this.labelStdDev.TabIndex = 10;
            this.labelStdDev.Text = "Standard Deviation";
            // 
            // labelCovariance
            // 
            this.labelCovariance.AutoSize = true;
            this.labelCovariance.Location = new System.Drawing.Point(325, 159);
            this.labelCovariance.Name = "labelCovariance";
            this.labelCovariance.Size = new System.Drawing.Size(66, 15);
            this.labelCovariance.TabIndex = 11;
            this.labelCovariance.Text = "Covariance";
            // 
            // labelCorrelation
            // 
            this.labelCorrelation.AutoSize = true;
            this.labelCorrelation.Location = new System.Drawing.Point(280, 205);
            this.labelCorrelation.Name = "labelCorrelation";
            this.labelCorrelation.Size = new System.Drawing.Size(111, 15);
            this.labelCorrelation.TabIndex = 12;
            this.labelCorrelation.Text = "Pearson Correlation";
            // 
            // textBoxMean
            // 
            this.textBoxMean.Location = new System.Drawing.Point(397, 26);
            this.textBoxMean.Name = "textBoxMean";
            this.textBoxMean.Size = new System.Drawing.Size(74, 23);
            this.textBoxMean.TabIndex = 13;
            // 
            // textBoxVariance
            // 
            this.textBoxVariance.Location = new System.Drawing.Point(397, 68);
            this.textBoxVariance.Name = "textBoxVariance";
            this.textBoxVariance.Size = new System.Drawing.Size(74, 23);
            this.textBoxVariance.TabIndex = 14;
            // 
            // textBoxStdDev
            // 
            this.textBoxStdDev.Location = new System.Drawing.Point(397, 111);
            this.textBoxStdDev.Name = "textBoxStdDev";
            this.textBoxStdDev.Size = new System.Drawing.Size(74, 23);
            this.textBoxStdDev.TabIndex = 15;
            // 
            // textBoxCovariance
            // 
            this.textBoxCovariance.Location = new System.Drawing.Point(397, 156);
            this.textBoxCovariance.Name = "textBoxCovariance";
            this.textBoxCovariance.Size = new System.Drawing.Size(74, 23);
            this.textBoxCovariance.TabIndex = 16;
            // 
            // textBoxPearson
            // 
            this.textBoxPearson.Location = new System.Drawing.Point(397, 202);
            this.textBoxPearson.Name = "textBoxPearson";
            this.textBoxPearson.Size = new System.Drawing.Size(74, 23);
            this.textBoxPearson.TabIndex = 17;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(69, 190);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(84, 30);
            this.calculateButton.TabIndex = 18;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 291);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.textBoxPearson);
            this.Controls.Add(this.textBoxCovariance);
            this.Controls.Add(this.textBoxStdDev);
            this.Controls.Add(this.textBoxVariance);
            this.Controls.Add(this.textBoxMean);
            this.Controls.Add(this.labelCorrelation);
            this.Controls.Add(this.labelCovariance);
            this.Controls.Add(this.labelStdDev);
            this.Controls.Add(this.labelVariance);
            this.Controls.Add(this.labelMean);
            this.Controls.Add(this.listBoxPoints);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Name = "Form1";
            this.Text = "Statistic program by Hubert Wlodarczyk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox xTextBox;
        private TextBox yTextBox;
        private Button addButton;
        private Label labelX;
        private Label label2;
        private Button removeButton;
        private ListBox listBoxPoints;
        private Label labelMean;
        private Label labelVariance;
        private Label labelStdDev;
        private Label labelCovariance;
        private Label labelCorrelation;
        private TextBox textBoxMean;
        private TextBox textBoxVariance;
        private TextBox textBoxStdDev;
        private TextBox textBoxCovariance;
        private TextBox textBoxPearson;
        private Button calculateButton;
    }
}