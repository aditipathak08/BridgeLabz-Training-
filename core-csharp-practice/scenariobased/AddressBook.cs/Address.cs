using System;
class Address
{
    static void Main()
    {
    Console.WriteLine("Welcome to Address Book Program");
        AdBook myBook = new AdBook();  // Create an Address Book
        while (true)
        {
            Console.WriteLine(" Address Book ");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Display All Contacts");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    Console.Write("First Name: ");
                    string first = Console.ReadLine();
                    Console.Write("Last Name: ");
                    string last = Console.ReadLine();
                    Console.Write("Address: ");
                    string addr = Console.ReadLine();
                    Console.Write("City: ");
                    string city = Console.ReadLine();
                    Console.Write("State: ");
                    string state = Console.ReadLine();
                    Console.Write("Zip: ");
                    string zip = Console.ReadLine();
                    Console.Write("Phone: ");
                    string phone = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Contact c = new Contact(first, last, addr, city, state, zip, phone, email);
                    myBook.AddContact(c);
                    Console.WriteLine("Contact added successfully!");
                    break;

                case "2":
                    // Edit existing contact
                    Console.Write("Enter keyword to search contact: ");
                    string key = Console.ReadLine();
                    myBook.EditContact(key);
                    break;

                case "3":
                    // Display all contacts
                    for (int i = 0; i < myBook.Count; i++)
                    {
                        myBook.GetContact(i).Display();
                        Console.WriteLine("---------------------");
                    }
                    break;

                case "4":
                    // Exit
                    return;

                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }
}