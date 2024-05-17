public class Assignment{
    private string _userName;
    private string _topic;
    public Assignment(string name, string topic){
        _userName = name;
        _topic = topic;
    }
    public string GetSummery(){
        return $"{_userName} - {_topic}";
    }

        public string GetStudentName()
    {
        return _userName;
    }
}