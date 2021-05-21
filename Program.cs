using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> myList = new MyList<int, string>();
            myList.Add(1, "aa");
            Console.WriteLine(myList.Length);
            myList.Add(2, "bb");
            Console.WriteLine(myList.Length);
            for (int i = 0; i < myList.Length; i++)
            {
                Console.WriteLine(myList._key[i] + "" + myList._value[i]);
            }
        }
    }
}
