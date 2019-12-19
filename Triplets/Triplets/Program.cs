using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triplets
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<long> inputList = new List<long>() { 1, 2, 2, 4 };
            //List<long> inputList = new List<long>() { 1, 3, 9, 9, 27, 81 };
            List<long> inputList = new List<long>() { 1, 5, 5, 25, 125 };
            Console.WriteLine(countTriplets(inputList, 5));
            Console.Read();
        }

        static long countTriplets(List<long> arr, long r)
        {
            arr.Sort();

            //List<long[]> list = new List<long[]>();
            //Dictionary<long[], int> list = new Dictionary<long[], int>();
            HashSet<long[]> list = new HashSet<long[]>();

            for (int i = 0; i < arr.Count; i++)
            {

                //if (i == 0)
                //    if (arr[0] == 1)
                //    {
                //        tracker[0] = 1;

                //        if (arr.Contains(1 * r))
                //        {
                //            int index = arr.FindIndex(c => c == 1 * r);

                //            tracker[1] = index;
                //        }
                //    }


                for (int j = i + 1; j < arr.Count; j++)
                {
                    long[] tracker = new long[3];
                    int index2 = 0;
                    int index3 = 0;

                    if (arr.Contains(arr[i] * r))
                    {
                        if (arr.Contains((arr[i] * r) * r))
                        {
                            tracker[0] = i;
                            if (arr[j] == arr[i] * r)
                            {
                                tracker[1] = j;

                                for (int k = j + 1; k < arr.Count; k++)
                                {
                                    if (arr[k] == (arr[i] * r) * r)
                                    {
                                        long[] tracker2 = new long[3];
                                        tracker.CopyTo(tracker2, 0);
                                        tracker2[2] = k;

                                        list.Add(tracker2);
                                    }
                                }

                            }

                        }
                    }


                    /////////////////////////////
                    //if (arr.Contains(arr[i]*r))
                    //{
                    //    if (arr.Contains((arr[i]*r)*r))
                    //    {
                    //        tracker[0] = i;

                    //        if (arr[j] == arr[i] * r )
                    //        {
                    //            tracker[1] = j;

                    //            int index = arr.FindIndex(c => c == (arr[j] * r));
                    //            tracker[2] = index;

                    //            //list.Add(tracker);

                    //            if (!list.ContainsKey(tracker))
                    //                list.Add(tracker, 1);

                    //            continue;

                    //        }


                    //    }
                    //}
                    ////////////////////////////////
                }
                
            }

            return list.Count;
        }

    }
}


//else if (arr[j] == (arr[i] * r) * r)
//{
//    var index = 0;
//    var all = arr.FindAll(c => c == (arr[i] * r));


//    index = arr.FindIndex(c => c == all[0]);


//    tracker[1] = index;
//    tracker[2] = j+1;

//    //list.Add(tracker, 1);



//    foreach (var item in list.Keys.ToList())
//    {
//        if (!item[0].Equals(tracker[0]) && !item[1].Equals(tracker[1]) && !item[2].Equals(tracker[2]))
//            list.Add(tracker, 1);

//    }

//    continue;

//}