var numbers = new List<int> { 3, 7, 2, 8, 1, 9, 4, 6, 5 };
PrintNumbers("Original", numbers);

var evenSortedNumbers = numbers
    .Where(n => n % 2 == 0)
    .OrderBy(n => n)
    .ToList();
PrintNumbers("Jämna", evenSortedNumbers);

var doubledNumbers = numbers
    .Select(n => n * 2)
    .Where(n => n >= 10)
    .OrderBy(n => n)
    ;
PrintNumbers("Dubblade Original (Justerade)", doubledNumbers.ToList());

static void PrintNumbers(string title, List<int> numbers)
{
    Console.WriteLine($"{title}: [{string.Join(", ", numbers)}]");
}
