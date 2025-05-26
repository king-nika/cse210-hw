public class Comment
{
    public string _author;
    public string _comment;

    public void Display()
    {
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Comment: {_comment}");
    }
}