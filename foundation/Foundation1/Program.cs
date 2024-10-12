using System;
class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Curso GRATIS de Programación Orientada a Objetos ", "hdeleon.net", 4995);
        Video video2 = new Video("CS50x 2024 - Lecture 0 - Scratch", "CS50", 7494);
        Video video3 = new Video("Object Oriented Programming (OOP) in C++ Course", "freeCodeCamp.org", 5425);
        Video video4 = new Video(" Object-oriented Programming in 7 minutes | Mosh ", "Programming with Mosh", 453);


        video1.AddComment(new Comment("David", "Muchas gracias por el curso"));
        video1.AddComment(new Comment("Kate", "Excelente curso"));
        video1.AddComment(new Comment("Juan", "Muy bueno"));
        video1.AddComment(new Comment("Lucy", "Gracias por el curso"));

        video2.AddComment(new Comment("John", "Great teacher"));
        video2.AddComment(new Comment("Phill", "I love CS50"));
        video2.AddComment(new Comment("Jim", "Thank you for teaching"));

        video3.AddComment(new Comment("Adrian", "Great explanation"));
        video3.AddComment(new Comment("Maria", "Thank you for sharing"));
        video3.AddComment(new Comment("Tom", "Finally I understand OOP!!"));
        video3.AddComment(new Comment("Ana", "Great course"));

        video4.AddComment(new Comment("John", "I cant believe how easy is to understand"));
        video4.AddComment(new Comment("Jane", "Thank you for sharing your knowledge"));
        video4.AddComment(new Comment("Jim", "I learned a lot in just 7 minutes"));

        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        foreach (Video video in videos)
        {
            video.Display();
            video.DisplayComments();
            Console.WriteLine("--------------------------------");
        }
    }
}