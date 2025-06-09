//String
//string text = "Salom, dunyo!";

//Console.WriteLine("1️⃣ Length: " + text.Length);

//Console.WriteLine("2️⃣ ToUpper: " + text.ToUpper());
//Console.WriteLine("3️⃣ ToLower: " + text.ToLower());

//Console.WriteLine("4️⃣ Contains(\"dunyo\"): " + text.Contains("dunyo"));
//Console.WriteLine("5️⃣ StartsWith(\"Salom\"): " + text.StartsWith("Salom"));
//Console.WriteLine("6️⃣ EndsWith(\"!\"): " + text.EndsWith("!"));

//Console.WriteLine("7️⃣ IndexOf('o'): " + text.IndexOf('o'));
//Console.WriteLine("8️⃣ LastIndexOf('o'): " + text.LastIndexOf('o'));

//Console.WriteLine("9️⃣ Substring(0,5): " + text.Substring(0, 5));

//Console.WriteLine("🔟 Replace(\"dunyo\", \"olam\"): " + text.Replace("dunyo", "olam"));

//Console.WriteLine("1️⃣1️⃣ Remove(5,7): " + text.Remove(5, 7)); // 5-indexdan boshlab 7ta belgini olib tashlaydi

//Console.WriteLine("1️⃣2️⃣ Insert(6,\" aziz\"): " + text.Insert(6, " aziz"));

//Console.WriteLine("1️⃣3️⃣ Trim(): " + text.Trim());

//Console.WriteLine("1️⃣4️⃣ Split(' '): ");
//string[] words = text.Split(' ');
//foreach (var word in words)
//{
//    Console.WriteLine(" - " + word);
//}

//Console.WriteLine("1️⃣5️⃣ Join: " + string.Join("-", words));

//Console.WriteLine("1️⃣6️⃣ PadLeft(20,'*'): " + text.PadLeft(20, '*'));
//Console.WriteLine("1️⃣7️⃣ PadRight(20,'*'): " + text.PadRight(20, '*'));

//Console.WriteLine("1️⃣8️⃣ IsNullOrEmpty: " + string.IsNullOrEmpty(text));
//Console.WriteLine("1️⃣9️⃣ IsNullOrWhiteSpace: " + string.IsNullOrWhiteSpace(text));

//Console.WriteLine("2️⃣0️⃣ Compare(\"Salom, dunyo!\", \"Salom\"): " + string.Compare(text, "Salom"));

//Console.WriteLine("2️⃣1️⃣ Equals(\"Salom, dunyo!\"): " + text.Equals("Salom, dunyo!"));

//Console.WriteLine("2️⃣2️⃣ Concat(\"Hello\", \" \", \"World\"): " + string.Concat("Hello", " ", "World"));


//StringBuilder 
using System.Text;

StringBuilder sb = new StringBuilder("Salom");

Console.WriteLine("Boshlang‘ich: " + sb);

sb.Append(", dunyo!");
Console.WriteLine("Append: " + sb);

sb.AppendLine();
sb.AppendLine("Qanday yordam bera olaman?");
Console.WriteLine("AppendLine:\n" + sb);

sb.Insert(6, " aziz");
Console.WriteLine("Insert: " + sb);

sb.Remove(6, 5);
Console.WriteLine("Remove: " + sb);


sb.Replace("dunyo", "olam");
Console.WriteLine("Replace: " + sb);

sb.Clear();
Console.WriteLine("Clear: " + sb);

sb.Capacity = 50;
Console.WriteLine("Capacity: " + sb.Capacity);


sb.EnsureCapacity(100);
Console.WriteLine("EnsureCapacity(100): " + sb.Capacity);

sb.AppendFormat("Bugun sana: {0:dd.MM.yyyy}", DateTime.Now);
Console.WriteLine("AppendFormat: " + sb);


Console.WriteLine("Length: " + sb.Length);

if (sb.Length > 0)
{
    Console.WriteLine("1-belgi: " + sb[0]);
    sb[0] = 'b';
    Console.WriteLine("O‘zgartirilgan: " + sb);
}

