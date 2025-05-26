public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public void AddComment(Comment comment)
    {
        if (_comments == null)
        {
            _comments = new List<Comment>();
        }
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments != null ? _comments.Count : 0;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine("Comments:");
        if (_comments != null && _comments.Count > 0)
        {
            Console.WriteLine($"Total Comments: {GetCommentCount()}");
            Console.WriteLine("--------------------");
            // Display each comment

            foreach (var comment in _comments)
            {
                comment.Display();
            }
        }
        else
        {
            Console.WriteLine("No comments yet.");
        }
    }
}