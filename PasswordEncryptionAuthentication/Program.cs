﻿using System;

namespace PasswordEncryptionAuthentication
{
    public class UserList
    {
        public string _password;
        public string _username;
        
    }

    class Program
    {   
        
        public static void UserInterface()
        {
            Console.WriteLine("PASSWORD AUTHENTICATION SYSTEM\n");
            Console.WriteLine("Please select one option");
            Console.WriteLine("1. Establish an account");
            Console.WriteLine("2. Authenticate a user");
            Console.WriteLine("3. Exit the system\n");
            Console.Write("Enter Selection:  ");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                //Do establish an account method
                UserInterface();
            }
            if (userInput == "2")
            {
                //Do authenticate a user method
                UserInterface();
            }
            if (userInput == "3")
            {
                //Print all usernames, passwords, and encrypted passwords
                Console.WriteLine("Any saved usernames or passwords will be lost");
                Console.WriteLine("See you later alligator");
                // Wait some time then close application
            }
            if (userInput != "1" && userInput !="2" && userInput !="3")
            {
                Console.WriteLine("\nOnly 1, 2, and 3 are correct inputs. Please select on of those numbers.\n");
                UserInterface();
            }
        }
        static void Main(string[] args)
        {
            UserInterface();
        }
    }
}
