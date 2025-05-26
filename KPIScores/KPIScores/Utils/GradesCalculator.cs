using KPIScores.Models;

namespace KPIScores.Utils
{
    /// <summary>
    /// Обчислює середні бали по предметах
    /// та загальний середній по всіх оцінках.
    /// </summary>
    public class GradesCalculator
    {
        /// <summary>
        /// Обчислює середній бал для кожного з <paramref name="subjects"/>.
        /// </summary>
        public Dictionary<string, double> CalculateAveragePerSubject(IEnumerable<Subject> subjects)
        {            
            // TODO: Для кожного Subject:
            //   - якщо Scores не пустий --> Average(e => e.Score)
            //   - інакше --> 0.0
            throw new NotImplementedException();
        }

        /// <summary>
        /// Обчислює загальний середній бал по всім рейтингам.
        /// </summary>
        public double CalculateOverallAverage(IEnumerable<Subject> subjects)
        {
            throw new NotImplementedException();
        }
    }
}
