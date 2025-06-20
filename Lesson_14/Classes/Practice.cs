using System.Text;

namespace Lesson_14.Classes
{
    internal class Practice
    {
        //1
        //public List<int> MergingList(List<int> a, List<int> b)
        //{
        //    List<int> mergedList = new List<int>();

        //    b.AddRange(a);

        //    return b.ToHashSet().ToList();
        //}


        //2
        //public List<int> MergingList(List<int> a, List<int> b)=>
        //     a.Concat(b).ToHashSet().ToList();

        //3
        //public List<int> MergingList(List<int> a, List<int> b) =>
        //     a.Concat(b).Distinct().ToList();

        //public List<int> RemoveAllMeth(List<int> a, Predicate<int> b)
        //{
        //    a.RemoveAll(b);
        //    return a;
        //}   

        public List<int> ShufflesListIndex(List<int> list)
        {
            HashSet<int> first = new HashSet<int>();
            int firstIndex = new Random().Next(0, list.Count);

            while (first.Contains(firstIndex))
            {
                firstIndex = new Random().Next(0, list.Count);
            }

            first.Add(firstIndex);

            int secondIndex = new Random().Next(0, list.Count);
            while (first.Contains(secondIndex))
            {
                secondIndex = new Random().Next(0, list.Count);
            }

            first.Add(secondIndex);

            int a, b;
            a = list[firstIndex];
            b = list[secondIndex];

            list[firstIndex] = b;
            list[secondIndex] = a;

            return list;
        }

        //public Dictionary<int,int> CountingDublicateElements(List<int> list)
        //{
        //    int count = 0;
        //    Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if(keyValuePairs.ContainsKey(list[i]))
        //        {
        //            keyValuePairs[list[i]]++;
        //        }
        //        else
        //        {
        //            keyValuePairs[list[i]] = 1;
        //        }
        //    }
        //    return keyValuePairs;
        //}

        public Dictionary<int, int> CountingDublicateElements(List<int> list)
        {
           Dictionary<int,int> dec= new Dictionary<int,int>();

            foreach (int key in list)
            {
                if (dec.ContainsKey(key))
                    dec[key] = dec[key] + 1;

                else
                    dec[key] = 1;
            }
            return dec;
        }

        public string ToStringList(List<int> list)
        {
            StringBuilder  k = new StringBuilder();
            foreach (int key in list)
            {
               k= k.Append(key);
            }

            return k.ToString();
        }
    }
}
