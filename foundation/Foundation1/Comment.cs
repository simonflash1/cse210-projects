using System;

class Comment
{
    private string _author;
    private string _text;

    public Comment(string author, string text)
    {
        this._author = author;
        this._text = text;
    }

    public void Display()
    {
        Console.WriteLine($"Commenter Name: {_author}");
        Console.WriteLine($"Text: {_text}");
    }
}