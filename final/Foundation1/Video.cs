using System.Runtime.CompilerServices;

public class Video{
    private string _title;
    private string _author;
    private float _videoLength;

    public List<Comment> _comment = new List<Comment>();

    public void AddComment(string username, string content)
    {
        _comment.Add(new Comment(username, content));
    }

    public Video(string title, string author, float videoLength, int commentChoice)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;

        if (commentChoice == 1){
            AddComment("Big Gamer37", "Bro I love this youtube video its the best!");
            AddComment("SlugCatGamer36", "Simple can only say nice!");
            AddComment("FunnyMan", "I shure love to know more about this topic is ther anything ealse you could give us?");          
        }
        else if (commentChoice == 2){
            AddComment("KittyPaws", "Meow");
            AddComment("PetLover", "Just love to watch a two hour video about pets!");
            AddComment("ThatOneGuy101", "This is 101 for all you need to know about pets!");
        }
        else {
            AddComment("PokemonB0Y", "I forgot why I am commenting on this");
            AddComment("F3K1NCH@D", "LETS GOOOOO!");
            AddComment("Sleppy boy", "Im tierd you guys, I want sleep");
        }
    }

    public void DisplayYouTubeList(){
        Console.WriteLine($"\n  {_title}\nLength {_videoLength}\nBy {_author}\n\n There are {FindNumberOfComments()} Comments:");

        foreach (Comment item in _comment){ // Go through list of comments
            Console.WriteLine($"{item.GetFullCommentString()}\n");
        }
    }
    private int FindNumberOfComments(){return _comment.Count;}
}