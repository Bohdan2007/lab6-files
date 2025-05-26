namespace KPIScores.Models
{
    /// <summary>
    /// Одна оцінка з прикріпленою датою.
    /// </summary>
    public class ScoreEntry
    {
        /// <summary>Числове значення оцінки.</summary>
        public int Score { get; set; }

        /// <summary>Дата виставлення оцінки.</summary>
        public DateTime Date { get; set; }
    }
}
