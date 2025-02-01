// class template for objects called Comments. Used to store comments on Youtube Video objects. 
// holds author and text of comments.

public class Comment
{
    // attributes
    private string _author;
    private string _text;

    // construction
    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    // methods
    public string GetComment()
    {
        string comment = $"Name: {_author}\n{_text}";
        return comment;
    }
}