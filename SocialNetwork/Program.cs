
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class Program
    {
        static void AdminMenu()
        {
            Console.WriteLine("1.Show Posts");
            Console.WriteLine("2.Remove Post");
        }
        static void UserMenu()
        {
            Console.WriteLine("1.Show Posts");
            Console.WriteLine("2.Add Post");
        }

        static bool SignIn(Human human, string username, string password)
        {
            if (human.Username == username)
            {
                if (human.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Admin admin1 = new Admin
            {
                Name = "Admin",
                Surname = "Admin",
                Username = "admin",
                Password = "admin"
            };
            User user1 = new User
            {
                Name = "Zaur",
                Surname = "Jafarov",
                Age = 19,
                Username = "zaur",
                Password = "1234"
            };
            List<User> users = new List<User>();
            users.Add(user1);

            string username;
            string password;
            string choiceAdmin;
            string choiceUser;
            Console.WriteLine("Log In:\n1)Admin\n2)User");
            string choice = Console.ReadLine();
            bool b = true;
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Username'i daxil edin: ");
                    username = Console.ReadLine();
                    Console.WriteLine("Password'u daxil edin: ");
                    password = Console.ReadLine();
                    SignIn(admin1, username, password);
                    while (b)
                    {
                        Console.Clear();
                        AdminMenu();
                        choiceAdmin = Console.ReadLine();
                        switch (choiceAdmin)
                        {
                            case "1":
                                foreach (var item in users)
                                {
                                    item.ShowPosts();
                                }
                                break;
                            case "2":
                                foreach (var item in users)
                                {
                                    item.ShowPosts();
                                }
                                Console.WriteLine("Choose an ID: ");
                                int Id = Convert.ToInt32(Console.ReadLine());
                                admin1.RemovePost(Id);
                                break;
                            case "0":
                                b = false;
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine("Username'i daxil edin: ");
                    username = Console.ReadLine();
                    Console.WriteLine("Password'u daxil edin: ");
                    password = Console.ReadLine();
                    SignIn(user1, username, password);
                    while (b)
                    {
                        Console.Clear();
                        UserMenu();
                        choiceUser = Console.ReadLine();
                        switch (choiceUser)
                        {
                            case "1":
                                user1.ShowPosts();
                                Console.ReadLine();
                                break;
                            case "2":
                                Console.WriteLine("Write a content: ");
                                string content = Console.ReadLine();
                                var post = new Post
                                {
                                    Content = content
                                };
                                user1.AddPost(post);
                                break;
                            case "3":
                                user1.ShowPosts();
                                Console.WriteLine("Enter an ID: ");
                                int id = Convert.ToInt32(Console.ReadLine());
                                user1.Like(id);
                                break;
                            case "0":
                                b = false;
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }



        }
    }
}
