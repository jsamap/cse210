using System.ComponentModel.DataAnnotations;

class Comment
{
    private string _commenter;
    private string _text;

    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }
    public void Display()
    {
        Console.WriteLine($" - {_commenter}: {_text}");
    }
}