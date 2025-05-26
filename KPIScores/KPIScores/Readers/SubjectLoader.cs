using KPIScores.Models;
using System.Runtime.Serialization.Formatters;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KPIScores.Readers
{
    /// <summary>
    /// Відповідає за зчитування предметів із папки "КПІ"
    /// та парсинг їхніх файлів оцінок (формат: "92 12.02.2024").
    /// </summary>
    public class SubjectLoader
    {
        /// <summary>
        /// Зчитує всі підпапки <paramref name="kpiDir"/> як окремі предмети.
        /// </summary>
        public List<Subject> LoadSubjects(string kpiDir)
        {
            // TODO: Якщо папка не існує — повернути порожній список
            // TODO: Для кожної підпапки:            
            //   - Зчитати файл scores.txt
            //   - Для кожного рядка "score date"                  
            var subjects = new List<Subject>();
            var list = new List<ScoreEntry>();
            var subDir = Directory.GetDirectories(kpiDir);
            int score = 0;
            DateTime date;

            if (Directory.Exists(kpiDir))
            {
                return subjects;
            }
            
            foreach ( var subdir in subDir)
            {
                var subjectName = Path.GetFileName(subdir);

                if (!File.Exists("scores.txt"))
                {
                    continue;
                }

                foreach (var line in File.ReadAllLines("scores.txt"))
                {
                    string scoreString = "" + line[0] + line[1];
                    score = int.Parse(scoreString);
                    string dateString = null;
                    for (int i = 2; i < line.Length; i++)
                    {
                        dateString += line[i];
                    }
                    date = DateTime.Parse(dateString);

                    var scoreEntry = new ScoreEntry() { Score = score, Date = date}; 
                    list.Add(scoreEntry);   
                }
                var subject = new Subject() { Name = subjectName, Scores = list};
                subjects.Add(subject);
            }

            return subjects;
        }
    }
}
