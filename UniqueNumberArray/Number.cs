using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueNumberArray;

public class Number
{
    public void Func(int[] arrayNumbers)
    {
        if (arrayNumbers.Length % 2 != 0)
        {
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                int count = 0;
                int numberInArray = arrayNumbers[i];
                foreach (var number in arrayNumbers)
                {
                    if (number == numberInArray)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    numberInArray = arrayNumbers[i];
                    Console.WriteLine();
                    Console.WriteLine(numberInArray);
                    Console.WriteLine();
                }
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Свободен");
            Console.WriteLine();
        }
    }
}
