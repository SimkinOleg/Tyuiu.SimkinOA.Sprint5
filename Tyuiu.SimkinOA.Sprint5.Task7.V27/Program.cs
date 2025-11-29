using Tyuiu.SimkinOA.Sprint5.Task7.V27.Lib;
namespace Tyuiu.SimkinOA.Sprint5.Task7.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Симкин О.А. | РППб-25-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #5                                                            *");
            Console.WriteLine("* Тема:                                                                *");
            Console.WriteLine("* Задание #7                                                           *");
            Console.WriteLine("* Вариант #27                                                          *");
            Console.WriteLine("* Выполнил: Симкин Олег Андреевич  | РППб-25-1                         *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");





            string path = @"C:\DataSprint5\InPutDataFileTask7V27.txt";
            var result = ds.LoadDataAndSave(path);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}