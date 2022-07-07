using System;
using System.Collections;
using System.Text;


public class Program
{

    static public void Main()
    {

        Console.ForegroundColor = ConsoleColor.Green;


        int[] sayilar = new int[] { 11, 3, 5, 7, 9 };
        int target = 18;

        for (int i = 0; i < sayilar.Length; i++)
        {

            for (int j = i + 1; j < sayilar.Length; j++)
            {
                if (sayilar[i] + sayilar[j] == target)
                    
                    Console.WriteLine("Sayılar -> {0}. index({1}) ve {2}. index({3})", i+1, sayilar[i], j+1, sayilar[j]);

            }

        }

        Console.ReadKey();
    }

}
