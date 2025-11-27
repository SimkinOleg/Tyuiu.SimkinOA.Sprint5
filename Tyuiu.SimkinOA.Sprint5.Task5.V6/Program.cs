using Tyuiu.SimkinOA.Sprint5.Task5.V6.Lib;
namespace Tyuiu.SimkinOA.Sprint5.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Симкин О.А.| РППб-25-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #5                                                            *");
            Console.WriteLine("* Тема:                                                                *");
            Console.WriteLine("* Задание #5                                                           *");
            Console.WriteLine("* Вариант #6                                                           *");
            Console.WriteLine("* Выполнил: Симкин Олег Андреевич  | РППб-25-1                         *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask5V6.txt";
            Console.WriteLine("данные находятся в файле: " + path);

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("среднее значение = " + res);
            
            Console.ReadKey();
        }
    }
} 