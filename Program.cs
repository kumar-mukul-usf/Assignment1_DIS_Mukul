using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_DIS_Mukul
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

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

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();

            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();
        }



        //Answer1
        private static string RemoveVowels(string s)
        {
            try
            {
                String final_string = "";
                char[] arr = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };//defining a character a array with all the vowels
                              
                StringBuilder str = new StringBuilder(s);//use of string builder to build a string from the input string s
                for(int i = 0; i < str.Length; i++)//till the length of the input string the i will iterate
                {
                    if (arr.Contains(str[i]))//if string contains the character present in the char array 
                    {
                        str = str.Replace(str[i].ToString(), "");//this will remove the character inside the string which matches the character 
                                                                 //present in array as replace is replacing it with no value i.e ""
                    }
                }

                final_string = str.ToString();//final string will store the value of str which has leftover characters in it and then
                                                     //convert it into the complete string
                return final_string; //will return the value of final_string
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }



        //Answer 2
        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            bool program = false;
            string string1 = "";//Initializing the empty string1 for bulls_string1
            string string2 = "";//Initializing the empty string2 for bulls_string2
            try
            {
                string1 = String.Join("", bulls_string1);//joining the words in bull_string1 from wherever there is space and making it a single string
                string2 = String.Join("", bulls_string2);//joining the words in bull_string1 from wherever there is space and making it a single string
                if (string1 == string2)//if the complete string1 and string2 is equivalent else throw exception error
                {
                    program = true;//return true
                }
                return program;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }



        //Answer 3

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                int total = bull_bucks[0];//Initialising the total as the first element of the array 
                Array.Sort(bull_bucks);//Sorting the bull_bucks by putting it in array
                int length = bull_bucks.Length;//taking the complete lenth of the bull_bucks list
                for(int i = 0; i < length - 1; i++)
                {   
                    if(bull_bucks[i] == bull_bucks[i+1])
                    {
                        total = bull_bucks[0];
                        i++;
                       
                    }
                    if (bull_bucks[i] != bull_bucks[i + 1])
                    {
                        total += bull_bucks[i+1];
                    }
                }
                return total ;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }




        //Answer 4
        private static int DiagonalSum(int[,] bulls_grid)
        {
            int total = 0, same_value;
            try
            {
                int size = Convert.ToInt32(Math.Sqrt(bulls_grid.Length));//taking the size of the matrix 
                if (((size > 1) && (size) % 2 != 0))//calculating the repeating value and then substracting it from the total and then saving it in total
                {
                    same_value = (size - 1) / 2;
                    total = total - bulls_grid[same_value, same_value];
                }
                for (int i = size - 1; i >= 0; i--)
                {
                    total = total + bulls_grid[Math.Abs(size - (i + 1)), i];//Calculating the total of first diagonal and overriding the previous total value
                }
                for (int i = 0; i < size; i++)
                {
                    total = total + bulls_grid[i, i];//Calculating the total of the second diagonal and overriding the total value
                }

                return total;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                throw;
            }

        }



        //Answer 5
        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                
                string final_string = "";//Initializing the empty string
                int length = indices.Length; //taking the length of the indices
                for (int x = 0; x < length; x++)//iterating the x till the complete length of the indices
                {
                    int arr = Array.IndexOf(indices, x); //storing the character of the string in their index and saving it in array
                    final_string = final_string + bulls_string[arr];//calculating the final string by adding the value stored in the array based on the indices
                }
                return final_string;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }




        //Answer 6
        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                String prefix_string = "";//Initializing the empty string
                int length = bulls_string6.Length; //Storing the length of the bull string
                int str = bulls_string6.IndexOf(ch, 0, length);//taking the index of the ch and changing it to 0 which will be
                                                               //the starting index and storing the length till it was earlier there
                for(int x = str; x >= 0; x--)//iterating the value of x over the string length to the index of ch where it was earlier present
                                            //and reversing it
                {
                    prefix_string = prefix_string + bulls_string6[x];//storing the value of the revered string
                }
                for(int y = str + 1; y < length; y++)//interating to the lenth of the complete string starting from the earlier 
                                                   //index of the ch 
                {
                    prefix_string = prefix_string + bulls_string6[y];//storing the value of the complete string by concatinating the
                                                                     //previous result with the new result
                }
                return prefix_string;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
    }
}
/// Self Reflection:
/// The total time taken for all these questions where around 25-30 hours as a newbie.
/// The learning from these exercise was very much helpful as i learned about the sorting the algorithm, how to use array and how to
/// reverse an array from any index. Dealing with try catch exception was helpful as well. I also learned about how methods are
/// being called. This exercise gave an complete picture of how a actual code works and going forward how i came implement these
/// concepts in the other programming problems. 
/// Talking about recommendation is that rather than taking all the codes in a single project please take it in different sub projects 
/// where we can provide the sub project links of the github in a single word file.
    

    

