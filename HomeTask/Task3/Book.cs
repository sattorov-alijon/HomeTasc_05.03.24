namespace Task3;

public class Book :AbstractBook, Borrowable
{
    public void Borrow()
    {
        System.Console.WriteLine("The book has been borrowed");
    }

    public void ReturnBook()
    {
        System.Console.WriteLine("The book has been returned");
    }
}
