using System;

namespace StackOverflowPost
{
	class Program
	{
		private const string UserPromptMessage = "To upvote press 'u'. To downvote press 'd'. To show votes press 's' To exit press 'x'. ";

		static void Main(string[] args)
		{
			var post = new Post
			{
				Title = "First Blog Post",
				Description = "Hello World",
				DateCreated = new DateTime(2018, 06, 04)
			};
            
			var viewPost = true;
			post.DisplayPost();


            while(viewPost)
			{
				Console.WriteLine(UserPromptMessage);
				var input = Console.ReadLine();
                

				switch(input.ToLower())
				{
					case "u":
						post.UpVote();
                        Console.WriteLine("Vote has been recorded");
                        Console.WriteLine();
						break;
					case "d":
						post.DownVote();
						Console.WriteLine("Vote has been recorded");
                        Console.WriteLine();
						break;
					case "s":
						post.ShowVotes();
						break;
					case "x":
						Console.WriteLine("Exiting Application");
						viewPost = false;
						break;
					default:
                        Console.WriteLine("Invalid input");
                        Console.WriteLine();
                        break;
				}

			}

		}
	}
}
