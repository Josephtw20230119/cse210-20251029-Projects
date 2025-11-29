using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Video video1 = new Video("AI in Everyday Life: 2025 Trends", "FutureTechLab", 1020);
        video1.Add_Comment(new Comment("Sophia", "AI is everywhere now!"));
        video1.Add_Comment(new Comment("Daniel", "Amazing insights on automation."));
        video1.Add_Comment(new Comment("Kevin", "Can you make one about AI in healthcare?"));
        
        
        Video video2 = new Video("Master Python in 20 Minutes (2025 Update)", "CodeWithAlex", 900);
        video2.Add_Comment(new Comment("Liam", "This really helped me understand Python basics!"));
        video2.Add_Comment(new Comment("Emma", "I love the examples!"));
        video2.Add_Comment(new Comment("Noah", "Please make a C# version!"));
        video2.Add_Comment(new Comment("Olivia", "Very clear and concise."));

        Video video3 = new Video("Top 10 Indie Games to Play in 2025", "GamerZone", 780);
        video3.Add_Comment(new Comment("Lucas", "I’ve played #3, it’s amazing!"));
        video3.Add_Comment(new Comment("Mia", "Can’t wait to try #7!"));
        video3.Add_Comment(new Comment("Ethan", "Thanks for the recommendations."));

        // Store videos in a list
        List<Video> _videos = new List<Video> { video1, video2, video3 };

        // Display all videos
        foreach (Video video in _videos)
        {
            video.Display_VideoDetails();
        }
        
            
    }




}
