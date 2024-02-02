using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsAndComments.Entities
{
    class Posts
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Posts() { }
        public Posts(DateTime moment, string title, string content) {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = 0; 
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(Title);
            stringBuilder.Append(Likes);
            stringBuilder.Append(" Likes - ");
            stringBuilder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            stringBuilder.AppendLine(Content);
            stringBuilder.AppendLine("Comments:");
            foreach(Comment comment in Comments)
            {
                stringBuilder.AppendLine(comment.Text);
            }
            return stringBuilder.ToString();

        }
    }
}
