using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class User : Human
    {
        public List<Post> Posts = new List<Post>();
        public int PostCount { get; set; } = 0;
        public void AddPost(Post post)
        {
            Posts.Add(post);
        }
        public void Like(int id)
        {
            foreach (var item in Posts)
            {
                if (item.ID==id)
                {
                    item.LikePost();
                }
            }
        }
        public void ShowPosts()
        {
            foreach (var item in Posts)
            {
                Console.WriteLine(item);
            }
        }


    }
}
