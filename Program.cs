using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<(string Name, string Phone)> contacts = new List<(string, string)>();
        bool running = true;

        Console.WriteLine("Welcome to Simple Contact Book!");
        Console.WriteLine("Welcome to Simple Contact Book!");

        while (running)
        {
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("1. Add a New Contact");
            Console.WriteLine("2. View All Contacts");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option (1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("\nEnter contact name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter phone number: ");
                    string phone = Console.ReadLine();

                    contacts.Add((name, phone));
                    Console.WriteLine($"Contact '{name}' added successfully!");
                    break;

                case "2":
                    Console.WriteLine("\n--- Contact Lists ---");
                    if (contacts.Count == 0)
                    {
                        Console.WriteLine("No contacts yet. Try adding one!");
                    }
                    else
                    {
                        int i = 1;
                        foreach (var contact in contacts)
                        {
                            Console.WriteLine($"{i}. {contact.Name} - {contact.Phone}");
                            i++;
                        }
                    }
                    break;

                case "3":
                    Console.WriteLine("\nThank you for using Contact Book. God Bless!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}

