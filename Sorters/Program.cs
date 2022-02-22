using System;

namespace Sorters
{
    class Program
    {
        static int[] List = new int[400];
        static bool Sorted = false;
        static int Temp = 0;
        static bool Change = false;
        static void Main(string[] args)
        {
            for (int i = 0; i < 400; i++)
            {
                int numb = new Random().Next(0, 500);
                List[i] = numb;
            }
            Console.WriteLine("What sorting method do you want?");
            Console.WriteLine("1- Merge sort");
            Console.WriteLine("2- Bubble sort");
            Console.WriteLine("3- Split sort");
            Console.WriteLine("4- Binary split sort");
            int Input = int.Parse(Console.ReadLine());

            switch (Input)
            {
                case 1:
                    MergeSort();
                    break;
                case 2:
                    BubbleSort();
                    break;
                case 3:
                    SplitSort();
                    break;
                case 4:
                    BinartSplitSort();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;

            }
        }

        static void MergeSort()
        {
            Console.WriteLine("Not made yet");
        }

        static void BubbleSort()
        {
            Sorted = false;
            Temp = 0;
            while (Sorted == false)
            {
                Change = false;
                for (int i = 1; i < 400; i++)
                {
                    if (List[i - 1] > List[i])
                    {
                        Temp = List[i - 1];
                        List[i - 1] = List[i];
                        List[i] = Temp;
                        Change = true;
                    }
                }
                if (Change == false)
                {
                    Sorted = true;
                }
            }

            Console.WriteLine("Sorted");
        }

        static void SplitSort()
        {
            Console.WriteLine("Not made yet");
        }

        static void BinartSplitSort()
        {
            Console.WriteLine("Not made yet");
        }
    }
}
