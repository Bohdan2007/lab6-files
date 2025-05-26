namespace KPIScores.Utils
{
    /// <summary>
    /// Рекурсивно друкує дерево каталогу з розмірами файлів.
    /// </summary>
    public class DirectoryPrinter
    {
        /// <summary>
        /// Виводить у консоль структуру <paramref name="root"/> з глибиною <paramref name="indent"/>.
        /// Для кожного файлу вивести ще його розмір у байтах.
        /// </summary>
        public void PrintTree(string root, int indent = 0)
        {
            if (root == null)
            {
                Console.WriteLine("Директорія не існує");
            }

            foreach (var i in Directory.GetFiles(root))
            {
                var info = new FileInfo(i);
                Console.WriteLine($"{info.Name} ({info.Length})");
            }

            foreach (var i in Directory.GetDirectories(root))
            {
                PrintTree(i, indent++);
            }
        }
    }
}
