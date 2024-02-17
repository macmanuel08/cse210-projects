using System;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void DisplayVideo()
    {
        Console.WriteLine("");
        Console.WriteLine(_title);
        Console.WriteLine($"By {_author}");
        Console.WriteLine($"Length: {_length}");

        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments) {
            comment.DisplayComment();
        }
    }

    public void AddComment(string name, string commentText)
    {
        Comment comment = new Comment(name, commentText);
        _comments.Add(comment);
    }
}