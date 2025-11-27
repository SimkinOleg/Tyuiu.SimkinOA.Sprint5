using Tyuiu.SimkinOA.Sprint5.Task4.V6.Lib;
namespace Tyuiu.SimkinOA.Sprint5.Task4.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #5 | Выполнил: Симкин О.А. | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Симкин Олег Андреевич | РППб-25-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask4V0.txt                       *");
            Console.WriteLine("* (файл взять из архива согласно вашему варианту).                        *");
            Console.WriteLine("* Создать папку вручную C:\\DataSprint5\\ и скопировать в неё файл.        *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо X в формуле.            *");
            Console.WriteLine("* Вычислить значение по формуле.                                          *");
            Console.WriteLine("* Полученное значение округлить до трёх знаков после запятой.             *");
            Console.WriteLine("* Вернуть полученный результат на консоль.                                *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask4V6.txt";
            Console.WriteLine("Данные находятся в файле : " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}