public class Comment{
    public Comment(string userName, string text){
        _userName = userName;
        _text = text;
    }

    private string _userName;
    private string _text;
    public string GetFullCommentString(){return $"{_userName}: {_text}";}
}