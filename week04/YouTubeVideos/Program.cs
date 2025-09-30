using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Video> listOfVideos = new List<Video>();

        Video video1 = new Video("OOP Intro", "John Doe", 640, [
            new Comment("Jane", "Thanks for the information."),
            new Comment("Alexa", "I have a question."),
            new Comment("Samantha", "Good material.")
            ]);
        listOfVideos.Add(video1);

        Video video2 = new Video("Designer", "Balu Brigada", 200, [
            new Comment("John", "Good video."),
            new Comment("Alex", "Nice song!"),
            new Comment("Jared", "Great artwork."),
            new Comment("Jared", "I want to go to a concert.")
            ]);
        listOfVideos.Add(video2);

        Video video3 = new Video("Warzone Win", "Player#1", 1250, [
            new Comment("Mike", "Nice gameplay."),
            new Comment("Chester", "Good resolution and framerate!"),
            new Comment("Dave", "How did you do that?")
            ]);
        listOfVideos.Add(video3);

        foreach (Video v in listOfVideos)
        {
            v.Display();
        }

    }
}