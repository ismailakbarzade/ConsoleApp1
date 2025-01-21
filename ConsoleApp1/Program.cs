using System;

namespace test
{
    class MyClass
    {
        static void Main(string[] args)
        {
            
            int number;
            string s = Console.ReadLine();
            if (int.TryParse(s, out number))
            {
                int sumResualt= CalculateSum(number);
                int f = FindMax(number);
                if (Find(number))
                {
                    Console.WriteLine("sade edet");
                }
                else
                {
                    Console.WriteLine("murekkeb edet");
                }
                static int FindMax(int number)
                {
                    string numberStr = number.ToString();
                    int numberMax = 0;
                    foreach (char digitChar in numberStr)
                    {
                        int digit = int.Parse(digitChar.ToString());
                        if (digit > numberMax)
                        {
                            numberMax = digit;
                        }
                    }

                    return numberMax;
                }

                static int CalculateSum(int number)
                {
                    int sum = 0;
                    while (number>0)
                    {
                        sum += number % 10;
                        number /= 10;
                    }
                    return sum;
                }

                static bool Find(int number)
                {
                    if (number <= 1)return false;
                    for (int i = 2; i * i <= number; i++)
                    {
                        if (number % i == 0) return false;
                    }
                    return true;
                }

                Console.WriteLine("En boyuk regem "+f);
                Console.WriteLine("regemlerin cemi "+sumResualt);
                
            }
            else
            {
                Console.WriteLine("Not a number");
            }
            
        }
        
    }
}
