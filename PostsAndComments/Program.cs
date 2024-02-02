using PostsAndComments.Entities;

namespace PostsAndComments
{
    class Program
    {
        static void Main(string[] args)
        {
            Linha();
            Console.WriteLine("POSTS");
            Console.Write("Título do Post: ");
            string title = Console.ReadLine();

            Console.Write("Conteúdo: ");
            string content = Console.ReadLine();

            DateTime moment = DateTime.Now;

            Posts post = new Posts(moment, title, content);
            Linha();
            Console.Clear();

            string mensagem = """
                [1] Ver Post
                [2] Finalizar Programa
                >>> 
                """;

            Linha();
            Console.Write(mensagem);
            int option = int.Parse(Console.ReadLine());
            Linha();

            Console.Clear();

            switch(option)
            {
                case 1:
                    string showPost = $"""
                        Título: {post.Title}
                        Conteúdo: {post.Content}
                        Momento da postagem: {post.Moment}
                        """;
                    Console.WriteLine(showPost);
                    break;
                case 2:
                    Console.WriteLine("Finalizando...");
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.Clear();

            while(true)
            {
                string optionsPost = """
                    [1] Curtir
                    [2] Comentar
                    [3] Sair do Programa
                    >>>> 
                    """;
                Console.Write(optionsPost);
                int optionPost = int.Parse(Console.ReadLine());
                while(optionPost > 3 || optionPost < 1)
                {
                    Console.Write("Opção inválida. Tente novamente: ");
                    optionPost = int.Parse(Console.ReadLine());
                }

                Console.Clear();

                if(optionPost == 1)
                {
                    post.Likes += 1;
                    Console.WriteLine("Curtido com sucesso!");
                }
                else if(optionPost == 2)
                {
                    Console.Write("Comentário: ");
                    string comentario = Console.ReadLine();
                    Comment comment = new Comment(comentario);
                    post.AddComment(comment);
                }
                else if(optionPost == 3)
                {
                    Console.WriteLine("Finalizando...");
                    Console.WriteLine(post);
                    break;
                }
            }
        }

        static void Linha()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }
    }
}
