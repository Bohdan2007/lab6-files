# KPI Scores

Програма зчитує оцінки зі структури каталогів `КПІ`, обчислює середній бал по кожному предмету та загальний середній, записує результати у файл `results.txt` і виводить у консоль рекурсивну структуру папки `КПІ` з розмірами файлів.

---

## Структура проєкту

```text
/KPIScores
│
├─ /КПІ                    ← папка з підпапками-предметами
│   ├─ /Subject1
│   │   └─ scores.txt      (рядки формату: "<score> <dd.MM.yyyy>")
│   ├─ /Subject2
│   │   └─ scores.txt
│   └─ … (інші предмети)
│
├─ ScoreEntry.cs           ← описує одну оцінку з датою
├─ Subject.cs              ← модель предмета з колекцією ScoreEntry
├─ SubjectLoader.cs        ← містить TODO для зчитування файлів
├─ GradesCalculator.cs     ← містить TODO для обчислення середніх
├─ ResultsWriter.cs        ← містить TODO для запису результатів
├─ DirectoryPrinter.cs     ← містить TODO для виводу дерева каталогів
├─ Program.cs              ← містить TODO для послідовності кроків Main
└─ README.md               ← цей файл
```


---

## Кроки виконання

1. **Клонувати репозиторій**

   ```bash
   git clone <URL_репозиторію>
   cd KPIScores
   ```

2. **Налаштувати Copy to Output Directory**
   У Visual Studio / VS Code:

   * Виберіть папку `КПІ`
   * Властивості → **Copy to Output Directory** → **Copy if newer**

3. **Реалізувати TODO**

   * **SubjectLoader.cs**

     ```csharp
     public List<Subject> LoadSubjects(string kpiDir)
     {
         // TODO: прочитати всі підпапки, зчитати scores.txt ("<score> <dd.MM.yyyy>") → List<ScoreEntry>
         throw new NotImplementedException();
     }
     ```
   * **GradesCalculator.cs**

     ```csharp
     public Dictionary<string,double> CalculateAveragePerSubject(...)
     {
         // TODO: порахувати середній для кожного предмету
         throw new NotImplementedException();
     }

     public double CalculateOverallAverage(...)
     {
         // TODO: порахувати загальний середній по всіх оцінках
         throw new NotImplementedException();
     }
     ```
   * **ResultsWriter.cs**

     ```csharp
     public void Write(string path, Dictionary<string,double> avg, double overall)
     {
         // TODO: записати avg і overall у файл results.txt
         throw new NotImplementedException();
     }
     ```
   * **DirectoryPrinter.cs**

     ```csharp
     public void PrintTree(string root, int indent=0)
     {
         // TODO: рекурсивно виводити папки та файли із розмірами в байтах
         throw new NotImplementedException();
     }
     ```
   * **Program.cs**

     ```csharp
     static void Main()
     {
         Console.OutputEncoding = Encoding.UTF8;

         // TODO: визначити projectDir і kpiDir
         // TODO: зчитати subjects через SubjectLoader
         // TODO: обчислити avgBySubj і overall через GradesCalculator
         // TODO: записати results.txt через ResultsWriter
         // TODO: вивести структуру через DirectoryPrinter
         throw new NotImplementedException();
     }
     ```

4. **Побудова та запуск**

   ```bash
   dotnet build
   dotnet run
   ```

5. **Перевірка результатів**

   * `results.txt` має містити середні бали по предметах та загальний середній:

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