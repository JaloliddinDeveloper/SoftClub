//String
string text = "Salom, dunyo!";

Console.WriteLine("1️⃣ Length: " + text.Length);

Console.WriteLine("2️⃣ ToUpper: " + text.ToUpper());
Console.WriteLine("3️⃣ ToLower: " + text.ToLower());

Console.WriteLine("4️⃣ Contains(\"dunyo\"): " + text.Contains("dunyo"));
Console.WriteLine("5️⃣ StartsWith(\"Salom\"): " + text.StartsWith("Salom"));
Console.WriteLine("6️⃣ EndsWith(\"!\"): " + text.EndsWith("!"));

Console.WriteLine("7️⃣ IndexOf('o'): " + text.IndexOf('o'));
Console.WriteLine("8️⃣ LastIndexOf('o'): " + text.LastIndexOf('o'));

Console.WriteLine("9️⃣ Substring(0,5): " + text.Substring(0, 5));

Console.WriteLine("🔟 Replace(\"dunyo\", \"olam\"): " + text.Replace("dunyo", "olam"));

Console.WriteLine("1️⃣1️⃣ Remove(5,7): " + text.Remove(5, 7)); // 5-indexdan boshlab 7ta belgini olib tashlaydi

Console.WriteLine("1️⃣2️⃣ Insert(6,\" aziz\"): " + text.Insert(6, " aziz"));

Console.WriteLine("1️⃣3️⃣ Trim(): " + text.Trim());

Console.WriteLine("1️⃣4️⃣ Split(' '): ");
string[] words = text.Split(' ');
foreach (var word in words)
{
    Console.WriteLine(" - " + word);
}

Console.WriteLine("1️⃣5️⃣ Join: " + string.Join("-", words));

Console.WriteLine("1️⃣6️⃣ PadLeft(20,'*'): " + text.PadLeft(20, '*'));
Console.WriteLine("1️⃣7️⃣ PadRight(20,'*'): " + text.PadRight(20, '*'));

Console.WriteLine("1️⃣8️⃣ IsNullOrEmpty: " + string.IsNullOrEmpty(text));
Console.WriteLine("1️⃣9️⃣ IsNullOrWhiteSpace: " + string.IsNullOrWhiteSpace(text));

Console.WriteLine("2️⃣0️⃣ Compare(\"Salom, dunyo!\", \"Salom\"): " + string.Compare(text, "Salom"));

Console.WriteLine("2️⃣1️⃣ Equals(\"Salom, dunyo!\"): " + text.Equals("Salom, dunyo!"));

Console.WriteLine("2️⃣2️⃣ Concat(\"Hello\", \" \", \"World\"): " + string.Concat("Hello", " ", "World"));
