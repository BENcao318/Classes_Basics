// See https://aka.ms/new-console-template for more information
using Classes_Basics;
using System.Collections;

//Human denis = new Human("Denis", "Panjuta", 36);
//denis.IntroduceMyself();

//Human michael = new Human("Mike", "Cao", 1);
//michael.IntroduceMyself();

//Human basicHuman = new Human();
//basicHuman.IntroduceMyself();

//Human Natalie = new Human("Natalie");
//Natalie.IntroduceMyself();

//Box box = new Box(4,4,5);
////box.length = 3;

//Console.WriteLine("Box's Width is {0}", box.Width);
//box.Width = 10;
//Console.WriteLine("Box's Width is {0}", box.Width);
//Console.WriteLine("Box's volume is {0}", box.Volume);

//box.DisplayInfo();

//Members member1 = new Members();
//member1.Introducing(true);
//Console.ReadKey();

//int[] grades = new int[5];

//grades[0] = 20;
//grades[1] = 15;
//grades[2] = 12;
//grades[3] = 9;
//grades[4] = 7;

//Console.WriteLine("grades at index 0 : {0}", grades[0]);

//string input = Console.ReadLine();
//int number;
//int.TryParse(input, out number);
//grades[0] = number;

//Console.WriteLine("grades at index 0 : {0}", grades[0]);

//int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

//int[] gradesOfMathStudentsB = new int[] { 20, 13, 12, 8, 8 };

//Console.WriteLine("Length of gradesOfMathStudentsA {0}", gradesOfMathStudentsA.Length);

//int[] nums = new int[10];

//for(int i = 0; i < 10; i++) 
//{
//    nums[i] = i + 10;
//}

//for(int j = 0; j < 10; j++)
//{
//    Console.WriteLine("Element{0} = {1}", j, nums[j]);
//}

//int counter = 0;
//foreach(int k in nums)
//{
//    Console.WriteLine("Element{0} = {1}", counter, k);
//    counter++;
//}

//string[] friends = { "Olivia", "George", "Mary", "Ben", "Jordan"};

//foreach(string friend in friends)
//{
//    Console.WriteLine("Hi there {0}, my friend", friend);
//}

// declare 2D array
//string[,] matrix;

// 3D array
//int[,,] threeD;

// two dimensional array
//int[,] array2D = new int[,]
//{
//    { 1 ,2 ,3 }, // row 0
//    { 4 ,5 ,6 }, // row 1
//    { 7, 8, 9 } // row 2
//};

//Console.WriteLine("Central value is {0}", array2D[2 , 0]);

//string[,,] array3D = new string[,,]
//{
//    {
//        {"000", "001" },
//        {"010", "011" },
//        {"Hi there", "What's up" }
//    },
//    {
//        {"100", "101" },
//        {"110", "111" },
//        {"Another one", "Last entry" }
//    },
//};

//string[,] array2DString = new string[3, 2] 
//{ 
//    { "one", "two" }, 
//    { "three", "four"}, 
//    { "five", "six" } 
//};

//array2DString[1, 1] = "chicken";

//int dimensions = array2DString.Rank;

//Console.WriteLine("The value is {0}", dimensions);

//Console.WriteLine("Central value is {0}", array3D[0, 2, 0]);

//int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

//int[,] matrix = 
//{
//    { 1 ,2 ,3 }, // row 0
//    { 4 ,5 ,6 }, // row 1
//    { 7, 8, 9 } // row 2
//};

//foreach (int item in matrix)
//{
//    Console.Write(item + " ");
//}

//Console.WriteLine("\n This is our 2D array printed using nested for loop. ");

// Nested forloop
// outer for loop
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//// inner for loop
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.Write(matrix[i, j] + " ");
//    }
//}

//// declare jaggedArray
//int[][] jaggedArray = new int[3][];

//jaggedArray[0] = new int[5];
//jaggedArray[1] = new int[3];
//jaggedArray[1] = new int[2];

//jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
//jaggedArray[1] = new int[] { 1, 2, 3 };
//jaggedArray[2] = new int[] { 13, 21 };

//// alternative way:
//int[][] jaggedArray2 = new int[][]
//{
//    new int[] { 2, 3, 5, 7, 11 },
//    new int[] { 1, 2, 3}
//};

//Console.WriteLine("The Value in the middle of the first entry is {0}", jaggedArray2[0][2]);

//for (int i = 0; i < jaggedArray2.Length; i++)
//{
//    for (int j = 0; j < jaggedArray2[i].Length; j++)
//    {
//        Console.WriteLine(jaggedArray2[i][j]);
//    }
//}

// declaring an ArrayList
ArrayList myArrayList = new ArrayList();

ArrayList myArrayList2 = new ArrayList(100);

myArrayList.Add(25);
myArrayList.Add("Hello");
myArrayList.Add(13.37);
myArrayList.Add(13);
myArrayList.Add(128);
myArrayList.Add(25.3);
myArrayList.Add(13);

// only remove the first item that is the value
myArrayList.Remove(13);

myArrayList.RemoveAt(0);

Console.WriteLine(myArrayList.Count);

double sum = 0;

foreach (object obj in myArrayList)
{
    if(obj is int)
    {
        sum += Convert.ToDouble(obj);
    } else if(obj is double)
    {
        sum += (double)obj;
    }
    else if(obj is string)
    {
        Console.WriteLine(obj);
    }
}

Console.WriteLine(sum);
