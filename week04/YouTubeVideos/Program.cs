using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Mom's best cooking tricks", "Sigmund Freud", 180);
        videos.Add(video1);
        Video video2 = new Video("Not all the bluebird are actually blue!", "Gustav Jung", 452);
        videos.Add(video2);
        Video video3 = new Video("The forest after the fire, raising from the ashes", "Carl Rogers", 312);
        videos.Add(video3);
        Video video4 = new Video("Leopard try to hunt baboon but get chased away", "Leon Festinger", 378);
        videos.Add(video4);

        Comment comment1 = new Comment("Leo Messi", "Did not quite got the last trick, but nice and entertaining video, thumbs up!.");
        video1.AddComment(comment1);
        Comment comment2 = new Comment("Crisitano Ronaldo", "Fom the oven to the pan, nice trick, added to my repertorie.");
        video1.AddComment(comment2);
        Comment comment3 = new Comment("Thierry Henry", "Had a great time on the eggs craking trick, love it!.");
        video1.AddComment(comment3);
        Comment comment4 = new Comment("Zinedine Zidane", "Oh, too much time spended on the first three tricks, I would like more detail on the fourth.");
        video1.AddComment(comment4);
        Comment comment5 = new Comment("Luka Modric", "Such an interesing approach on the diversity, even in the same species.");
        video2.AddComment(comment5);
        Comment comment6 = new Comment("Kylian Mbape", "Nah, in the end they are all blue, just different tones of blue... clickbait video.");
        video2.AddComment(comment6);
        Comment comment7 = new Comment("Andres Iniesta", "Very entertaining video, my cat was staring at the tv the hole time.");
        video2.AddComment(comment7);
        Comment comment8 = new Comment("Xavi Hernandez", "I came to see birds, and ended seeing birds, good enough.");
        video2.AddComment(comment8);
        Comment comment9 = new Comment("Ronaldo Nazario", "To see the resilence of nature is someting magestic and motivating.");
        video3.AddComment(comment9);
        Comment comment10 = new Comment("Ronaldinho", "Very good quality documental, the photograpy and image direction was superb.");
        video3.AddComment(comment10);
        Comment comment11 = new Comment("Zlatan Ibrahimovic", "Too boring for my tastes, I thought it will show more of what happened to the fauna also.");
        video3.AddComment(comment11);
        Comment comment12 = new Comment("Kevin de Bruyne", "The sturdines of the bull pine is amazing, I hope we can follow this tree example.");
        video3.AddComment(comment12);
        Comment comment13 = new Comment("Tony Kroos", "hahaha, this one is hilarious!");
        video4.AddComment(comment13);
        Comment comment14 = new Comment("Sergio Ramos", "I think the leopard tried because he had already succeded once.");
        video4.AddComment(comment14);
        Comment comment15 = new Comment("Charles Puyol", "In the begining I was like poor baboons, then after I was like poor leopard jajajaja.");
        video4.AddComment(comment15);
        Comment comment16 = new Comment("Karim Benzema", "As hard and cruel as it is, this is just nature taking it course.");
        video4.AddComment(comment16);

        foreach (Video v in videos)
        {
            v.DisplayVideoComments();
            Console.WriteLine();
        }
        
    }
}