//Mahkamov Jaloliddin
//Data: 03.06.2025

////Task 1: Bank

//Console.Write("First deposit: ");
//decimal firstDeposit = decimal.Parse(Console.ReadLine());
//Console.Write("Second deposit: ");
//decimal secondDeposit = decimal.Parse(Console.ReadLine());
//Console.Write("Third deposit: ");
//decimal thirdDeposit = decimal.Parse(Console.ReadLine());

//decimal firstInterest = CalculateInterest(firstDeposit);
//decimal secondInterest = CalculateInterest(secondDeposit);
//decimal thirdInterest = CalculateInterest(thirdDeposit);

//Console.WriteLine($"First deposit interest: {firstInterest:F2}");
//Console.WriteLine($"Second deposit interest: {secondInterest:F2}");
//Console.WriteLine($"Third deposit interest: {thirdInterest:F2}");

//static decimal CalculateInterest(decimal amount)
//{
//    decimal interestRate;

//    if (amount < 100)
//    {
//        interestRate = 0.05m;
//    }
//    else if (amount <= 200)
//    {
//        interestRate = 0.07m;
//    }
//    else
//    {
//        interestRate = 0.10m;
//    }

//    return amount * interestRate;
//}

////Task 2: Array
//int[] numbers = { 1, 2, 3, 4, 5 };
//int p = 1;

//foreach (int number in numbers)
//{
//    p *= number;
//}

//for(int i = 0; i < numbers.Length; i++)
//{
//    Console.Write(numbers[i]);
//    if (i!=numbers.Length-1)
//    {
//        Console.Write("*");
//    }
//}
//Console.WriteLine("="+p);

//Task 2.2: array and bracket

//int[] numbers = { -1, 1, -1, -1, 1 };

//int p = 1;

//foreach (int number in numbers)
//{
//    p *= number;
//}

//for(int i = 0; i < numbers.Length; i++)
//{
//    Console.Write($"({ numbers[i]})");
//    if (i != numbers.Length - 1)
//    {
//        Console.Write("*");
//    }
//}
//Console.WriteLine("=" + p);

//// Task 3: Array Max

//int[] numbers = { 4, 6, 7, 8, 0, 3, 11, 25 };

//int max = int.MinValue;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] > max)
//    {
//        max = numbers[i];
//    }
//}
//Console.WriteLine($"Max: {max}");

// Task 4: Array no repeat
// Task 4: Array no repeat
//int[] numbers = { 4, -9, 4, 3, 3, 2 };

//for (int i = 0; i < numbers.Length; i++)
//{
//    int have = 0;
//    for (int j = 0; j < numbers.Length; j++)
//    {
//        if (numbers[i] == numbers[j])
//        {
//            have++;
//        }
//    }

//    if (have == 1)
//    {
//        Console.Write(numbers[i] + " ");
//    }
//}

//Task 5:min index

//int[] numbers = { 4, -9, 4, 3, 3, 2 };
//int minIndex = 0;
//Console.WriteLine(minIndex);

//Task 6: Array max neighbours

//int[] numbers = { 2, 3, 1, 5, 4 };
//int s = 0;
//for (int i = 1; i <numbers.Length; i++)
//{
//    if(numbers[i-1] < numbers[i] && numbers[i] > numbers[i+1])
//    {
//        s++;
//    }
//}
//Console.WriteLine(s);

// Task 8: Array Odd element index
//int[] numbers = { 2, 3, 1, 5, 4 ,9};
//int s = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}
//Console.WriteLine(s);

// Task 9: 

//int[] numbers = { 2, 3, 1, 5, 4, 9 };
//int a=int.Parse(Console.ReadLine());
//int b=int.Parse(Console.ReadLine());
//for (int i = a; i <= b; i++)
//{
//    if (numbers[i] % 2 != 0)
//    {
//        Console.WriteLine(numbers[i]);
//    }
//}

//Task 10: 

