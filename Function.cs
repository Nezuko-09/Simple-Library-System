using System.ComponentModel.Design.Serialization;

class Function : IFunction
{
    List<Book> books = new List<Book>();

    public void AddBook()
    {
        Console.WriteLine("Enter the book title");
        string title = Console.ReadLine()!;
        Console.WriteLine("Enter the Authors name ");
        string authorName = Console.ReadLine()!;
        Console.WriteLine("Enter the year the book was written");
        int year;
        bool validYear = int.TryParse(Console.ReadLine(), out year);

        while (!validYear || year < 1800 || year > 2100)
        {
            Console.WriteLine("Input a valid year number not less than 4 digits to align with the current century");
            year = int.Parse(Console.ReadLine()!);
        }
        books.Add(new Book(title, authorName, year));
        Console.WriteLine("Book Has Been Successfully Added");
    }
    public void ViewBooks()
    {

        if (books.Count == 0)
        {
            Console.WriteLine("There are no available books");
        }
        int id = 0;
        foreach (Book book in books)
        {
                id ++;
            Console.WriteLine($"Book 1D - {id }: Title:{book.Title} , Author Name : {book.Author} , Year Published : {book.Year} ,Book status : {book.bookStatus}");
          
        }
    }
    public void BorrowBook()
    {

        Console.WriteLine("Input Book ID");
        int input;
        bool validInput = int.TryParse(Console.ReadLine(), out input);

        while (!validInput || input < 0)
        {
            Console.WriteLine("Input a valid bookid");
            input = int.Parse(Console.ReadLine()!);
        }


        int index = input - 1;
        {
            if (index < 0 || index > books.Count)
            {
                Console.WriteLine("input book ID is wrong");
                return;
            }

            if (books[index].bookStatus == "Borrowed")
            {
                Console.WriteLine("Book is not available ");
                return;
            }
            books[index].bookStatus = "Borrowed";
            Console.WriteLine("Book has been borrowed successfully");
        }

    }
    public void ReturnBook()
    {
        Console.WriteLine("input the id of the borrowed book");
        int id;
        bool validId = int.TryParse(Console.ReadLine(), out id);

        if (!validId)
        {
            Console.WriteLine("Input a valid bookid");
            id = int.Parse(Console.ReadLine()!);
        }
        if (id < 0 )
        {
            Console.WriteLine("number should not be negative");
            id = int.Parse(Console.ReadLine()!);
        }
        int index2 = id - 1;
        if (index2 < 0 || index2 > books.Count )
        {
             Console.WriteLine("input book ID is wrong");
            return;
        }
        if (books[index2].bookStatus == "Available")
        {
            Console.WriteLine("Book cant be returned since it is available ");
            return;
        }
            books[index2].bookStatus = "Available";
            Console.WriteLine("Book has been successfully returned");

    }
    public void Exiting()
    {
        Console.WriteLine("Thanks for using this library system");
        Console.WriteLine("Exiting ......");
        Console.WriteLine(" *.* ");

    }
}
