public class Video
{
    // store attributes of a youtube video including title, author, and length in seconds of video. 
    // store a list of Comment objects that belong to the video.
    // have methods to get the number of comments on the video.

    // attributes
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    // constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    
    // methods
    public int GetNumberOfComments()
    {
        int Number = _comments.Count;
        return Number;
    }

    public string DisplayVideo()
    {
        int NumComments = GetNumberOfComments();
        string VidInfo = $"Title: {_title}\nAuthor:{_author}\nLength in seconds: {_length}\nNumber of comments: {NumComments}";
        return VidInfo;
    }
    public void PrintComments()
    {
        foreach (Comment i in _comments)
        {
            string lineComment = i.GetComment();
            Console.WriteLine(lineComment);
        }
    }
    
    public void AddComment(string author, string text)
    {
        Comment newComment = new Comment(author, text);
        _comments.Add(newComment);
    }
}