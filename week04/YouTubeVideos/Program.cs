using System;

class Program
{
    static void Main(string[] args)
    {
        // youtube video project.
        List<Video> VideosList = new List<Video>();
        Video Vid1 = new Video("Dark Fantasy Cello Music for Deep Focus", "Nocturnal Soundscapes", 3600);
        Vid1.AddComment("AI-MusicPlanet", "Great music and artwork 100%");
        Vid1.AddComment("madalynnmccarron4590", "it's nice that this (and some of your other vids) is a perfect hour, it helps me put in a 'break alarm' video to remind me to stretch");
        Vid1.AddComment("01247Brandon", "There's something so beautiful about this. It gives me 'We've won, but at what cost?', vibes. I can imagine the hero of the battle dying on the battlefield but in return the lives of so many have been spared. The thumbnail deserves praise as well. Gorgeous wallpaper and fits the video very well.");
        VideosList.Add(Vid1);

        Video Vid2 = new Video("TWRP - Starlight Brigade (feat. Dan Avidan) [Official video]", "TWRPtube", 248);
        Vid2.AddComment("squib3825", "5 years later and i still think about this song. I'm an art student now and in my animation class we were assigned to share a piece of animation that we love or that impacted us. I'm showing this one.");
        Vid2.AddComment("HandsomeRagz", "So, two questions\n1.) Is Starlight Brigade going to be the official title for the TWRP/NSP mega band? (Much like The Forces of Evil for the SKA scene)\n2.) Can and will you make an Album and full feature film of this like Daft Punk did with the Discovery album and Interstella 5555?");
        Vid2.AddComment("markiplier", "Holy crap... that was amazing!");
        Vid2.AddComment("justinfootexlv", "I come back to this video about once every few months. I think it might be my favorite thing on YouTube.");
        VideosList.Add(Vid2);

        Video Vid3 = new Video("Guilhem Desq - Cicatrices - Hurdy Gurdy", "Guilhem Desq", 246);
        Vid3.AddComment("opalgoblin", "The Hurdy Gurdy is a medieval synthesizer keyboard");
        Vid3.AddComment("NotAushire", "Saving this for the dramatic reveal in my D&D campaign");
        Vid3.AddComment("iNahtanoJ", "never seen someone with such an intimate knowledge of every part of his instrument");
        VideosList.Add(Vid3);
        
        int loopNumber = 0;
        foreach (Video i in VideosList)
        {
            String VidInfo = i.DisplayVideo();
            loopNumber ++;
            Console.WriteLine($"Video {loopNumber}:\n {VidInfo}");
            Console.WriteLine($"Comments on Video {loopNumber}:");
            i.PrintComments();
            Console.WriteLine();
        }
    }
}