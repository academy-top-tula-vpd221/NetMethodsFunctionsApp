using System.Drawing;

namespace NetMethodsFunctionsApp
{
    enum UnitType : byte
    {
        Infantry = 10,
        Archer,
        Cavalry
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloName("Bob");
            Console.WriteLine(Sum(10, 20));

            int n1 = 10;
            int n2 = 20;

            Console.WriteLine($"{n1} {n2}");
            Swap(ref n1, ref n2);
            Console.WriteLine($"{n1} {n2}");

            int n3;
            RandInt(out n3);

            int s = SumAll(1, 2, 3, 4, 5, 6, 7);

            PrintAll(true, 100, 20.6, "Hello", new List<int>());


            UnitType type = UnitType.Cavalry;
            switch (type)
            {
                case UnitType.Infantry:
                    break;
                case UnitType.Archer:
                    break;
                case UnitType.Cavalry:
                    break;
                default:
                    break;
            }


            void RandInt(out int r)
            {
                Random rand = new Random();
                r = rand.Next(0, 10);
            }

            int Sqr(in int x)
            {
                return x + x;
            }

            void Swap(ref int x, ref int y)
            {
                int t = x;
                x = y; 
                y = t;
            }

            int Sum(int a, int b)
            { 
                return a + b; 
            }

            int SumAll(params int[] nums)
            {
                int s = 0;
                foreach(int item in nums)
                    s += item;
                return s;
            }

            void PrintAll(params object[] objs)
            {
                foreach (object item in objs)
                    Console.WriteLine(item.ToString());
            }
        }

        public static void HelloName(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static long Fact(int n)
        {
            if (n == 0) return 1;
            return Fact(n - 1) * n;
        }
    }
}