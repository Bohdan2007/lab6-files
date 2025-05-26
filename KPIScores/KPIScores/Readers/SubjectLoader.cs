using KPIScores.Models;

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
            throw new NotImplementedException();
        }
    }
}
