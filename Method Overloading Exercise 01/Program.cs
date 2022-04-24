using System;

namespace Method_Overloading_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Complete all of the TODOs then push back to GitHub

            #region TODOs

            // TODO: Call each of the overloads you created below here, and make sure to pass in the appropriate arguments to the function
            PrintItems(5);
            Console.WriteLine();
            PrintItems(7, 8, 9);
            Console.WriteLine();
            PrintItems(1.1, 2.2, 3.3, 4.4);
            Console.WriteLine();
            PrintItems(0.9999999m, 0.894585m, 0.3333495485m);
            Console.WriteLine();
            PrintItems(true, true, false, false, true, false, true);

            Console.WriteLine();
            Console.WriteLine();

            PrintItems("I", "Have", "Become", "A", "True", "Coder");
            Console.WriteLine();
            PrintItems('a', 'b', 'c', '1', '2', '3');
            Console.WriteLine();
            PrintItems(5.7f, 4.6f, 8.1f, 17.2f);
            Console.WriteLine();
            PrintItems(new long[] {197, 333, 285, 292, 214} );
            Console.WriteLine();
            PrintItems(new object[] {2, "8", 3, 45, "Tom"});
            Console.WriteLine();

            #endregion


            #region BONUS
            // TODO: Call the PrintItems overload and pass in a new System.Object as an argument
            PrintItems(new System.Object()); // object


            // params object[] Example 1:
            var str = "Hello World!";
            var num1 = 27;
            var symbol1 = '$';
            PrintItems(str, num1, symbol1);



            // params object[] Example 2:
            var arr = new int[] { 1, 2, 3 };
            var arr1 = new double[] { .1, .2, .3 };
            var arr2 = new float[] { .1f, .2f, .3f };
            PrintItems(arr, arr1, arr2);

            #endregion
        }


        #region TODOs

        // TODO: Create a method called PrintItems
        // TODO: Make the method public 
        // TODO: Make the method static
        // TODO: Make the return type void
        // TODO: Make the parameter of type int
        // TODO: Make the method print out what's passed in to the console

        public static void PrintItems(int item)
        {
            Console.Write(item);
        }

        // TODO: Create an overload for PrintItems that prints out ANY amount of integers passed in to the function as arguments
        public static void PrintItems(params int[] items)
        {
            foreach(int item in items)
            {
                Console.Write(item + " ");
            }
        }


        // TODO: Create a PrintItems() double overload that prints out ANY amount of doubles passed in to the function as arguments
        public static void PrintItems(params double[] items)
        {
            foreach(double item in items)
            {
                Console.Write(item + " ");
            }
        }


        // TODO: Create a PrintItems() decimal overload that prints out ANY amount of decimals passed in to the function as arguments
        public static void PrintItems(params decimal[] items)
        {
            foreach(decimal item in items)
            {
                Console.Write(item + " ");
            }
        }


        // TODO: Create a PrintItems() bool overload that prints out ANY amount of bools passed in to the function as arguments
        public static void PrintItems(params bool[] items)
        {
            foreach(bool item in items)
            {
                Console.Write(item + " ");
            }
        }


        // TODO: Create a PrintItems() string overload that prints out ANY amount of strings passed in to the function as arguments
        public static void PrintItems(params string[] items)
        {
            foreach(string item in items)
            {
                Console.WriteLine(item);
            }
        }


        // TODO: Create a PrintItems() char overload that prints out ANY amount of chars passed in to the function as arguments
        public static void PrintItems(params char[] items)
        {
            foreach(char item in items)
            {
                Console.Write(item + " ");
            }
        }


        // TODO: Create a PrintItems() float overload that prints out ANY amount of floats passed in to the function as arguments
        public static void PrintItems(params float[] items)
        {
            foreach(float item in items)
            {
                Console.Write(item + " ");
            }
        }


        // TODO: Create a PrintItems() long overload that prints out ANY amount of longs passed in to the function as arguments
        public static void PrintItems(params long[] items)
        {
            foreach(long item in items)
            {
                Console.Write(item + " ");
            }
        }

        #endregion


        #region BONUS

        // TODO: Create a PrintItems() object overload that prints out ANY amount of objects passed in to the function as arguments (hint: params object[])
        public static void PrintItems(params object[] items)
        {
            foreach(object item in items)
            {
                Console.WriteLine(item);
            }
        }

        #endregion
    }
}
