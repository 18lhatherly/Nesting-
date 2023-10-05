using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesting____________________
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nested things 
            string userName;
            string userPassword;
            string[] userNames = { "Laura", "Luke" };
            string[] userPasswords = { "Password123", "Password456" };
            bool userCorrect = false;
            bool passCorrect = false;
            
            while (userCorrect == false)
            {
                Console.Write("Please input a name: ");
                userName = Console.ReadLine();
                for(int i = 0; i<userNames.Length; i++)
                {
                    if (userName == userNames[i])
                    {
                        userCorrect = true;

                        Console.WriteLine("Correct");

                        while (passCorrect == false)
                        {
                            Console.Write("Please enter your password: ");
                            userPassword = Console.ReadLine();
                            if (userPassword == "Password123" | userPassword == "Password456")
                            {
                                passCorrect = true;
                                Console.WriteLine("You are logged in!");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect password");
                            }
                        }
                    }
                }
                
                else
                {
                    Console.WriteLine("Incorrect");
                }
            }
            
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
