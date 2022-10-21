//int[] nums = new int[2] {1, 2};
//int[] nums1 = new[] {1, 2, 3, 4, 5};
//int[] nums2  = { 1, 2, 3, 4, 5};

//string[] people = {"aaa", "bbb", "ccc"};
////Inedex
//Console.WriteLine(people);
//Console.WriteLine(nums[0]);
////Length
//Console.WriteLine(people.Length);
//Console.WriteLine(nums2.Length - 1);
////   ^^^
//Console.WriteLine(nums1[^1]);

//int[] numbers = {1, 2, 3, 4, 5};
//foreach(int num in numbers)
//{
//    Console.WriteLine(num);
//}

//int[] numbers = {1, 2, 3, 4, 5};


//for(int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//int i = 0;
//while(i < numbers.Length)
//{
//    Console.WriteLine(numbers[i]);
//    i++;
//}

//int[] nums1 = new int[] { 0, 1, 2, 3, 4, 5 };

//int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };

//int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
//foreach (int i in numbers)
//    Console.Write($"{i} ");
//Console.WriteLine(numbers[0 , 1]);

//int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };

//int rows = numbers.GetUpperBound(0) + 1;   
//int columns = numbers.Length / rows;      
//                                           
//                                            
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write($"{numbers[i, j]} \t");
//    }
//    Console.WriteLine();
//}

//int[][] numbers = new int[3][];
//numbers[0] = new int[] { 1, 2 };
//numbers[1] = new int[] { 1, 2, 3 };
//numbers[2] = new int[] { 1, 2, 3, 4, 5 };
//foreach (int[] row in numbers)
//{
//    foreach (int number in row)
//    {
//        Console.Write($"{number} \t");
//    }
//    Console.WriteLine();
//}

//// перебор с помощью цикла for
//for (int i = 0; i < numbers.Length; i++)
//{
//    for (int j = 0; j < numbers[i].Length; j++)
//    {
//        Console.Write($"{numbers[i][j]} \t");
//    }
//    Console.WriteLine();
//}
