// //See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class Contacts
{
    public string? Name { get; set; }
    public string? Phonenumber { get; set; }
    public string? Email { get; set; }
}

public class ContactList
{
    static List<Contacts> Contact = new List<Contacts>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("choose any list menu");

            Console.WriteLine("1.Add contacts:");

            Console.WriteLine("2.Remove contacts:");

            Console.WriteLine("3.Search contact:");

            Console.WriteLine("4.Display contacts:");

            Console.WriteLine("5.Exit");

            Console.WriteLine("Choose your choice:");



            string? number = Console.ReadLine()!;
            switch (number)
            {
                case "1":
                    AddContact();
                    break;
                case "2":
                    RemoveContact();
                    break;
                case "3":
                    SearchContact();
                    break;
                case "4":
                    DisplayContact();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("invalid choice:");
                    break;

            }
        }
    }
    static void AddContact()
    {

        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine()!;

        Console.WriteLine("Enter your phonenumber:");
        string phonenumber = Console.ReadLine()!;

        Console.WriteLine("Enter your email");
        string email = Console.ReadLine()!;

        Contacts contact = new Contacts
        {
            Name = name,
            Phonenumber = phonenumber,
            Email = email,
        };

        Contact.Add(contact);

        Console.WriteLine("Contact save successfuly:");

        Console.WriteLine("........................................");


    }


    static void RemoveContact()
    {

        Console.WriteLine("Enter a name to remove:");
        string name = Console.ReadLine()!;

        Console.WriteLine("Enter a phonenumber to remove:");
        string phonenumber = Console.ReadLine()!;

        Console.WriteLine(" Enter Email to Remove: ");
        string email = Console.ReadLine()!;

        Contacts? RemoveContact = Contact.Find(c =>
                c.Name == name &&
                c.Phonenumber == phonenumber &&
                c.Email == email);

        if (RemoveContact != null)
        {
            Contact.Remove(RemoveContact);

            Console.WriteLine("Contact remove successfully ");

            Console.WriteLine(".......................");
        }
        else
        {
            Console.WriteLine("Contact not found:");

            Console.WriteLine(".........................");
        }
    }


    static void SearchContact()
    {

        Console.WriteLine("Enter a name to serch:");
        string name = Console.ReadLine()!;

        Console.WriteLine("Enter a phonenumber to search:");
        string phonenumber = Console.ReadLine()!;

        Console.WriteLine(" Enter Email to search: ");
        string email = Console.ReadLine()!;

        Contacts? searchcontact = Contact.Find(c =>
                c.Name == name &&
                c.Phonenumber == phonenumber &&
                c.Email == email);

        if (searchcontact != null)
        {
            Console.WriteLine($"name: {searchcontact.Name}");

            Console.WriteLine($"phonenumber: {searchcontact.Phonenumber}");

            Console.WriteLine($"email: {searchcontact.Email}");


        }
        else
        {
            Console.WriteLine("contact not found:");

            Console.WriteLine("........................");
        }

    }
    static void DisplayContact()
    {

        foreach (var contact in Contact)
        {
            Console.WriteLine("contact found:/n");
            if (contact != null)
            {
                Console.WriteLine($"name: {contact.Name}");

                Console.WriteLine($"phonenumber: {contact.Phonenumber}");

                Console.WriteLine($"email: {contact.Email}");

                Console.WriteLine("contact display successfully.");


                Console.WriteLine("..............................");

            }

            else
            {
                Console.WriteLine("contact not found");
            }



        }

    }

}



//List<string> name = new List<string>();
//name.Add("John");
//name.Add("Jane");
//name.Add("Jane");

//foreach (var result in name)
//{
//    Console.WriteLine($"{result}");
//}


//Queue<string> queue = new Queue<string>();
//queue.Enqueue("First");
//queue.Enqueue("Second");

//foreach (var result in queue)
//{
//    Console.WriteLine($"{result}");
//}
//string Firsts = queue.Dequeue();
//Console.WriteLine($"{Firsts}");


//Stack<string> browserHistory = new Stack<string>();

//// Navigation
//browserHistory.Push("Page1");
//browserHistory.Push("Page2");
//browserHistory.Push("Page3");

//// Peek at the current page
//string currentPage = browserHistory.Peek();
//Console.WriteLine("Current Page: " + currentPage);

//// Go back (pop) to the previous page
//string previousPage = browserHistory.Pop();
//Console.WriteLine("Previous Page: " + previousPage);

//// Check the count
//int numberOfPages = browserHistory.Count;
//Console.WriteLine("Number of Pages: " + numberOfPages);

//// Clear the browser history
//browserHistory.Clear();
