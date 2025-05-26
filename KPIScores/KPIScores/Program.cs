using KPIScores.Readers;
using KPIScores.Utils;
using KPIScores.Writers;
using System;
using System.IO;
using System.Text;

namespace KPIScores
{
    /// <summary>
    /// Головний клас програми: координує зчитування,
    /// обчислення та вивід/запис результатів.
    /// </summary>
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // TODO: Отримати шлях до поточної робочої директорії проекту
            //       (тут будуть розміщені папка "КПІ" та в результаті -- файл results.txt)

            // TODO: Сформувати повний шлях до папки "КПІ", де лежать підпапки з оцінками

            // TODO: Створити об’єкт SubjectLoader і викликати метод зчитування усіх предметів із папки "КПІ"

            // TODO: Створити об’єкт GradesCalculator, обчислити середній бал для кожного предмету
            //       та загальний середній бал по всіх оцінках

            // TODO: Створити об’єкт ResultsWriter і записати у файл results.txt
            //       середні бали по предметах та загальний середній

            // TODO: Вивести повідомлення в консоль про успішне збереження результатів

            // TODO: Створити об’єкт DirectoryPrinter і рекурсивно вивести у консоль
            //       структуру папки "КПІ" з розмірами кожного файлу

        }
    }
}
