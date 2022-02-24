using System;
using System.Threading;

namespace Sorters
{
    class Program
    {
        static int[] List = new int[400];
        static bool Sorted = false;
        static int Temp = 0;
        static bool Change = false;
        static int LoopCount = 0;
        static void Main(string[] args)
        {
            for (int i = 0; i < 400; i++)
            {
                int numb = new Random().Next(0, 500);
                List[i] = numb;
            }
            Console.WriteLine("What sorting method do you want?");
            Console.WriteLine("1- Random sort");
            Console.WriteLine("2- Bubble sort");
            Console.WriteLine("3- Undecided");
            Console.WriteLine("4- Binary sort");
            int Input = int.Parse(Console.ReadLine());

            switch (Input)
            {
                case 1:
                    RandomSort();
                    break;
                case 2:
                    BubbleSort();
                    break;
                case 3:
                    Console.WriteLine("No");
                    break;
                case 4:
                    BinarySort();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }

        static void RandomSort()
        {
            Sorted = false;
            Temp = 0;
            LoopCount = 0;
            while (Sorted == false)
            {
                int rand = new Random().Next(1, 400);
                if (List[rand - 1] > List[rand])
                {
                    Temp = List[rand - 1];
                    List[rand - 1] = List[rand];
                    List[rand] = Temp;
                }

                Sorted = true;
                for (int i = 1; i < 400; i++)
                {
                    if (List[i - 1] > List[i])
                    {
                        Sorted = false;
                        break;
                    }
                }
                LoopCount++;
                
            }

            Console.WriteLine("Sorted in "+LoopCount+" loops");
        }

        static void BubbleSort()
        {
            Sorted = false;
            Temp = 0;
            LoopCount = 0;
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
                LoopCount++;
            }

            Console.WriteLine("Sorted in "+LoopCount+" loops");
        }
        static void BinarySort()
        {
            Console.WriteLine("Not made yet");
        }
    }
}
