//Mahkamov Jaloliddin
//Data: 03.06.2025
//Task 1: Comments

//This is single line comment

/* 
 this is multi-line comment
 */

//Task 2:Output
Console.WriteLine("Hello, World!");

Console.WriteLine("This is Console.WriteLine with a new line at the end.");

Console.Write("This is Console.Write without a new line at the end.");

Console.WriteLine(10);

Console.WriteLine(15+5);

Console.WriteLine(true);

Console.WriteLine(false);

//Task 3:Variables
int age = 25; // integer variable

string name = "Jaloliddin"; // string variable

double height = 1.75; // double variable

bool isStudent = true; // boolean variable

Console.WriteLine($"Name is {name} Age: {age} Hight: {height}"); // this is enterpolation


double age2 = Convert.ToDouble(age);

int height2 = Convert.ToInt32(height);

string age3=Convert.ToString(age);


//Task 4:Input

Console.Write("Enter your name: ");
string userName = Console.ReadLine();
Console.Write("Enter your age: ");
uint userAgeInput = uint.Parse(Console.ReadLine());

Console.WriteLine($"Hello, {userName}! You are {userAgeInput} years old.");

//Task 5:If-Else Statement 

Console.Write("Enter your age: ");
int userAge = int.Parse(Console.ReadLine());

if (userAge < 18)
{
    Console.WriteLine("You are a minor.");
}
else if (userAge >= 18 && userAge < 65)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are a senior citizen.");
}

//Task 6:Switch Statement

Console.Write("Enter a weekday: ");
string weekday = Console.ReadLine().ToLower();

switch(weekday)
{
    case "monday":
        Console.WriteLine("It's Monday, the start of the week!");
        break;
    case "tuesday":
        Console.WriteLine("It's Tuesday, keep going!");
        break;
    case "wednesday":
        Console.WriteLine("It's Wednesday, we're halfway through!");
        break;
    case "thursday":
        Console.WriteLine("It's Thursday, almost there!");
        break;
    case "friday":
        Console.WriteLine("It's Friday, the weekend is near!");
        break;
    case "saturday":
        Console.WriteLine("It's Saturday, enjoy your day off!");
        break;
    case "sunday":
        Console.WriteLine("It's Sunday, relax and prepare for the week ahead.");
        break;
    default:
        Console.WriteLine("That's not a valid weekday.");
        break;
}


//Enter a number from 1 to 12 to get the corresponding month name

Console.Write("Enter a number from 1 to 12: ");
int monthNumber = int.Parse(Console.ReadLine());

var result = monthNumber switch
{
    1 => "January",
    2 => "February",
    3 => "March",
    4 => "April",
    5 => "May",
    6 => "June",
    7 => "July",
    8 => "August",
    9 => "September",
    10 => "October",
    11 => "November",
    12 => "December",
    _ => "Invalid month number"
};

Console.WriteLine($"The month is: {result}");

//Task 7:Loops

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"This is iteration number {i}");
}

int l = 1,p = 10;
while (l<=p)
{
    Console.WriteLine($"This is while loop iteration number {l}");
    l++;
}

do
{
    Console.WriteLine($"This is do-while loop iteration number {l}");
    l++;
} while (l <= p);


//Break and Continue

for(int j=1;j<=10;j++)
{
    if (j == 3)
    {
        break;
    }
    Console.WriteLine(j);
}


for(int r=1;r<=20;r++)
{
    if(r is 5)
    {
        continue;
    }
    Console.WriteLine(r);
}

//Loop Tasks 
//Number is Prime
Console.Write("Enter a number: ");
int number, s = 0;
number=int.Parse(Console.ReadLine());

for(int t=1;t<=number;t++)
{
    if(number%t==0)
    {
        s++;
    }
}
if(s==2)
    Console.WriteLine($"{number} is prime");
else
    Console.WriteLine($"{number} is not prime");

int sum = 0;
int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };

for(int i=0;i<nums.Length;i++)
{
    sum += nums[i];
}

Console.WriteLine($"Sum: {sum}");


//Massiv Sort

int[] numbers = { 4, 6, 7, 8, 0, 3, 11, 25 };

for (int i = 0; i < numbers.Length-1; i++)
{
    for (int j = 0; j <numbers.Length-1-i; j++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            int k= numbers[j];
            numbers[j]=numbers[j + 1];
            numbers[j + 1] = k;
        }
    }
}

foreach (var item in numbers)
    Console.Write($"{item} ");
