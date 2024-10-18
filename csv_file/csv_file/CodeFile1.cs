using System;//основные классы
using System.IO;//для работы с файлами

class CodeFile1
{
    static void Main(string[] args)
    {
        //Ссылка на файл
        string URL = "C:\\work\\CompletedTasks\\csv_file\\csv_file\\example.csv";
        //проверка на наличие файла
        if (File.Exists(URL))
        {
            // Чтение файла
            string[] lines = File.ReadAllLines(URL);
            int maxLength = 0;

            // Находим максимальную длину строк
            foreach (var line in lines)
            {
                var columns = line.Split(',');
                foreach (var column in columns)
                {
                    maxLength = Math.Max(maxLength, column.Trim().Length);
                }
            }

            // Вывод с одинаковым размером
            foreach (var line in lines)
            {
                var columns = line.Split(',');
                foreach (var column in columns)
                {
                    Console.Write($"|{column.Trim().PadRight(maxLength)} ");
                }
                Console.WriteLine("|");
            }
        }
        else
        {
            Console.WriteLine("Файл не найден");
        }
    }
}
