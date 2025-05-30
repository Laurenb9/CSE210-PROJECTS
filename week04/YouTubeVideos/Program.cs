using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video { Title = "Exploring Mars", Author = "NASA", Length = 300 };
        video1.AddComment(new Comment("Alice", "This is amazing!"));
        video1.AddComment(new Comment("Bob", "Incredible mission."));
        video1.AddComment(new Comment("Charlie", "Go science!"));
        videos.Add(video1);

        Video video2 = new Video { Title = "C# Basics", Author = "CodeAcademy", Length = 600 };
        video2.AddComment(new Comment("Diana", "Very helpful."));
        video2.AddComment(new Comment("Eli", "Loved the explanation."));
        video2.AddComment(new Comment("Frank", "Thanks!"));
        videos.Add(video2);

        Video video3 = new Video { Title = "Nature Documentary", Author = "NatGeo", Length = 1200 };
        video3.AddComment(new Comment("Grace", "So beautiful."));
        video3.AddComment(new Comment("Hank", "Wow, amazing footage."));
        video3.AddComment(new Comment("Ivy", "Loved the animals."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comments ({video.GetCommentCount()}):");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
