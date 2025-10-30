
IEnumerable<int> Normal(int[] array)
{
    List<int> result = new List<int>();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            result.Add(array[i] * 2);
    }

    result.Sort();
    return result;
}

IEnumerable<int> KeywordBased(int[] array)
{
   var result = from i in array
                where i % 2 == 0
                orderby i 
                select i * 2;
   return result;
}

IEnumerable<int> MethodCallBased(int[] array)
{
    return array.Where(i => i % 2 == 0)
        .OrderBy(i => i)
        .Select(i => i * 2);
}

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("Normal method:");
Console.WriteLine(string.Join(", ", Normal(array)));

Console.WriteLine("\nKeyword-based (Query Syntax):");
Console.WriteLine(string.Join(", ", KeywordBased(array)));

Console.WriteLine("\nMethod-based (LINQ):");
Console.WriteLine(string.Join(", ", MethodCallBased(array)));
