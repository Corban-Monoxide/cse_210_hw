public class Video
{
    private string _author;
    private string _title;
    private int _length; // in seconds

    public string Author
    {
        get { return _author; }
    }

    public string Title
    {
        get { return _title; }
    }

    public int Length
    {
        get { return _length; }
    }

    private List<Comment> _comments;

    public List<Comment> Comments
    {
        get { return _comments; }
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(string user, string commentText)
    {
        Comment comment = new Comment(user, commentText);
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }
}