using System;
using System.Collections;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Need to System.Collections namespace 
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Ahmet");
            arrayList.Add(true);
            arrayList.Add(17);
            arrayList.Add(0.78f);
            object o = 0xff;
            arrayList.Add(o);

            Console.WriteLine(arrayList[0]);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //  AddRange
            Console.WriteLine("** AddRange **");
            string[] renkler = {"Kırmızı", "Yeşil", "Mavi"};
            int[] sayılar = {1, 2, 3, 4, 5, 6, 7};

            arrayList.AddRange(renkler);
            arrayList.AddRange(sayılar);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //  Sort
            Console.WriteLine("** Sort **");
            ArrayList arrayList1 = new ArrayList();
            arrayList1.AddRange(sayılar);
            arrayList1.Sort();

            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }

            //  BinarySearch
            Console.WriteLine("** BinarySearch **");
            Console.WriteLine(arrayList1.BinarySearch(5));

            //  Reverse
            Console.WriteLine("** Reverse **");
            arrayList1.Reverse();

            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }

            //  Clear
            Console.WriteLine("** Clear **");
            arrayList1.Clear();

        }
    }
}
