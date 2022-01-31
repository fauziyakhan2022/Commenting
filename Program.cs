using System;
using System.Linq;

namespace week2project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            int len = s.Length;
            if (len <= 10000)
            {
                string final_string = RemoveVowels(s);
                Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Lenght of input string should be less than 10000");
            }


            //NEXT

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //NEXT

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();

            //NEXT

            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is: {0}", diagSum);
            Console.WriteLine();

            //NEXT

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is: {0}", rotated_string);
            Console.WriteLine();

            //NEXT

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix: {0}", reversed_string);
            Console.WriteLine();
        }
        private static string RemoveVowels(string s)
        {
            try
            {
                // write your code here
                String final_string = "";
                foreach (char z in s)
                {
                    // The logic is to find instances of the vowel either in small or capital and writing a reg function to ignore the vowels and form a new string from the original string minus the vowels. 
                    if (z != 'a' && z != 'e' && z != 'i' && z != 'o' && z != 'u' && z != 'A' && z != 'E' && z != 'I' && z != 'O' && z != 'U')
                    {
                        final_string = final_string + z;
                    }
                }
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                // The two input strings are compaored for being equal. if the strings are equal, it is true,e lse false.
                string b1 = "";
                foreach (string s in bulls_string1)
                {
                    b1 = b1 + s;
                }
                string b2 = "";
                foreach (string s in bulls_string2)
                {
                    b2 = b2 + s;
                }
                if (b1 == b2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {

                // First task is to identify unique number, and once the number is unique, add all of them to find the final outcome. Also, if all the numbers in the array are not unique, the output would be zero.


                int len = bull_bucks.Length;
                int[] sample = new int[len];
                int count = 0;
                for (int i = 0; i < len; i++)
                {
                    int n = bull_bucks[i];
                    if (sample.Contains(n))
                    {
                        count = count - n;
                    }
                    else
                    {
                        count = count + n;
                        sample[i] = bull_bucks[i];
                    }
                }
                return count;
            }
            catch
            {
                throw;
            }
        }
        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                // Sum of the numbers in a diagonal of a matrix. care should be taken to avoid double counting of the middle element.
                int len = Convert.ToInt32(Math.Sqrt(bulls_grid.Length));
                int sum = 0;
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        if (i == j)
                        {
                            sum = sum + bulls_grid[i, j];
                        }
                        else if (i + j == (len - 1))
                        {
                            sum = sum + bulls_grid[i, j];
                        }
                    }
                }
                return sum;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }
        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
               //Shuffling of the character of a string so that after multiple reshuffle, original position is restored
                int len = indices.Length;
                string result = "";
                for (int i = 0; i < len; i++)
                {
                    int n = Array.IndexOf(indices, i);
                    result = result + bulls_string[n];
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                String prefix_string = "";
                int len = bulls_string6.Length;
                int n = bulls_string6.IndexOf(ch, 0, len);
                for (int i = n; i >= 0; i--)
                {
                    prefix_string = prefix_string + bulls_string6[i];
                }
                for (int i = n + 1; i < len; i++)
                {
                    prefix_string = prefix_string + bulls_string6[i];
                }
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
