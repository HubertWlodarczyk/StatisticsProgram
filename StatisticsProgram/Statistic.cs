namespace StatisticLibrary
{
    public class Statistic
    {
        public double Mean(double[] numbersSet)
        {
            double sum = 0;
            foreach (double number in numbersSet)
            {
                sum += number;
            }
            return sum / numbersSet.Length;
        }
        public double Variance(double[] numbersSet)
        {
            double sum = 0;
            double mean = Mean(numbersSet);
            foreach (double number in numbersSet)
            {
                sum += Math.Pow(number - mean, 2);
            }
            return sum / numbersSet.Length;
        }
        public double StdDeviation(double[] numbersSet)
        {
            return Math.Sqrt(Variance(numbersSet));
        }
        public double Covariance(double[] numbersSetX, double[] numbersSetY)
        {
            double[] product = new double[numbersSetX.Length];
            for (int i = 0; i < numbersSetX.Length; i++)
            {
                product[i] = numbersSetX[i] * numbersSetY[i];
            }
            return Mean(product) - (Mean(numbersSetX) * Mean(numbersSetY));
        }
        public double PearsonCorrelation(double[] numbersSetX, double[] numbersSetY)
        {
            return Covariance(numbersSetX, numbersSetY) / (StdDeviation(numbersSetX) * StdDeviation(numbersSetY));
        }
    }

}