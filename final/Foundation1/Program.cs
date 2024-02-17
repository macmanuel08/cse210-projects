using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("My first vlog about C#","AwesomeDev", 400);
        video1.AddComment("Bill Gates","Awesome video");
        video1.AddComment("Mark Zuckerburg","I wish I knew that before");
        video1.AddComment("Elon Musk","The vlog is incredible");
        videos.Add(video1);

        Video video2 = new Video("My second vlog about C#","AwesomeDev", 900);
        video2.AddComment("Bill Gates","First to comment :)");
        video2.AddComment("Elon Musk","I love the new ideas");
        video2.AddComment("Mark Zuckerburg","You nailed it");
        videos.Add(video2);

        Video video3 = new Video("My third vlog about C#","AwesomeDev", 1000);
        video3.AddComment("Mark Zuckerburg","I should redo the coding for Facebook and follow your design");
        video3.AddComment("Bill Gates","Microsoft will be better if I implement your idea");
        video3.AddComment("Elon Musk","Thinking if I could use those for Tesla's improvement");
        videos.Add(video3);

        foreach(Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}