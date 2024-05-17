public class WritingAssignment : Assignment
{
     private string _title;
    private string _lesson;
    public WritingAssignment(string name, string topic, string title, string lesson) : base(name, topic){
        _title = title;
        _lesson = lesson;
        

    }
    public string GetWritingInformation(){
        return $"{GetStudentName()} - {_title}, lesson {_lesson}";
        }

}
