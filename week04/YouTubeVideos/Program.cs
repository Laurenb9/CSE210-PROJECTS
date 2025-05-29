using System;
using System.Collections.Generic;

// Comment class
class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

// Video class
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; } // in seconds
    public List<Comment> Comments { get; private set; }

    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Nature Documentary", "ExplorerTV", 300);
        video1.AddComment(new Comment("Alice", "Amazing footage!"));
        video1.AddComment(new Comment("Ben", "Very informative."));
        video1.AddComment(new Comment("Claire", "Loved the narration."));

        Video video2 = new Video("Cooking Pasta", "ChefMaster", 420);
        video2.AddComment(new Comment("David", "Tried it and it was delicious!"));
        video2.AddComment(new Comment("Eva", "Clear and simple steps."));
        video2.AddComment(new Comment("Frank", "Looks so tasty!"));

        Video video3 = new Video("Learn Guitar Basics", "MusicTutor", 600);
        video3.AddComment(new Comment("Grace", "This helped a lot!"));
        video3.AddComment(new Comment("Henry", "Great for beginners."));
        video3.AddComment(new Comment("Ivy", "Finally understand chords!"));

        Video video4 = new Video("Travel Vlog: Japan", "WanderWorld", 540);
        video4.AddComment(new Comment("Jack", "Beautiful locations."));
        video4.AddComment(new Comment("Karen", "Loved the food shots."));
        video4.AddComment(new Comment("Leo", "Can’t wait to go!"));

        // Add videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display video details
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Duration: {video.Duration} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40)); // Separator
        }
    }
}
