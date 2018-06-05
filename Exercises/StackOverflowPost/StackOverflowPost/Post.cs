using System;

namespace StackOverflowPost
{
    public class Post
    {
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime DateCreated { get; set; }
		private int _positiveVotes;
		private int _negativeVotes;
        
        public int PositiveVotes
		{
			get { return _positiveVotes;  }
			private set { _positiveVotes = value; }
		}

		public int NegativeVotes
        {
            get { return _negativeVotes; }
            private set { _negativeVotes = value; }
        }
        
        
        public void UpVote()
		{
			PositiveVotes++;
		}

		public void DownVote()
		{
	        NegativeVotes++;   	
        }

        public void DisplayPost()
		{
			Console.WriteLine("Post Title: " + Title);
			Console.WriteLine("Post Description: " + Description);
			Console.WriteLine("Date Created: " + DateCreated);
            Console.WriteLine();
		}

        public void ShowVotes()
		{
			Console.WriteLine("Number of Positive Votes: " + PositiveVotes);
			Console.WriteLine("Number of Negative Votes: " + NegativeVotes);
            Console.WriteLine();
		}
    }
}
