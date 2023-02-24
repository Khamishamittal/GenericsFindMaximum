namespace Generics
{


    class Program
    {
        


        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GenericsFindMaximum Problem");

            int max1 = UsingMethod.FindMaxValue<int>(80, 45, 60);
            Console.WriteLine($"{max1} is the greatest among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 2: ");
            float max2 = UsingMethod.FindMaxValue<float>(4.5f, 7.5f, 3.3f);
            Console.WriteLine($"{max2} is the greatest among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 3: ");
            string max3 = UsingMethod.FindMaxValue<string>("Peach", "Apple", "Orange");
            Console.WriteLine($"{max3} is the greatest among three number");
        }
    }

    }

