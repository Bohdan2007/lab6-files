namespace KPIScores.Writers
{
    /// <summary>
    /// Відповідає за запис середніх балів у текстовий файл.
    /// </summary>
    public class ResultsWriter
    {
        /// <summary>
        /// Записує у файл <paramref name="path"/> середні по предметах і загальний середній.
        /// </summary>
        public void Write(string path, Dictionary<string, double> averages, double overall)
        {
            // TODO: Відкрити StreamWriter(path, overwrite)
            // TODO: Для кожної пари в averages --> WriteLine("{Key} {Value:F2}")            
            // TODO: WriteLine($"{overall:F2}")
            throw new NotImplementedException();
        }
    }
}
