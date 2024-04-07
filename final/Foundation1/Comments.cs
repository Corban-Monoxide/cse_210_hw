public class Comment
{
    private string _user;
    private string _comment;

    public Comment(string user, string comment)
    {
        _user = user;
        _comment = comment;
    }

    public string DisplayComments()
    {
        return $"{_user}: {_comment}";
    }
}