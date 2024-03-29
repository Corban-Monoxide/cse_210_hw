using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video v1 = new Video("My Mom did What?!!", "Mark's Dad", 120);
        Video v2 = new Video("How to Program 101", "Cool Coding Kids", 180);
        Video v3 = new Video("Pizza Time", "Papa John's", 150);

        // Add comments to videos
        // users/comments for video 1
        v1.AddComment("Billy's Mom", "Whoa XD");
        v1.AddComment("Mark", "Why did you do that Dad?");
        v1.AddComment("Random_Guy420", "I like your stuff");

        // users/comments for video 2
        v2.AddComment("C#", "I am supperior");
        v2.AddComment("C++", "C# lies");

        // users/comments for video 3
        v3.AddComment("Papa Murphy's", "I support Pizza");
        v3.AddComment("Domino's", "hat a banger video");
        v3.AddComment("Little Pizzaz", "You have more pizzaz than me");
        v3.AddComment("Cooking Momma", "Very good cooking");

        // Create a list of videos
        List<Video> videos = new List<Video> { v1, v2, v3 };

        // Display information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            // Display comments for the video
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine(comment.DisplayComments());
            }

            Console.WriteLine();
        }
    }
}