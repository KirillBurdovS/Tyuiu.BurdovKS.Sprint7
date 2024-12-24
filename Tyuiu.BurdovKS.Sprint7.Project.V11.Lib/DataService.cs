





using System.IO;



namespace Tyuiu.BurdovKS.Sprint7.Project.V11.Lib
{
    public class DataService
    {

        public Dictionary<string, int> AnalyzeHeight(string filePath) // Для роста 
        {
            var heightCounts = new Dictionary<string, int>();

            // Чтение данных из файла
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var data = line.Split(',');
                if (data.Length > 0)
                {
                    var height = data[0]; // Предположим, что рост находится в первой колонке
                    if (heightCounts.ContainsKey(height))
                    {
                        heightCounts[height]++;
                    }
                    else
                    {
                        heightCounts[height] = 1;
                    }
                }
            }

            return heightCounts;
        }






    }
}




