using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using System.Xml.Serialization;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Multiplication(3, 4);
        Square(8);
        int[] array = { 1, 2, 3, 4, 5 };
        Sum(array);
        XosGelmissiniz("Abbas", "Huseynov");
        TersCevrilis("malaS");
        Divisionbyseven(20);
        Perimeter(5);
        Space("Get the bottle of water");
        
    }

    public static void Multiplication(int num1, int num2)
    {
        Console.WriteLine(num1 * num2);
    }


    public static void Square(int num1)
    {
        Console.WriteLine(num1 * num1);
    }
    public static void Sum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {

            sum += array[i];

        }
        Console.WriteLine(sum);
    }
    public static void XosGelmissiniz(string name, string surname)
    {
        Console.WriteLine($"Welcome {name} {surname}!");
    }
    public static void TersCevrilis(string word)
    {
        for (int i = word.Length - 1; i > -1; i--)
        {
            Console.Write(word[i]);
        }

    }
    public static int Divisionbyseven(int num)
    {
        if (num % 7 == 0)
        {
            Console.WriteLine("Number is divisible by 7");
        }
        else
        {
            Console.WriteLine($"Approximate number is {"3"} ");

        }
        return num;
    }
    public static int Perimeter(int num)
    {
        int sum = 0;
        sum = 4 * num;
        Console.WriteLine(sum);
        return sum;
    }
    public static int Perimeter(int num1, int num2, int num3)
    {
        int sum = 0;
        sum = num1 + num2 + num3;
        Console.WriteLine(sum);
        return sum;
    }
    public static int Space(string sentence)
    {
        
        int count = 0;
        var spaces = sentence.Split(" ");
        foreach (var space in sentence)
        {
            count++;
            Console.WriteLine(count);
        }
     return count;
    }
}

