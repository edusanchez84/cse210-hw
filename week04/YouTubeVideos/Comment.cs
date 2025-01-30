using System;

class Comment
{
    private string _commenter;
    private string _comment;
    
    public Comment(string Commenter, string Comment)
    {
        _commenter = Commenter;
        _comment = Comment;
    }

    public void DisplayComments()
    {
        Console.WriteLine($"{_commenter}: {_comment}");
    }
}