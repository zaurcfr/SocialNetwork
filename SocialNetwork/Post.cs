using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class Post
    {
        public Post()
        {
            ID = Post_ID++;
        }
        public int ID { get; set; }
        public static int Post_ID { get; set; } = 1;
        public string Content { get; set; }
        public DateTime CreationDateTime { get; set; } = DateTime.Now;
        public int LikeCount { get; set; } = 0;
        public int ViewCount { get; set; } = 0;

        public static Post operator ++(Post p)
        {
            p.LikeCount++;
            p.ViewCount++;
            return p;
        }
        public void LikePost()
        {
            ViewCount++;
            LikeCount++;
        }

        public override string ToString()
        {
            return $"ID: {ID}\nContent: {Content}\nCreation Date: {CreationDateTime.ToLongTimeString()}\nView Count: {ViewCount}\tLike Count: {LikeCount}\n";
        }
    }
}
