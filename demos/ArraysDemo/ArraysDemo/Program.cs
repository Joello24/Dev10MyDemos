using System;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercises e = new Exercises();
            e.GrowArray();
        }

        static void JaggedMultidimensional()
        {
            Console.WriteLine("Jagged Demo");
            string[][] array = new string[3][];
            array[0] = new string[] { "a", "b", "c", "1","2","3" };
            array[1] = new string[] { "d", "e" };
            array[2] = new string[] { "f","g", "h", "i", "4" };


            for (int row = 0; row < array.Length; row++)
            {
                Console.Write($"Row: {row}     ");
                for (int col = 0; col < array[row].Length; col++)
                {
                    Console.Write($"{array[row][col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void MultiDimensionalCommaStyle()
        {
            Console.WriteLine("Comma Style Demo");
            string[,] matrix= new string[3, 3]{
              { "Strawberry", "Blueberry", "Gooseberry" },
              { "Red", "Yellow", "Blue" },
              { "Atlantic", "Pacific", "Indian" }
            };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.Write($"Row: {row}    ");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]}    ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void MultiDimensionalNormalStyle()
        {
            Console.WriteLine("Normal Style Demo");
            string[][] rows = new string[3][];
            rows[0] = new string[3] { "a", "b", "c" };
            rows[1] = new string[3] { "d", "e", "f" };
            rows[2] = new string[3] { "g", "h", "i" };


            for (int row = 0; row < rows.Length; row++)
            {
                Console.Write($"Row: {row}     ");
                for (int col = 0; col < rows[row].Length; col++)
                {
                    Console.Write($"{rows[row][col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void FindTargetValue(string targetStudentName)
        {
            if (targetStudentName == null)
            {
                Console.WriteLine("No search term given!");
                return;
            }

            Console.WriteLine($"Searching for {targetStudentName}");

            Student alice = new Student();
            alice.Id = 1;
            alice.Name = "Alice";

            Student bob = new Student();
            bob.Id = 2;
            bob.Name = "Bob";

            Student carol = new Student();
            carol.Id = 3;
            carol.Name = "Carol";

            Student[] roster = { alice, bob, carol };

            int id = -1;

            foreach (Student s in roster)
            {
                Console.WriteLine($"Testing student - id: {s.Id} name: {s.Name}");
                if (s.Name == targetStudentName)
                {
                    id = s.Id;
                    break;
                } 
            }

            if (id > 0)
            {
                Console.WriteLine($"Found {targetStudentName}:  id is: {id}");
            } else
            {
                Console.WriteLine("Couldn't find that student, boss!");
            }

        }


        static void FindMaxDemo()
        {
            int[] allTheInts = { 1, 4, 6, 2, 5, 999, -1 };
            //          indices: 0  1  2  3  4  5     6
            //          Length:  7
            int currentMax = 0;
            Console.WriteLine($"Array Length: {allTheInts.Length}");
            for (int i = 0; i < allTheInts.Length; i++)  //i is the index
            {

                int current = allTheInts[i];  //current is the value of the element at that index
                Console.WriteLine($"Index: {i}  Value: {current} CurrentMax: {currentMax}");
                if (current > currentMax)
                {
                    currentMax = current;
                    Console.WriteLine($"  New max:  {currentMax}");
                }
            }

            Console.WriteLine($"Max int is:  {currentMax}");

            /* currentMax = 0;
             foreach (int current in allTheInts)
             {
                 if (current > currentMax)  //no index!  Just the current element
                 {
                     currentMax = current;
                     Console.WriteLine($"New max:  {currentMax}");
                 }
             }*/

            Console.WriteLine($"Max int is:  {currentMax}");
        }
    }
}
