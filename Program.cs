using System;


namespace predicateEA
{
    class Program
    {
        static void Task1()
        {
            Action<string> print = element => Console.WriteLine(element);

            string str = Console.ReadLine();
            string[] elements = str.Split(" ");

            foreach (var item in elements)
            {
                print(item);
            }
        }

        static void Task2()
        {
            Action<string> print = element => Console.WriteLine(element + " (нет в наличии)");

            string str = Console.ReadLine();
            string[] elements = str.Split(" ");

            foreach (var item in elements)
            {
                print(item);
            }

        }

        static void Task3()
        {
            Func<string, int> parser = element => int.Parse(element);

            string str = Console.ReadLine();
            string[] elements = str.Split(" ");

            int min;
            min = parser(elements[0]);
            foreach (var item in elements)
            {
                if (parser(item) < min)
                {
                    min = parser(item);
                }
            }

            Console.WriteLine(min);
        }


        static void Task4()
        {
            Func<int, bool> checker = element => element % 2 == 0;

            string strOfNumbers = Console.ReadLine();
            string cmd = Console.ReadLine();

            string[] diap = strOfNumbers.Split(" ");

            int start = int.Parse(diap[0]);
            int end = int.Parse(diap[1]);
            int[] array = new int[end + 1];

            if (cmd == "even")
            {
                for (int i = start; i <= end; i++)
                {
                    if (checker(array[i]))
                    {
                        Console.Write(array[i]+" ");
                    }
                }
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    if (!checker(array[i]))
                    {
                        Console.Write(array[i]);
                    }
                }


            }
        }



        static void Main(string[] args)
        {
            Task4();
        }
    }
}

