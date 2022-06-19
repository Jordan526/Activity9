// See https://aka.ms/new-console-template for more information
using System;

public class Solution
{
    public static void showMeters(int numberOfMillimetes)
    {
        Console.WriteLine(numberOfMillimetes / (double)1000);
    }

    public static void sum(int number1, int number2)
    {
        Console.WriteLine(number1 + number2);
    }
    public static double average(double number1, double number2, double number3, double number4, double number5)
    {
        double average = 0;
        average = (number1 + number2 + number3 + number4 + number5) / 5;
        return average;
    }
    public static double randomSum()
    {
        Random random = new Random(); 
        int number1 = random.Next(10, 50);
        int number2 = random.Next(10, 50);
        return number1 + number2; 
    }
    public static Boolean isDivisibleBy3(int number1, int number2, int number3)
    {
        int sum = 0;
        sum = number1 + number2 + number3; 
        return sum % 3 == 0;
    }
    public static void smallestString(String str1, String str2)
    {
        if(str1.Length < str2.Length)
        {
            Console.WriteLine(str1); 
        } else
        {
            Console.WriteLine(str2);
        }
    }
    
    public static int maxElement(int[] array)
    {
        int max = array[0];
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max; 
    }
    public static int[] generateArray()
    {
        int[] array = new int[50];
        Random random = new Random(); 
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(10, 50); 
        }
        return array;
    }
    public static Boolean checkBooleans(Boolean b1, Boolean b2)
    {
        if (b1 == true && b2 == true)
        {
            return true;
        }
        else if (b1 == false && b2 == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static double findProduct(int number1, double number2)
    {
        return number1 * number2;
    }
    public static double findAverageOf2DArray(int[,] array)
    {
        int count = 0;
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i,j];
                count++;
            }
        }
        return sum / count;
    }




    public static void Main()
    {
        showMeters(200);
        sum(25, 20);
        Console.WriteLine(average(72.2, 53.4, 33.2, 12.2, 10.0));
        Console.WriteLine(randomSum());
        Console.WriteLine(isDivisibleBy3(15, 30, 9));
        smallestString("Jordan", "Wood");
        int[] array = { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine(maxElement(array));
        int[] array2 = generateArray(); 
        foreach(var index in array2)
        {
            Console.Write(index + " ");
        }
        Console.WriteLine();
        Console.WriteLine(checkBooleans(true, false));
        Console.WriteLine(findProduct(5, 6.5));
        int[,] array3 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

    }
}
