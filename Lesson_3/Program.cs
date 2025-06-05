//Task 1:

//static void PrintNaturalNumbers(int n)
//{
//    if (n == 0)
//        return;

//    PrintNaturalNumbers(n - 1);
//    Console.Write(n + " ");
//}
//int n = 10;
//PrintNaturalNumbers(n);

// Task 2:
//static void PrintNumbersDescending(int n)
//{
//    if (n == 0)
//        return;

//    Console.Write(n + " ");
//    PrintNumbersDescending(n - 1);
//}

//int n = 10;
//PrintNumbersDescending(n);

//// Task 3:
//static int SumNaturalNumbers(int n)
//{
//    if (n == 0)
//        return 0;

//    return n + SumNaturalNumbers(n - 1);
//}

//int n = 10; 
//int sum = SumNaturalNumbers(n);
//Console.WriteLine(sum);

// Task 4:
//static void PrintDigits(int n)
//{
//    if (n == 0)
//        return;

//    PrintDigits(n / 10);
//    Console.Write(n % 10 + " ");
//}

//int n = 1234; 
//PrintDigits(n);

// Task 5:  
//static int CountDigits(int n)
//{
//    if (n == 0)
//        return 0;

//    return 1 + CountDigits(n / 10);
//}

//int n = 1234; 
//int count = CountDigits(n);
//Console.WriteLine(count);

// Task 6:
//static void PrintEvenNumbers(int current, int end)
//{
//    if (current > end)
//        return;

//    if (current % 2 == 0)
//        Console.Write(current + " ");

//    PrintEvenNumbers(current + 1, end);
//}
//static void PrintOddNumbers(int current, int end)
//{
//    if (current > end)
//        return;

//    if (current % 2 != 0)
//        Console.Write(current + " ");

//    PrintOddNumbers(current + 1, end);
//}

//int start = 1;
//int end = 20;

//Console.WriteLine($"All even numbers from {start} to {end} are:");
//PrintEvenNumbers(start, end);
//Console.WriteLine();

//Console.WriteLine($"All odd numbers from {start} to {end} are:");
//PrintOddNumbers(start, end);
//Console.WriteLine();










