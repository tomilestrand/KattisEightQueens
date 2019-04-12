using System;

namespace EightQueens
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid = true;
            int[] index = new int[8];
            for (int i = 0; i < 8; i++)
            {
                index[i] = Console.ReadLine().IndexOf('*');
            }

            for (int i = 0; i < 8; i++)
            {
                if (index[i] == -1) //Checks if * is missing in any row ie if any row has more than one queen
                {
                    isValid = false;
                    break;
                }
                for (int j = 0; j < i; j++)
                {
                    if (index[i] == index[j]) //Checks if any column has more than one queen
                    {
                        isValid = false;
                        break;
                    }
                }
                if (!isValid)
                {
                    break;
                }
            }

            for (int i = 0; i < 8; i++) //Checks diagonals
            {
                if (!isValid)
                {
                    break;
                }
                for (int j = 0; j < i; j++)
                {
                    if (index[j] == index[i] - i + j || index[j] == index[i] + i - j)
                    {
                        isValid = false;
                        break;
                    }
                }
                for (int j = i + 1; j < 8; j++)
                {
                    if (index[j] == index[i] - i + j || index[j] == index[i] + i - j)
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            if (isValid)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
