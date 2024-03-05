namespace Task3;

public abstract class AbstractBook:Readable
{
    public string Title { get; set; }
    public string Autor { get; set; }
    public void SetTitle(string title)
    {
        Title=title;
    }
    public void SetAutor(string autor)
    {
        Autor=autor;
    }
    public string GetTitle()
    {
        return Title;
    }
        public string GetAutor()
    {
        return Autor;
    }

    public void Read()
    {
       System.Console.WriteLine("The book is being read.");;
    }
}
