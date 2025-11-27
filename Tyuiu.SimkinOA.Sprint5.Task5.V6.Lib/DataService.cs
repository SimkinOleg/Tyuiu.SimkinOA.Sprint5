using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SimkinOA.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double count = 0;
            string data = File.ReadAllText(path);
            string[] strings = data.Split(' ');

            var number = new List<double>();
            foreach (string s in strings)
            {
                double nunber = double.Parse(s, CultureInfo.InvariantCulture);
                number.Add(nunber);
            }

            foreach (double nunber in number)
            {
                res += nunber;
                count++;
            }

            res = res / count;
            return Math.Round(res, 3);
        }
    }
}