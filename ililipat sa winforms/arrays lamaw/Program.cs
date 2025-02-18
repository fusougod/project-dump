using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Single Dimensional Array");
            Console.WriteLine("2. Multi-dimensional Array");
            Console.WriteLine("3. Jagged Array");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    HandleSingleDimensionalArray();
                    break;
                case "2":
                    HandleMultiDimensionalArray();
                    break;
                case "3":
                    HandleJaggedArray();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void HandleSingleDimensionalArray()
    {
        Console.Clear();
        int[] numbers = new int[5];
        Console.WriteLine("Enter 5 integers:");
        for (int i = 0; i < 5; i++)
        {
            while (true)
            {
                Console.Write("Element [{0}]: ", i);
                string input = Console.ReadLine();
                if (int.TryParse(input, out numbers[i]))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong format. Please enter a valid integer.");
                }
            }
        }

        Array.Sort(numbers);
        Console.WriteLine("Sorted Array in Ascending Order: " + string.Join(", ", numbers));
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }

    static void HandleMultiDimensionalArray()
    {
        Console.Clear();
        int[,] firstArray = new int[2, 2];
        int[,] secondArray = new int[2, 2];

        Console.WriteLine("Enter 4 integers for a 2x2 matrix:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                while (true)
                {
                    Console.Write("Element [{0},{1}]: ", i, j);
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out firstArray[i, j]))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong format. Please enter a valid integer.");
                    }
                }
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                secondArray[i, j] = firstArray[i, j];
            }
        }

        Console.WriteLine("Copied 2x2 Matrix:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(secondArray[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }

    static void HandleJaggedArray()
    {
        Console.Clear();
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[2];
        jaggedArray[1] = new int[3];
        jaggedArray[2] = new int[4];

        Console.WriteLine("Enter values for a jagged array:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                while (true)
                {
                    Console.Write("Element [{0}][{1}]: ", i, j);
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out jaggedArray[i][j]))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong format. Please enter a valid integer.");
                    }
                }
            }
        }

        Console.WriteLine("Jagged Array:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.WriteLine(string.Join(" ", jaggedArray[i]));
        }
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}
