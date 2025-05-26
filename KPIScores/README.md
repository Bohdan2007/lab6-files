```markdown
# KPI Scores

Програма зчитує оцінки зі структури каталогів `КПІ`, обчислює середній бал по кожному предмету та загальний середній, записує результати у файл `results.txt` і виводить у консоль рекурсивну структуру папки `КПІ` з розмірами файлів.

---

## Структура проєкту

```

/KPIScores
│
├─ /КПІ              ← Ваша папка з підпапками-предметами
│   ├─ /Subject1
│   │   └─ scores.txt  (рядки формату: "<score> \<dd.MM.yyyy>")
│   ├─ /Subject2
│   │   └─ scores.txt
│   └─ … (інші предмети)
│
├─ ScoreEntry.cs
├─ Subject.cs
├─ SubjectLoader.cs   ← містить TODO для зчитування файлів
├─ GradesCalculator.cs← містить TODO для обчислення середніх
├─ ResultsWriter.cs   ← містить TODO для запису в файл
├─ DirectoryPrinter.cs← містить TODO для виводу дерева папок
├─ Program.cs         ← містить TODO кроків виконання
└─ README.md          ← цей файл

````

---

## Кроки виконання

1. **Клонувати репозиторій**

   ```bash
   git clone <URL_репозиторію>
   cd KPI_GradesReader
````

2. **Налаштувати копіювання папки `КПІ`**

   * У Visual Studio / VS Code:

     * Виберіть папку `КПІ` в Explorer.
     * Властивості → **Copy to Output Directory** → **Copy if newer**.

3. **Реалізувати `TODO`-заглушки**

   * **SubjectLoader.cs**

     ```csharp
     public List<Subject> LoadSubjects(string kpiDir)
     {
         // TODO: …
         throw new NotImplementedException();
     }
     ```

     – зчитати всі підпапки, парсити `scores.txt` рядки `<score> <dd.MM.yyyy>`.

   * **GradesCalculator.cs**

     ```csharp
     public Dictionary<string,double> CalculateAveragePerSubject(...) { /* TODO */ }
     public double CalculateOverallAverage(...) { /* TODO */ }
     ```

     – порахувати середній бал по кожному предмету та загальний.

   * **ResultsWriter.cs**

     ```csharp
     public void Write(string path, Dictionary<string,double> avg, double overall)
     {
         // TODO: відкрити StreamWriter, записати avg і overall
         throw new NotImplementedException();
     }
     ```

   * **DirectoryPrinter.cs**

     ```csharp
     public void PrintTree(string root, int indent=0)
     {
         // TODO: рекурсивно друкувати папки та файли із розмірами
         throw new NotImplementedException();
     }
     ```

   * **Program.cs**

     ```csharp
     static void Main()
     {
         Console.OutputEncoding = Encoding.UTF8;

         // TODO: визначити projectDir і kpiDir
         // TODO: завантажити subjects через SubjectLoader
         // TODO: обчислити avgBySubj і overall через GradesCalculator
         // TODO: записати results.txt через ResultsWriter
         // TODO: повідомити про успіх у консолі
         // TODO: надрукувати структуру через DirectoryPrinter

         throw new NotImplementedException();
     }
     ```

4. **Побудова та запуск**

   ```bash
   dotnet build
   dotnet run
   ```

5. **Перевірка результатів**

   * Файл **results.txt** в корені проєкту містить:

     ```
     Subject1: 85.50
     Subject2: 92.00
     …
     ------------------------------
     Overall average: 88.75
     ```
   * Консоль виводить:

     ```
     КПІ/
       Subject1/
         scores.txt (123 bytes)
       Subject2/
         scores.txt (98 bytes)
       …
     ```

---
