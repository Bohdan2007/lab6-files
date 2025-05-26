namespace KPIScores.Models
{
    /// <summary>
    /// Інформація про предмет: назва та список оцінок.
    /// </summary>
    public class Subject
    {
        /// <summary>Назва предмету (ім'я папки).</summary>
        public string Name { get; set; }

        /// <summary>Колекція оцінок із файлу scores.txt.</summary>
        public List<ScoreEntry> Scores { get; set; } = new List<ScoreEntry>();
    }
}
