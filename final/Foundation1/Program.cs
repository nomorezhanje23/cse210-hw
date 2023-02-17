using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Come Follow Me";
        video1._author = "Line Upon Line";
        video1._time = "480seconds";
       

        Video video2 = new Video();
        video2._title = "Only You";
        video2._author = "Brain Nhira";
        video2._time = "520seconds";

        
        Video video3 = new Video();
        video3._title = "Phakhade Lami";
        video3._author = "Nomfundo Moh";
        video3._time = "380seconds";

        
        Video video4 = new Video();
        video4._title = "How to write a book";
        video4._author = "Dr Miles Monroe";
        video4._time = "1200seconds";

        Comments anyComment = new Comments();
        anyComment._name = " ";

        anyComment._video.Add(video1);
        anyComment._video.Add(video2);
        anyComment._video.Add(video3);
        anyComment._video.Add(video4);

        anyComment.Display();
    }
}