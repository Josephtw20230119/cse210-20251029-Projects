

using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class Video
{
    public string _title { get; }
    public string _author { get; }
    public int _lengthInSecond { get; }
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSecond)
    {
        _title = title;
        _author = author;
        _lengthInSecond = lengthInSecond;

    }

    public int Get_CommentCount()
    {
        return _comments.Count();
    }
    public void Add_Comment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void Display_VideoDetails()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"TITLE: {_title}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"AUTHOR: {_author}");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"LENGTH: {_lengthInSecond} seconds");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"COMMENTS COUNT: {Get_CommentCount()}");
        Console.ResetColor();
        Console.WriteLine("COMMENTS:");
        
        if ( _comments.Count > 0)
        {
            int index = 1;
            foreach (Comment comment in _comments)
            {
                Console.WriteLine($"{index}. {comment._name}: {comment._text}");
                index = index + 1;
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No Comment Yet !");
        }
    }
    
}