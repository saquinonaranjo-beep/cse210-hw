using System;
class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Code in C#", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Alice", "I have a question about the last part."));

        Video video2 = new Video("Learn Python in 10 Minutes", "Jane Smith", 600);
        video2.AddComment(new Comment("Charlie", "This was a bit too fast for me."));
        video2.AddComment(new Comment("Dave", "Awesome tutorial!"));
        video2.AddComment(new Comment("Charlie", "Can you make a slower version?"));
        video2.AddComment(new Comment("Eve", "I found it very clear, thanks!"));

        Video video3 = new Video("JavaScript Basics", "Emily Davis", 450);
        video3.AddComment(new Comment("Eve", "I love JavaScript!"));
        video3.AddComment(new Comment("Frank", "This is a great introduction."));
        video3.AddComment(new Comment("Eve", "Can you cover more advanced topics?"));

        

        Video video4 = new Video("La incondicional", "Luis Miguel", 240);
        video4.AddComment(new Comment("Fan1", "¡Me encanta esta canción!"));
        video4.AddComment(new Comment("Fan2", "¡Luis Miguel es el mejor!"));
        video4.AddComment(new Comment("Fan1", "¿Alguien más la canta en la ducha?"));
        video4.AddComment(new Comment("Fan3", "¡Una canción clásica!"));

        Video video5 = new Video("Bohemian Rhapsody", "Queen", 360);
        video5.AddComment(new Comment("Fan2", "¡that is amazing!"));
        video5.AddComment(new Comment("Fan4", "¡Freddie Mercury is the best!"));
        video5.AddComment(new Comment("Fan2", "I can sing this all day!"));

        List<Video> videos = new List<Video> { video1, video2, video3, video4, video5 };

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetDisplayText()}");
            }
            Console.WriteLine();
        }


    }
}