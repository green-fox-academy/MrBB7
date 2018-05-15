using System;
using System.Text;

namespace UrlFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            url = url.Replace("bots", "odds");

            String modifiedurl = url.Insert(5, ":");
            Console.WriteLine("The modified url: '{0}'", modifiedurl);


            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            Console.ReadLine();
        }
    }
}
