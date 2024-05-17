public class MathAssignment : Assignment{
    private string _section;
    private string _problems;
    public MathAssignment(string name, string topic, string problems, string section) : base(name, topic){
        _section = section;
        _problems = problems;
        

    }
    public string GetHomeworkList(){
        return $"Section {_section}, Problems {_problems}";
        }

}