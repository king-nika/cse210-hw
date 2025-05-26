using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Create some videos
        var video1 = new Video { _title = "C# Basics", _author = "Alice", _length = 300, _comments = new List<Comment>() };
        var video2 = new Video { _title = "Advanced C#", _author = "Bob", _length = 450, _comments = new List<Comment>() };
        var video3 = new Video { _title = "LINQ Tutorial", _author = "Charlie", _length = 600, _comments = new List<Comment>() };

        // Add comments to video1
        video1.AddComment(new Comment { _author = "John", _comment = "Great explanation!" });
        video1.AddComment(new Comment { _author = "Sara", _comment = "Very helpful, thanks!" });
        video1.AddComment(new Comment { _author = "Mike", _comment = "I love C#!" });
        video1.AddComment(new Comment { _author = "Emma", _comment = "Can't wait for more videos!" });

        // Add comments to video2
        video2.AddComment(new Comment { _author = "Mike", _comment = "Loved the advanced tips." });
        video2.AddComment(new Comment { _author = "Anna", _comment = "Could you cover async next time?" });
        video2.AddComment(new Comment { _author = "Tom", _comment = "This was very informative." });
        video2.AddComment(new Comment { _author = "Lucy", _comment = "I learned a lot!" });

        // Add comments to video3
        video3.AddComment(new Comment { _author = "David", _comment = "Thanks for the clarification!" });
        video3.AddComment(new Comment { _author = "Eve", _comment = "Great examples!" });
        video3.AddComment(new Comment { _author = "Frank", _comment = "This helped me a lot!" });
        video3.AddComment(new Comment { _author = "Grace", _comment = "I love LINQ!" });

        // Store videos in a list
        var videos = new List<Video> { video1, video2, video3 };

        // Display each video and its comments
        foreach (var video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}