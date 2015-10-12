// Filename: Program.cs
// Author: Brahm Ramkissoon
// Created Date  (dd/mm/yyyy): 12/10/2015
// Description: COMP100 Assignment 3
/*
** Create a menu that asks the user if he wants to eat something:
** eg. 	1. Would you like pizza?
** 	2. Would you like a burger?
** 	3. Exit
**
** If the user chooses 1 or 2, then output a statement like " you are eating a burger or pizza".
** After the message is given to the user, show the menu again.
** However if the user chooses 3 then exist the program.
** If the user enters something other than 1,2, or 3, inform him he has made an error and to make an appropriate selection and show the menu again.
** Test your output with different cases.
*/ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main ( string [] args )
        {
            int choice;
            string prompt;
            bool showMenu = true;

            string testOutputX = "x";

            // Show menu and ask for user input
            while ( showMenu )
            {
                Console.WriteLine("What would you like to eat? ");
                Console.WriteLine("++++++++++++++++++++++++++++++");
                Console.WriteLine("1  -  Burger");
                Console.WriteLine("2  -  Pizza");
                Console.WriteLine("3  _  Exit");
                Console.Write("Please enter make your selection (1 to 3): ");

                prompt = Console.ReadLine();
                Console.Write("\n");
                choice = Convert.ToInt32(prompt);

                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
                switch ( choice )
                {
                    case 1:
                        Console.WriteLine("You are eating a burger");
                        showMenu = false;
                        break;
                    case 2:
                        Console.WriteLine("You are eating a pizza");
                        showMenu = false;
                        break;
                    case 3:
                        Console.WriteLine("Goodbye, see you!");
                        showMenu = false;
                        break;
                    default:
                        Console.WriteLine("ERROR - Invalid Entry!!\n");
                        break;
                }
            }

            // Test output

        }
    }
}
