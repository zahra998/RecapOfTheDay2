using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // array store group of data that has the same data type, we can access it as sequance which start from 0 (index)
            
            //single array
            int[] array = new int[3] { 0, 1, 3 };

            // multidymintion array -- 3 rows and 3 column
            int[,] multiArrat = new int[3, 3];
            multiArrat[0, 0] = 1;
            multiArrat[0, 1] = 2;
            multiArrat[0, 2] = 3;
            multiArrat[1, 0] = 4;
            multiArrat[1, 1] = 5;
            multiArrat[1, 2] = 6;
            multiArrat[2, 0] = 7;
            multiArrat[2, 1] = 8;
            multiArrat[2, 2] = 9;

            //Jagged array - arrays whithin an array -- fixed sized arrays
            int[][] jaggedArry = new int[3][] // 3 arrays

            {
                new int [] { 1, 2,},
                new int [] { 3, 4, 5},
                new int [] { 6, 7, 8, 9 }
            };

            // slicing

            int[] slice = array[..2]; //[ 0, 1]
            int[] slice1 = array[1..^1]; //^ start from the last -- [1]

            Console.WriteLine(slice[0]); // 0
            Console.WriteLine(slice[1]); // 1
            Console.WriteLine(slice1[0]); // 1
            // Console.WriteLine(slice1[1]); // out of boundry exception 



            // even or odd number

            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }

            int? z = null;
            string zz = null;
            string str = null; 
            zz = "Zahra";

            Console.WriteLine(zz);

            zz = zz ?? "Zahra"; // if it is null replase the null with Zahra
            Console.WriteLine(zz);

            str = str ?? "Zahra"; // replase null with Zahra
            Console.WriteLine(str);
            string capitalStr = str?.ToUpper(); // if it is not null he capitlaize the letters


            {
                
                int local = 9; // it can not be access out side the block {} -- it is good for security data
                Console.WriteLine(local);
            }
            // Console.WriteLine( local); -- returen error

            int i = 1;
            Console.WriteLine(i++); // it display the output first then it add 1 -- postfix
            Console.WriteLine(++i); // it add 1 then it display the output -- refix
        }

    }
}