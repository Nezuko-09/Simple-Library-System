using System.Linq.Expressions;

class Menu : Function
{
    public void DisplayMenu()
    {
        try
        {
            bool repeat = true;
            Console.WriteLine("Welcome to the library");
            Console.WriteLine("We provide great services you would enjoy ");
            Console.WriteLine("Feel free to make a choice from our menu by entering a number");
            while (repeat)
            {
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Borrow a Book");
                Console.WriteLine("4. Return a book");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Make a choice");
                int number;
                bool validNumber = int.TryParse(Console.ReadLine(), out number);
                if (!validNumber)
                {
                    Console.WriteLine("Invalid number: input a numerical value");
                    number = int.Parse(Console.ReadLine()!);
                }
                switch (number)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        ViewBooks();
                        break;
                    case 3:
                        BorrowBook();
                        break;
                    case 4:
                        ReturnBook();
                        break;
                    case 5:
                        repeat = false;
                        Exiting();
                        break;
                    default:
                        Console.WriteLine("input a number from the range");
                        break;
                }
            }

        }
        catch (Exception text)
        {
            Console.WriteLine(text.Message);
        }
    }

    }


