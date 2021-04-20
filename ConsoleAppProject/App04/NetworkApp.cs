using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        /// <summary>
        /// 
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("     Hakeel's News Feed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image",
                "Display All Posts", "Like", "Unlike", "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: ChoosePosts(true); break;
                    case 5: ChoosePosts(false); break;
                    case 6: wantToQuit = true; break;
                }
            } while (!wantToQuit);

        }

        private void ChoosePosts(bool like)
        {
            foreach (Post currentPost in news.GetPosts())
            {
                Console.Write(currentPost.Id);
                currentPost.Display();
                Console.WriteLine();  
            }

            int choice = int.Parse(Console.ReadLine());
            Post post = news.GetPosts().FirstOrDefault(i => i.Id == choice);

            if (like)
            {
                news.LikePost(post);
            }
            else
            {
                news.UnlikePost(post);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisplayAll()
        {
            news.Display();
        }

        /// <summary>
        /// 
        /// </summary>
        private void PostImage()
        {
            Console.WriteLine("Please enter the caption you would like to post");
            string caption = Console.ReadLine();

            Console.WriteLine("Please enter the author of the post");
            string author = Console.ReadLine();

            Console.WriteLine("Please enter the image name of the post");
            string imageName = Console.ReadLine();
            if (imageName.EndsWith(".jpg") == false)
            {
                imageName = imageName + ".jpg";
            }

            PhotoPost post = new PhotoPost(author, imageName, caption);

            news.AddPhotoPost(post);
        }

        /// <summary>
        /// 
        /// </summary>
        private void PostMessage()
        {
            Console.WriteLine("Please enter the message you would like to post");
            string userInput = Console.ReadLine();

            Console.WriteLine("Please enter the author for your post");
            string author = Console.ReadLine();
            MessagePost post = new MessagePost(author,userInput);

            news.AddMessagePost(post);
        }
    }
}
