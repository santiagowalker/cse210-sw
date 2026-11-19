using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Learning C# Basics", "Jordan Lee", 420);
        Comment c1 = new Comment("Maya", "This explained classes really well.");
        Comment c2 = new Comment("Chris", "The examples were easy to follow.");
        Comment c3 = new Comment("Sofia", "I finally understand constructors.");
        v1.AddComment(c1);
        v1.AddComment(c2);
        v1.AddComment(c3);

        Video v2 = new Video("Morning Workout for Beginners", "Daniel Cruz", 600);
        Comment c4 = new Comment("Ava", "Perfect for starting the day.");
        Comment c5 = new Comment("Liam", "The exercises were manageable.");
        Comment c6 = new Comment("Olivia", "I liked the stretching section.");
        v2.AddComment(c4);
        v2.AddComment(c5);
        v2.AddComment(c6);

        Video v3 = new Video("Easy Pasta Recipe", "Nina Brooks", 305);
        Comment c7 = new Comment("Leo", "I tried this and it was great.");
        Comment c8 = new Comment("Emma", "Very simple recipe.");
        Comment c9 = new Comment("Noah", "Can you make a vegetarian version?");
        v3.AddComment(c7);
        v3.AddComment(c8);
        v3.AddComment(c9);

        List<Video> videos = new List<Video>();
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);
        foreach(Video v in videos)
        {
            Console.WriteLine(v.GetDisplayInfo());
        }
    }
}