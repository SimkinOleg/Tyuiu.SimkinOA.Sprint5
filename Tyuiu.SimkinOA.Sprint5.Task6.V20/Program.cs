using System.IO;
using Tyuiu.SimkinOA.Sprint5.Task6.V20.Lib;
namespace Tyuiu.SimkinOA.Sprint5.Task6.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            
            string tempPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "InPutDataFileTask6V20.txt");
            Console.WriteLine($"Используется файл: {tempPath}");


            int count = ds.LoadFromDataFile(tempPath);
            Console.WriteLine($"Количество слов длиной 6 символов: {count}");
        }
    }
}