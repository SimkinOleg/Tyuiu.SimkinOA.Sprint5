using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SimkinOA.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
{
    public double LoadFromDataFile(string path)
    {
        double res = 0;
        int x = 0;
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (!line.Contains(" "))
                {
                    x++;
                    res += Convert.ToDouble(line);
                }

            }
        }

        return Math.Round((res / x), 3);

    }
}
}