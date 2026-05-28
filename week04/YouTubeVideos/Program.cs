using System;
class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Code in C#", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));

        Video video2 = new Video("Learn Python in 10 Minutes", "Jane Smith", 600);
        video2.AddComment(new Comment("Charlie", "This was a bit too fast for me."));
        video2.AddComment(new Comment("Dave", "Awesome tutorial!"));

        List<Video> videos = new List<Video> { video1, video2 };

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetDisplayText());
            }
            Console.WriteLine();
        }


    }
}