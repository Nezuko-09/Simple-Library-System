using System.Data.Common;

class Book
{
    public int BookID{get;set;}
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public string bookStatus = "Available";
    
    public Book(string title, string authorName, int year)
    {
        
        Title = title;
        Author = authorName;
        Year = year;
    }
}