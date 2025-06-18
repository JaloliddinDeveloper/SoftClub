////Task: 1
//List<int> numbers = new List<int> { 1, 2, 3, 2, 4 };
//int target = 2;
//int lastIndex = numbers.LastIndexOf(target);
//Console.WriteLine("Last index of " + target + ": " + lastIndex);

////Task: 2
//List<int> mainList = new List<int> { 1, 2, 3, 4, 5 };
//List<int> subList = new List<int> { 2, 4 };

//bool containsAll = subList.All(item => mainList.Contains(item));
//Console.WriteLine("Contains all: " + containsAll);

////Task: 3
//List<int> intNumbers = new List<int> { 1, 2, 3, 4, 5 };
//intNumbers.Reverse();
//Console.WriteLine(string.Join(", ", intNumbers));

////Task: 4
//List<int> nums = new List<int>();
//bool isEmpty = !nums.Any();
//Console.WriteLine("Is list empty: " + isEmpty);

//// Task: 5
//List<int> sonlar = new List<int> { 10, 20, 30, 40, 50 };
//List<int> inrSubList = sonlar.GetRange(1, 3);
//Console.WriteLine(string.Join(", ", inrSubList));

//Task: 6
List<int> numbers = new List<int> { 5, 2, 8, 1, 3 };
numbers.Sort();
Console.WriteLine(string.Join(", ", numbers));

//Task: 7
List<string> items = new List<string> { "a", "b", "c" };
items.Clear();
Console.WriteLine("List count after clear: " + items.Count);


//Task: 8
List<int> intNumbers = new List<int> { 5, 2, 9, 1, 7 };
int max = intNumbers.Max();
int min = intNumbers.Min();
Console.WriteLine("Max: " + max + ", Min: " + min);

//Task: 9
List<int> sonlar = new List<int> { 1, 2, 3, 4, 5, 6 };
numbers.RemoveAll(n => n % 2 == 0);
Console.WriteLine(string.Join(", ", sonlar));

//Task: 10
List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
Random rng = new Random();
nums = nums.OrderBy(x => rng.Next()).ToList();
Console.WriteLine(string.Join(", ", nums));









