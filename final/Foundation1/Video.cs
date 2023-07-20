public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSec;
    private int _commentsTotal;


    public List<Comment> _comments = new List<Comment>();

    //Constructor

    public Video(string title, string author, int lengthInSec)
    {
        _title = title;
        _author = author;
        _lengthInSec = lengthInSec;

    }

    public string GetVideoInfo()
    {
        return $"Title: {_title}\nAuthor: {_author}\nDuration: {_lengthInSec} seconds\n";
    }


    public int CommentsTotal()
    {
        _commentsTotal = _comments.Count;
        return _commentsTotal;

    }


}
