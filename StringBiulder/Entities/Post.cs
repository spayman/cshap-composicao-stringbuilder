using System;
using System.Collections.Generic;
using System.Text;

namespace StringBiulder.Entities
{
    class Post
    {
        // Declaração dos argumentos
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        // Pelo fato dos comentários poderem muitos 'Commments' foi declarado tipo List e intânciado
        // para forçar sua inicialização.
        public List<Comment> Comments { get; set; } = new List<Comment>();
        // Declaração do construtor padrão
        public Post()
        {

        }
        // Declaração do contrutor personalizado
        // OBS.: quando se tem um relacionamento para muitos (neste caso um post e muitos comentários)
        // este atributo não é declarado no contrutor.
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        //----------------------------------------------------------------------------------------
        // Obs.: embora os dois metodos abaixo não estejam especificados no desenho de diagrama
        // eles devem ser declarados (somente em casos especificos eles são evitados)
        //----------------------------------------------------------------------------------------

        // Declaração do metodo para adição de comentários
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        // Declaração do metodo para remoção de comentários
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
        // Usando a classe StringBuilder para montagem mais eficiente para
        // montar saida de texto para o usuário.
        // Pertence ao Name Space System.Text
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/mm/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");

            // Percorre a lista de comentários e passa para o objeto 'sb' instanciado com StringBuider
            // que será chamado pelo programa padrão.
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