//int[] numbers = { 2, 3, 1, 5, 4, 9 };

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 != 0)
//    {
//        Console.Write(numbers[i] * numbers[i] + " ");
//    }
//}

//Next file tasks
// Task 1: 

//int n = int.Parse(Console.ReadLine());

//Console.WriteLine("Even:" + EvenCount(n));
//Console.WriteLine("Odd:" + OddCount(n));
//Console.WriteLine("Digit:" + DigitCount(n));
//Console.WriteLine("Sum:" + SumDigit(n));

//static int EvenCount(int n)
//{
//    int count = 0;
//    while (n > 0)
//    {
//        int digit = n % 10;
//        if (digit % 2 == 0)
//        {
//            count++;
//        }
//        n /= 10;
//    }
//    return count;
//}

//static int OddCount(int n)
//{
//    int count = 0;
//    while (n > 0)
//    {
//        int digit = n % 10;
//        if (digit % 2 != 0)
//        {
//            count++;
//        }
//        n /= 10;
//    }
//    return count;
//}

//static int DigitCount(int n)
//{
//    int count = 0;
//    while (n > 0)
//    {
//        count++;
//        n /= 10;
//    }
//    return count;
//}

//static int SumDigit(int n)
//{
//    int sum = 0;
//    while (n > 0)
//    {
//        sum += n % 10;
//        n /= 10;
//    }
//    return sum;
//}

//Task 2:   


//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());

//Console.WriteLine("Add:" + Add(a, b));
//Console.WriteLine("Subtract:" + Subtract(a, b));
//Console.WriteLine("Multiply:" + Multiply(a, b));
//Console.WriteLine("Division:" + Division(a, b));

//static int Add(int a, int b)
//{
//    return a + b;
//}

//static int Subtract(int a, int b)
//{
//    return a - b;
//}

//static int Multiply(int a, int b)
//{
//    return a * b;
//}

//static int Division(int a, int b)
//{
//    if (b != 0)
//    {
//        return a / b;
//    }
//    else
//    {
//        Console.WriteLine("b is not 0");
//        return 0;
//    }
//}

//Task 3:

//int n = int.Parse(Console.ReadLine());

//int minDigit = MinDigit(n);
//int maxDigit = MaxDigit(n);

//Console.WriteLine($"{minDigit} + {maxDigit} = {minDigit + maxDigit}");

//static int MinDigit(int n)
//{
//    int min = 9;
//    while (n > 0)
//    {
//        int digit = n % 10;
//        if (digit < min)
//            min = digit;
//        n /= 10;
//    }
//    return min;
//}

//static int MaxDigit(int n)
//{
//    int max = 0;
//    while (n > 0)
//    {
//        int digit = n % 10;
//        if (digit > max)
//            max = digit;
//        n /= 10;
//    }
//    return max;
//}

// Task 4:
//int x = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());

//Console.WriteLine(Pow(x, y));

//static int Pow(int x, int y)
//{
//    int result = 1;
//    for (int i = 0; i < y; i++)
//    {
//        result *= x;
//    }
//    return result;
//}


// Task 5:

//int x = 5;
//int y = 10;

//Console.WriteLine($"Before swap: x = {x}, y = {y}");

//Swap(ref x, ref y);

//Console.WriteLine($"After swap: x = {x}, y = {y}");

//static void Swap(ref int a, ref int b)
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}

// Task 6:

//int x = int.Parse(Console.ReadLine());
//Divisors(x);

//static void Divisors(int x)
//{
//    for (int i = 1; i <= x; i++)
//    {
//        if (x % i == 0)
//        {
//            Console.Write(i + " ");
//        }
//    }
//    Console.WriteLine();
//}

// Task 7:

int[] arr = new int[] { 1, 2, 3 };
int incrementValue = 5;

IncrementArrayElements(arr, ref incrementValue);

Console.Write("[");
Console.Write(string.Join(", ", arr));
Console.WriteLine("]");

static void IncrementArrayElements(int[] array, ref int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] += value;
    }
}






