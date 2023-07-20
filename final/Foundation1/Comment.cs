public class Comment
{
    /*
    tracking both the name of the person who made the comment and the text of the comment

    */
    private string _name;
    private string _commentText;

    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;

    }

    public string GetCommentInfo()
    {
        return $"Name: {_name}\nComment: {_commentText}\n";
    }

}
