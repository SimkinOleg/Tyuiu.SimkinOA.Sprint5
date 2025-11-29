using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SimkinOA.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {
            string fileContent = File.ReadAllText(path);
            string modifiedContent = Regex.Replace(fileContent, " ", "");
            string outputDirectory = Path.GetTempPath();
            string outputFileName = "OutPutDataFileTask7V26.txt";
            string outputFilePath = Path.Combine(outputDirectory, outputFileName);
            File.WriteAllText(outputFilePath, modifiedContent);
            return outputFilePath;
        }
    }
}