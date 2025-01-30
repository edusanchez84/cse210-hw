using System;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string Title, string Author, int Length)
    {
        _title = Title;
        _author = Author;
        _length = Length;
        _comments = [];
    }

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
        
    }

    public int CommentQty()
    {
        return _comments.Count();
    }

    public void DisplayVideoComments()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"By: {_author} -- Duration: {_length} seconds");
        Console.WriteLine($"Number of comments: {CommentQty()}");
        Console.WriteLine("Comments:");
        foreach (Comment i in _comments)
            i.DisplayComments();
    }
}