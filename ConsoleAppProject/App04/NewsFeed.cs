﻿using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Hakeel
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        public const string AUTHOR = "Hakeel";

        private readonly List<Post> posts;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();

            MessagePost post = new MessagePost(AUTHOR, "Visual Studio is the best");
            AddMessagePost(post);

            PhotoPost photoPost = new PhotoPost(AUTHOR, "Photo1.jpg", "A new Car");
            AddPhotoPost(photoPost);
        }

        ///<summary>
        /// Adding a message post
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            message.Id = posts.Count + 1;
            posts.Add(message);
        }

        ///<summary>
        /// Adding a photo post
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            photo.Id = posts.Count + 1;
            posts.Add(photo);
        }

        /// <summary>
        /// Liking a post 
        /// </summary>
        public void LikePost(Post post)
        {
            foreach (var currentPost in posts)
            {
                if(currentPost.Id == post.Id)
                currentPost.Like();
            }

        }

        /// <summary>
        /// Unliking a post
        /// </summary>
        public void UnlikePost(Post post)
        {
            foreach (var currentPost in posts)
            {
                if(currentPost.Id == post.Id)
                currentPost.Unlike();
            }
        }


        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }
        }

        /// <summary>
        /// Gets the list of posts
        /// </summary>
        /// <returns></returns>
        public List<Post> GetPosts()
        {
            return posts;
        }
    }

}
