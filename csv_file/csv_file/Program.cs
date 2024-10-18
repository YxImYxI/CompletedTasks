using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string URL = "C:\\work\\CompletedTasks\\csv_file\\csv_file\\example.csv";

        if (File.Exists(URL))
        {
            // Чтение всех линий файла
            string[] lines = File.ReadAllLines(URL);
            foreach (var line in lines)
            {
                var columns = line.Split(','); // разделяем строку по запятой
                foreach (var column in columns)
                {
                    Console.Write($"|{column.Trim()} "); // удаляем лишние пробелы
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