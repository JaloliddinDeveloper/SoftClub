using Lesson_14.Classes;

var practice = new Practice();  

//practice.MergingList(new
//    List<int> { 1, 2, 3, 4, 5 }, new List<int> { 2, 4, 6 })
//    .ForEach(Console.WriteLine);

var list = new List<int> { 1, 2,2,6, 3, 4, 5, 6, 7, 8, 9 };
//var predicate = new Predicate<int>(x => x % 2 == 0);

//practice.RemoveAllMeth(list, predicate)
//    .ForEach(Console.WriteLine);

List<int> nums =practice.ShufflesListIndex(list);

//foreach(int i in nums)
//{
//    Console.WriteLine(i);
//}

//var k=practice.CountingDublicateElements(list);

//foreach(var i in k)
//{
//    Console.WriteLine($" {i.Key} , {i.Value} ta");
//}

var k=practice.ToStringList(list);

Console.WriteLine(k);