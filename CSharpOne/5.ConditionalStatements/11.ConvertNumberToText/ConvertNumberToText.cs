using System;

// Write a progrram that converts a number in the range [0..999] to a text coresponding to its English pronunciation. Examples :
// 0 -> "Zero" 
// 273 -> "Two handread seventy three"     and more...

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] arr1 = new string[]   // Using some arrays
        {
           "zero","one","two","three","four","five","six","seven","eight","nine"
        };

        string[] arr2 = new string[]
        {
            "ten","eleven","twelve","thirteen","fourteen","fiveteen","sixteen","seventeen","eighteen","nineteen"
        };

        string[] arr3 = new string[]
        {
            "twenty","thirty","fourty","fifty","sixty","seventy","eighty","ninety"
        };

        string[] arr4 = new string[]
        {
            "hundred","two hundred","three hundred","four hundred","five hundred","six hundred","seven hundred","eight hundred","nine hundred"
        };

        int c = n / 100; // Whit this variables separate the number.
        int a = n / 10;
        int b = n % 10;
      
        if ((n >= 0) && (n <= 9))
        {

            for (int i = 0; i < arr1.Length; i++)  // Using for statement to processing arr1
            {
                if (n == i)
                {
                    Console.WriteLine(arr1[i]);
                }   
            }           
        }

        if ((n > 9) && (n <= 19))
        {
            for (int i = 0; i < arr2.Length; i++)
            {
                if (b == i)
                {
                    Console.WriteLine(arr2[i]);
                }
            }
        }

        if ((n > 19) && (n <= 99))
        {
            for (int i = 0; i < arr3.Length; i++)
            {
                if (a == (i + 2))
                {
                    for (int k = 1; k < arr1.Length; k++)
                    {
                        if (b == k)
                        {
                            Console.WriteLine(arr3[i] + arr1[k]);
                        }
                        if (b == 0)
                        {
                            Console.WriteLine(arr3[i]);
                            break;
                        }
                    }
                }
            }
        }


        if ((n > 99) && (n <= 999))
        {
            for (int i = 0; i < arr4.Length; i++)
            {
                if (c == (i + 1))
                    {
                        if (a / c == 10)
                        {
                            Console.WriteLine(arr4[i]);
                            break;
                        }
                        for (int k = 0; k < arr3.Length; k++)
                        {
                            if (c == (k + 1))
                            {
                                for (int j = 1; j < arr1.Length; j++)
                                {
                                    if (b == j)
                                    {
                                        Console.WriteLine(arr4[i] + " and " + arr3[k] + arr1[j]);
                                    }
                                    if (b == 0)
                                    {
                                        Console.WriteLine(arr4[i] + " and " + arr3[k]);
                                        break;
                                    }
                                }
                            }
                        }
                    }           
            }
        }
    }

}