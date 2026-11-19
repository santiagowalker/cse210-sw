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

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CountComments()
    {
        return _comments.Count;
    }

    public string GetDisplayInfo()
    {
        string videoInfo = $"{_title}, {_author}, {_length} seconds, {CountComments()} comments";
        foreach(Comment c in _comments)
        {
            string newLine = c.GetDisplayText();
            videoInfo += "\n" + newLine;
        }
        return videoInfo;
    }
}