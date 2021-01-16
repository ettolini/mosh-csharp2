using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("Should I delete the System32 folder?", "My friend told me to do it");
            
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();

            System.Console.WriteLine("This is my post's vote value: " + post.VoteValue);
        }
    }

    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _dateTime;
        private int _votes;

        public Post(string title, string description)
        {
            this._title = title;
            this._description = description;
            this._dateTime = DateTime.Now;
        }

        public int VoteValue
        {
            get
            {
                return this._votes;
            }
        }

        public void UpVote()
        {
            this._votes++;
        }

        public void DownVote()
        {
            this._votes--;
        }
    }
}