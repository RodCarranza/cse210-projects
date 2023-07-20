using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Video v1 = new Video("How to learn english in 1 week", "Mr. Smith", 600);
        v1._comments.Add(new Comment("Juan Lopez", "Good video!"));
        v1._comments.Add(new Comment("Claudia Lars", "Amazing video!!!"));
        v1._comments.Add(new Comment("John Wick", "I can't wait for another video like this!"));

        Video v2 = new Video("Another vs Other - English class 5", "Mr. Smith", 500);
        v2._comments.Add(new Comment("Peter Parker", "Please make more videos like this!"));
        v2._comments.Add(new Comment("Jared Johnson", "What about a video explaining A and An?"));

        Video v3 = new Video("How to expand my vocabulary - English class 20", "Mr. Smith", 200);
        v3._comments.Add(new Comment("John Martinez", "It helped me a lot, thanks!"));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach(Video v in videos)
        {
            Console.WriteLine(v.GetVideoInfo());
            Console.WriteLine($"Total of comments: {v.CommentsTotal()}");

            for(int i = 0; i < v._comments.Count; i++)
            {
                Console.WriteLine(v._comments[i].GetCommentInfo());
            }
        }

        

        
    }
}
