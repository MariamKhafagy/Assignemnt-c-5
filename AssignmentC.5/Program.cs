using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace AssignmentC._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q.19
            //19 - .Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.WriteLine("enter your value please");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //            Console.WriteLine("1");
            //        else
            //            Console.WriteLine("0");

            //    }
            //    Console.WriteLine();

            //}
            #endregion

            #region Q.20
            //20- Write a program in C# Sharp to find the sum of all elements of the array.
            //Console.Write("enter the elements in the array");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //int sum = 0;

            //Console.WriteLine("enter the element");
            //string[] input = Console.ReadLine().Split();


            //for (int i = 0; i < size; i++)

            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    sum += arr[i];

            //}


            //Console.WriteLine("sum of all elemets " + sum);




            #endregion

            #region Q.21

            //21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //Console.WriteLine("enter the  size of the array");
            //int size=int.Parse(Console.ReadLine()!);

            //int[] arr1=new int[size];
            //int[] arr2 = new int[size];
            //int[] merged=new int[2*size];

            //Console.WriteLine("enter the elemens of the first array");
            //for (int i = 0; i < size; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine()!);

            //}
            //Console.WriteLine("Enter the second array");
            //for (int i = 0; i < size; i++)
            //{
            //    arr2[i] = int.Parse(Console.ReadLine()!);
            //}

            //for (int i = 0; i < size; i++)
            //{
            //    merged[i]=arr1[i];
            //    merged[i+1] = arr2[i];

            //}
            //Array.Sort(merged);
            //Console.WriteLine("Merged and sorted array");

            //foreach (var item in merged)
            //{
            //    Console.Write( item + " " );
            //} 

            #endregion

            #region Q.22
            //22- Write a program in C# Sharp to count the frequency of each element of an array.
            //Console.WriteLine("enter the elements ");
            //int n = int.Parse(Console.ReadLine()!); 
            //int[] arr= new int[n];
            //bool[] bools = new bool[n];

            //Console.WriteLine("enter the elements");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i]=int.Parse(Console.ReadLine()!);

            //}
            //Console.WriteLine("enter the frequencies");
            //for (int i = 0; i < n; i++)
            //{
            //    if (bools[i]) continue;

            //    int count = 1;
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        { 
            //          count++;
            //            bools[j] = true;
            //        }
            //    }

            //    Console.WriteLine( arr[i] + " occurs " + count + " time(s) ");

            //}

            #endregion

            #region Q.23
            //23- Write a program in C# Sharp to find maximum and minimum element in an array
            //Console.WriteLine("enter the number of the elements");
            //int n = int.Parse(Console.ReadLine()!);
            //int[] arr = new int[n];

            //Console.WriteLine("enter the elements");

            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine()!);

            //}

            //int max = arr.Length;
            //int min = arr[0];

            //for (int i = 1; i < n; i++)
            //{ 

            //    if (arr[i] > max)   
            //        max= arr[i];
            //    if (arr[i] < min)
            //        min = arr[i];


            //}

            //    Console.WriteLine("The  Max Number is :" + max);
            //Console.WriteLine("The Minimum Number is :"+min);
            #endregion

            #region Q.24
            //24- Write a program in C# Sharp to find the second largest element in an array.
            //Console.Write("Enter the the number of Elements");
            //int n = int.Parse(Console.ReadLine()!);
            //int[] arr= new int[n];

            //Console.WriteLine("enter the elements");
            //for (int i = 0; i < n; i++)
            //{

            //    arr[i] = int.Parse(Console.ReadLine()!);

            //}

            //int first=int.MinValue;
            //int second=int.MinValue;

            //for (int i = 0; i < n; i++)
            //{
            //    if (arr[i] > first)
            //    {
            //        second = first;
            //        first = arr[i];

            //    }
            //    else if (arr[i] > second && arr[i] !=first)

            //    {

            //       second= arr[i]; 

            //    }




            //}
            //if (second == int.MinValue)
            //{
            //    Console.WriteLine("there is no second largest element (the elements are equal)");

            //}
            //else
            //{

            //    Console.WriteLine("second largest elemnts is :" + second);
            //}



            #endregion

            #region Q.25
            //25-. Consider an Array of Integer values with size N, having values as in this Example
            //Console.WriteLine("enter the elemnts");
            //int n =int.Parse(Console.ReadLine()!);
            //int[] arr= new int[n];

            //Console.WriteLine("enter the elements");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i]=int.Parse(Console.ReadLine()!);
            //}
            // Dictionary<int,int> firstOcc = new Dictionary<int,int>();
            //int maxDistance = 0;
            //for (int i = 0; i < n; i++)
            //{

            //    if (firstOcc.ContainsKey(arr[i]))
            //    {
            //        int distance = i - firstOcc[arr[i]];
            //        if (distance > maxDistance)
            //        {
            //            maxDistance = distance;
            //        }

            //    }
            //    else
            //    {
            //        firstOcc[arr[i]] = i;
            //    }

            //}
            //Console.WriteLine("the longest distance between two cells is :" + maxDistance);
            #endregion

            #region Q.26
            //26- Given a list of space separated words, reverse the order of the words.
            //Console.WriteLine("Enter the Words");
            //string input=Console.ReadLine()!;

            //string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //Array.Reverse(words);

            //Console.WriteLine(string.Join(" ",words));

            #endregion

            #region  Q.27
            // Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //Console.WriteLine("enter the no of rows");
            //int r = int.Parse(Console.ReadLine()!);

            //Console.WriteLine("Enter the no of columns");
            //int c = int.Parse(Console.ReadLine()!);
            //int[,] arr1 = new int[r, c];
            //int[ , ] arr2 = new int[r,c];

            //Console.WriteLine("enter the elemnts for the first array");
            //for (int i = 0; i < r; i++)
            //{
            //    for (int j = 0; j < c; j++)
            //    {
            //     Console.Write($"Element [{i},{j}] : ");
            //        arr1[i,j]=int.Parse(Console.ReadLine()!);

            //    }

            //}

            //for (int i = 0; i < r; i++)
            //{
            //    for (int j = 0; j < c; j++)
            //    {

            //        arr2[i,j]=arr1[(int)i,j];

            //    }
            //}

            //Console.WriteLine("second array copies from the first arr");
            //for (int i = 0; i < r; i++)

            //{
            //    for (int j = 0; j < c; j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");                
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q.28
            //28- Write a Program to Print One Dimensional Array in Reverse Order
            //Console.WriteLine("enter the elemnts");
            //int n = int.Parse(Console.ReadLine()!); 
            //int[] arr=new int[n];

            //Console.WriteLine("enter array elemnts");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] =int.Parse(Console.ReadLine()!);
            //}
            //Console.WriteLine("Array in reverse order");
            //for (int i = n-1; i>=0 ; i--)
            //{

            //    Console.Write(arr[i] + " ");
            //}
            #endregion

        }








    }

}