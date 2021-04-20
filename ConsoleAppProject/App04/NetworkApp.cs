using System;
using System.Collections.Generic;
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
                "Post Message", "Post Image", "" +
                "Display All Posts", "Quit"
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
                    case 4: wantToQuit = true; break;
                }
            } while (!wantToQuit);

        }

        private void DisplayAll()
        {
            news.Display();
        }

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
