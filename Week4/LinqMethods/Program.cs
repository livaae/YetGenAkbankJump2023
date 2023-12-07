
using System.Collections;

class Program
{
    static void Main()
    {
        #region Average
        List<int> grades = new List<int> { 78, 92, 100, 37, 81 };

        Console.WriteLine(Enumerable.Average(grades));
        //Console.WriteLine(grades.Average());
        #endregion


        #region Concat
        List<string> firstNames = new List<string> { "Alice", "Bob", "Charlie" };
        List<string> lastNames = new List<string> { "Doe", "Smith", "Brown" };

        // İsimleri birleştirme
        var combinedNames = firstNames.Concat(lastNames);

        // Birleştirilmiş isimleri yazdırma
        foreach (var name in combinedNames)
        {
            Console.Write(name + " ");
        }

        // Yeni bir koleksiyon oluşturalım
        List<double> numbers = new List<double> { 3.5, 6.7, 8.9, 2.1 };

        // Yeni koleksiyonun ortalamasını alalım
        Console.WriteLine("\n\nNumbers'ın Ortalaması: " + Enumerable.Average(numbers));
        // Alternatif olarak
        Console.WriteLine("Numbers'ın Ortalaması: " + numbers.Average());
        #endregion

        #region Distinct
        List<int> numbers3 = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

        // Distinct kullanarak benzersiz sayıları bulma
        var distinctNumbers = numbers3.Distinct();

        // Benzersiz sayıları yazdırma
        Console.WriteLine("Benzersiz Sayılar:");
        foreach (var number in distinctNumbers)
        {
            Console.WriteLine(number);
        }

        // Özel bir karşılaştırıcı kullanarak Distinct kullanımı
        List<string> fruits = new List<string> { "apple", "Orange", "banana", "APPLE", "orange" };

        var distinctFruits = fruits.Distinct(StringComparer.OrdinalIgnoreCase);

        // Benzersiz meyveleri yazdırma
        Console.WriteLine("\nBenzersiz Meyveler:");
        foreach (var fruitsa in distinctFruits)
        {
            Console.WriteLine(fruits);
        }

        #endregion

        #region Skip
        List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // İlk 5 elemanı atlayarak kalanları almak
        var remainingNumbers = numbers1.Skip(5);

        // Kalan sayıları yazdırma
        Console.WriteLine("Atlanan Sayılar:");
        foreach (var number in remainingNumbers)
        {
            Console.WriteLine(number);
        }
        #endregion

        #region Take

        List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // İlk 3 elemanı almak
        var firstThreeNumbers = numbers2.Take(3);

        // İlk üç sayıyı yazdırma
        Console.WriteLine("İlk Üç Sayı:");
        foreach (var number in firstThreeNumbers)
        {
            Console.WriteLine(number);
        }
        #endregion

        #region Cast
        ArrayList mixedList = new ArrayList(); // ArrayList, farklı türlerde öğeleri içerebilir
        mixedList.Add(10);
        mixedList.Add("20");
        mixedList.Add(30);
        mixedList.Add("40");

        // Öğeleri integer türüne dönüştürerek almak
        var integers = mixedList.Cast<int>();

        // Dönüştürülmüş integer değerleri yazdırma
        Console.WriteLine("Dönüştürülmüş Integer Değerler:");
        foreach (var number in integers)
        {
            Console.WriteLine(number);
        }
        #endregion

        #region Count
        string[] fruit = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

        try
        {
            int numberOfFruits = fruit.Count();
            Console.WriteLine(
                "There are {0} fruits in the collection.",
                numberOfFruits);
        }
        catch (OverflowException)
        {
            Console.WriteLine("The count is too large to store as an Int32.");
            Console.WriteLine("Try using the LongCount() method instead.");
        }
        #endregion

        #region Empty
        string[] names1 = { "Hartono, Tommy" };
        string[] names2 = { "Adams, Terry", "Andersen, Henriette Thaulow",
                      "Hedlund, Magnus", "Ito, Shu" };
        string[] names3 = { "Solanki, Ajay", "Hoeing, Helge",
                      "Andersen, Henriette Thaulow",
                      "Potra, Cristina", "Iallo, Lucio" };

        List<string[]> namesList =
            new List<string[]> { names1, names2, names3 };

        // Only include arrays that have four or more elements
        IEnumerable<string> allNames =
            namesList.Aggregate(Enumerable.Empty<string>(),
            (current, next) => next.Length > 3 ? current.Union(next) : current);

        foreach (string name in allNames)
        {
            Console.WriteLine(name);
        }
        #endregion

        #region First
        int[] num = { 9, 34, 65, 92, 87, 435, 3, 54,
                    83, 23, 87, 435, 67, 12, 19 };

        int first = num.First();

        Console.WriteLine(first);
        #endregion

    }
}










