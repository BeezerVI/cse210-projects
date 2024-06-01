using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> video = new List<Video>(); //"Video Games and Adction", "Hyrum McKay", 32, 1
        video.Add(new Video("Video Games and Adction", "Hyrum McKay", 32, 1));
        video.Add(new Video("Everything you need to know about pets", "Pet guy", 124, 2));
        video.Add(new Video("A random Youtube video", "RandomGuyNamedKevin", 8, 3));
        
        foreach (Video item in video) // Go through list
        {
            item.DisplayYouTubeList();
        }
    }
}