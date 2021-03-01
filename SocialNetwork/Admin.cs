using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class Admin : Human
    {
        public string Username { get; set; }
        public List<Post> Posts { get; set; }
        public int PostCount { get; set; }

        public void RemovePost(int id)
        {
            var item = Posts.FirstOrDefault(p => p.ID == id);
            Posts.Remove(item);
        }

        

    }
}
