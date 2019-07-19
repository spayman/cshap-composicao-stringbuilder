using System;
using StringBiulder.Entities;

namespace StringBiulder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Tenha uma boa viagem");
            Comment c2 = new Comment("Ual isto é muito legal!");

            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Viajando para Nova Zelandia",
                "Estou indo visitar esse maravilhoso pais!", 12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Boa noite");
            Comment c4 = new Comment("Que a força esteja com você");

            Post p2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Boa noite pessoal",
                "Vejo vocês amanhã.", 5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);


        }
    }
}
