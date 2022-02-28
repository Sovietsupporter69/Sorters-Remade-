using System;
using System.Threading;

namespace Sorters
{
    class Program
    {
        static int ListLength = 10000;
        static int[] List = new int[ListLength];
        static bool Sorted = false;
        static int Temp = 0;
        static bool Change = false;
        static int LoopCount = 0;
        static bool Dev = false;
        static BinaryHold[] BinList = new BinaryHold[ListLength];
        static void Main(string[] args)
        {
            RemakeNumbers();

            bool End = false;
            while (End == false)
            {
                ReorderNumbers();

                Console.WriteLine("What sorting method do you want?");
                Console.WriteLine("1- Random sort");
                Console.WriteLine("2- Bubble sort");
                Console.WriteLine("3- Undecided");
                Console.WriteLine("4- Binary sort");
                Console.WriteLine("new- remake number list");
                Console.WriteLine("stop- end program");
                string Input = Console.ReadLine();
                Dev = false;

                switch (Input)
                {
                    case "1":
                        RandomSort();
                        break;
                    case "2":
                        BubbleSort();
                        break;
                    case "3":
                        Console.WriteLine("No");
                        break;
                    case "4":
                        BinarySort();
                        break;
                    case "stop":
                        End = true;
                        break;
                    case "new":
                        RemakeNumbers();
                        break;
                    case "Dev":
                        Console.WriteLine("Give a number");
                        int convert = int.Parse(Console.ReadLine());
                        Dev = true;
                        Binary(convert);
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            }
        }

        static void RandomSort()
        {
            Sorted = false;
            Temp = 0;
            LoopCount = 0;
            while (Sorted == false)
            {
                int rand = new Random().Next(1, ListLength);
                if (List[rand - 1] > List[rand])
                {
                    Temp = List[rand - 1];
                    List[rand - 1] = List[rand];
                    List[rand] = Temp;
                }

                Sorted = true;
                for (int i = 1; i < ListLength; i++)
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
                for (int i = 1; i < ListLength; i++)
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

        }


        static void RemakeNumbers()
        {
            for (int i = 0; i < ListLength; i++)
            {
                int numb = new Random().Next(0, 4096);
                List[i] = numb;
            }
        }
        static void ReorderNumbers()
        {
            int numb = new Random().Next(ListLength, (ListLength*5));
            Temp = 0;
            for (int i = 0; i < numb; i++)
            {
                int numb1 = new Random().Next(0, ListLength);
                int numb2 = new Random().Next(0, ListLength);
                Temp = List[numb1];
                List[numb1] = List[numb2];
                List[numb2] = Temp;
            }
        }
        static void Binaiser()
        {
            for (int x = 0; x < ListLength; x++)
            {
                int number = List[x];
                for (int i = 11; i >= 0; i--)
                {
                    int power = (int)Math.Pow(2, i);
                    if (number - power >= 0)
                    {
                        BinList[x].bin[i] = 1;
                        number = number - power;
                    }
                    else if (number - power < 0)
                    {
                        BinList[x].bin[i] = 0;
                    }
                }
                if (Dev == true)
                {
                    Console.WriteLine(BinList[x].bin);
                }
            }
        }
    }
}
