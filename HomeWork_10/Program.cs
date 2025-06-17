//Task_1
List<int> numbers = new List<int>
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};
int som = 0;
for (int i = 0; i < numbers.Count; i++)
{
    som += numbers[i];
}
for (int i = 0; i < numbers.Count; i++)
{
    Console.Write($"{numbers[i]}");
    if (i != numbers.Count - 1)
    {
        Console.Write("+");
    }
}
Console.Write($"={som}");
Console.WriteLine();

// Task 2:

List<string> strings = new List<string>
{
    "Hello", "World", "C#", "Programming"
};
string concatenate = "";
foreach (var str in strings)
{
    concatenate += str + " ";
}
Console.WriteLine(concatenate);

// Task 3:
List<DateTime> dates = new List<DateTime>
{
    new DateTime(2022, 1, 1),
    new DateTime(2020, 2, 14),
    new DateTime(2023, 3, 17)
};

dates.Sort();

foreach (DateTime dt in dates)
{
    Console.WriteLine(dt);
}

// Task 4:
Console.WriteLine("Everage: ");
List<double> doubles = new List<double> { 3.5, 2.7, 6.9, 1.2 };
double sumDoubles = 0;
double countDoubles = doubles.Count;

foreach (double d in doubles)
{
    sumDoubles += d;
}
Console.WriteLine($"Average: {sumDoubles / countDoubles}");

// Task 5:
Console.WriteLine("Odd and Even numbers: ");
List<int> nums = new List<int>();

for (int i = 1; i <= 10; i++)
{
    int randomNumber = new Random().Next(1, 100);
    nums.Add(randomNumber);
}
foreach (int num in nums)
{
    if (num % 2 == 0)
    {
        Console.WriteLine($"{num} is even");
    }
    else
    {
        Console.WriteLine($"{num} is odd");
    }
}

// Task 6:
Console.WriteLine("All true");
List<bool> bools = new List<bool> { true, true, true, true };

bool allTrue = bools.All(b => b == true);

Console.WriteLine($"AllTrue {allTrue}");

// Task 7:
Console.WriteLine("Remove List");
List<int> intNnumbers = new List<int> { 1, 2, 3, 4, 5 };
intNnumbers.Remove(1);

Console.WriteLine("After removing 1: ");
foreach (int num in intNnumbers)
{
    Console.WriteLine(num);
}
// Task 8:

Console.WriteLine("Searching an element in a list");
List<int> newList = new List<int>
{
   1, 2, 3, 4, 8, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
};
int searchElement = 2;
int right = newList.Count - 1;
int left = 0;
while (left <= right)
{
    int mid = (left + right) / 2;
    if (newList[mid] == searchElement)
    {
        Console.WriteLine($"Element found at index {mid}");
        break;
    }
    else if (newList[mid] > searchElement)
    {
        right = mid - 1;
    }
    else
    {
        left = mid + 1;
    }
}


//Task 9:
//Task 10:
Console.WriteLine("Fill a list random number and display");

List<int> randomNumbers = new List<int>();

for (int i = 0; i < 10; i++)
{
    randomNumbers.Add(new Random().Next(1, 100));
}

foreach (int num in randomNumbers)
{
    Console.WriteLine(num);
}
