using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SimkinOA.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            strx = strx.Replace(".", ",");
            string[] strings = strx.Split(' ');
            double res = 0;
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                foreach (string i in strings)
                {
                    if (Math.Round(Convert.ToDouble(i), 0) != Convert.ToDouble(i))
                    {
                        count++;
                        res += Convert.ToDouble(i);
                    }

                }
            }
            return Math.Round(res / count, 3);
        }
    }
}