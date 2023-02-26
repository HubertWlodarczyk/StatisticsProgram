namespace StatisticsProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBoxPoints.Sorted = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string point = xTextBox.Text + ';' + yTextBox.Text;
                if (String.IsNullOrEmpty(xTextBox.Text) || String.IsNullOrEmpty(yTextBox.Text))
                {
                    xTextBox.Text = "One value is empty";
                    return;
                }
                if ((double.TryParse(xTextBox.Text, out _) && double.TryParse(yTextBox.Text, out double _)) == false)
                {
                    xTextBox.Text = "This is not number";
                    return;
                }
                foreach (string number in listBoxPoints.Items)
                {
                    if (xTextBox.Text == number.Split(';')[0])
                    {
                        xTextBox.Text = "Math error";
                        return;
                    }
                }
                if (true == listBoxPoints.Items.Contains(point))
                {
                    return;
                }
                if (xTextBox.Text != null && yTextBox.Text != null) listBoxPoints.Items.Add(point);
                xTextBox.Text = String.Empty;
                yTextBox.Text = String.Empty;
            }
            catch (Exception error)
            {
                xTextBox.Text = error.Message;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxPoints.SelectedItem != null)
                {
                    string point = listBoxPoints.SelectedItem.ToString();
                    listBoxPoints.Items.Remove(point);
                }
            }
            catch (Exception error)
            {
                xTextBox.Text = error.Message;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxPoints.Items.Count != 0)
                {
                    int numberOfPoints = listBoxPoints.Items.Count;
                    double[] xArray = new double[numberOfPoints];
                    double[] yArray = new double[numberOfPoints];
                    string tempPoint;
                    for (int i = 0; i < numberOfPoints; i++)
                    {
                        tempPoint = listBoxPoints.Items[i].ToString();
                        xArray[i] = double.Parse(tempPoint.Split(';')[0]);
                        yArray[i] = double.Parse(tempPoint.Split(';')[1]);
                    }
                    StatisticLibrary.Statistic statistic = new StatisticLibrary.Statistic();
                    textBoxVariance.Text = statistic.Variance(yArray).ToString();
                    textBoxMean.Text = statistic.Mean(yArray).ToString();
                    textBoxStdDev.Text = statistic.StdDeviation(yArray).ToString();
                    textBoxPearson.Text = statistic.PearsonCorrelation(xArray, yArray).ToString();
                    textBoxCovariance.Text = statistic.Covariance(xArray, yArray).ToString();
                }
            }
            catch (Exception error)
            {
                xTextBox.Text = error.Message;
            }
        }
    }
}