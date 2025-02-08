using System;
class Book
{
    public string Title;
    public int PublicationYear;
    public Book(string title, int publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Publication Year: {PublicationYear}");
    }
}
class Author : Book
{
    public string Name;
    public string Bio;
    public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear)
    {
        Name = name;
        Bio = bio;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Publication Year: {PublicationYear}, Author: {Name}, Bio: {Bio}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Author a = new Author("C#", 2021, "John Doe", "Expert in C# and .NET");
        a.DisplayInfo();
    }
}
