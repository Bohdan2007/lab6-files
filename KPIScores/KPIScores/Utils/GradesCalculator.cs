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
            var averages = new Dictionary<string, double>();

            foreach (var subject in subjects)
            {
                if (subject.Scores.Count > 0)
                {
                    double avg = subject.Scores.Average(e => e.Score);
                    averages[subject.Name] = avg;
                }
                else 
                {
                    averages[subject.Name] = 0.0;
                }
            }

            return averages;    
        }

        /// <summary>
        /// Обчислює загальний середній бал по всім рейтингам.
        /// </summary>
        public double CalculateOverallAverage(IEnumerable<Subject> subjects)
        {
            var overall = new Dictionary<string, double>();
            overall = CalculateAveragePerSubject(subjects);
            double sum = 0;
            if (overall.Count == 0)
            {
                return 0;
            }
            else 
            { 
                foreach (var subject in overall)
                {
                    sum += subject.Value;
                }
            }


            return sum/ overall.Count;
        }
    }
}
