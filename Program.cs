using System;
using System.Diagnostics;
using System.Linq;

namespace sort_test
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1){
                Console.WriteLine("No sorter declared");
                return;
            }
            int numRan = int.Parse(Console.ReadLine());
                Random ran = new Random();
                int[] toSort = new int[numRan];
                for (int i = 0; i < numRan; i++){
                    toSort[i] = ran.Next();
                }
                int[] arr = new int[toSort.Length];
            if (args[0] == "bubble"){                
                toSort.CopyTo(arr,0);
                //Console.WriteLine("Copied" + BubbleSorter.printArray(arr));
                var sw = Stopwatch.StartNew();
                BubbleSorter.MyBubbleSortTest(ref toSort);
                sw.Stop();
                //Console.WriteLine("My BubbleSorter = " + BubbleSorter.printArray(toSort));
                Console.WriteLine(sw.Elapsed);
                sw.Restart();
                BubbleSorter.FoundBubbleSortTest(ref arr);
                sw.Stop();
                //Console.WriteLine("Found BubbleSorter = " + BubbleSorter.printArray(arr));
                Console.WriteLine(sw.Elapsed);
            }
        }
    }
}


