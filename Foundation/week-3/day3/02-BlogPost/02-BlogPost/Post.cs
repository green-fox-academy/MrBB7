using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost
{
    class BlogPost
    {
        public string AuthorName;
        public string Title;
        public string Text;
        public string PublicationDate;

        public BlogPost(string authorName, string title, string text, string publicationDate)
        {
            AuthorName = authorName;
            Title = title;
            Text = text;
            PublicationDate = publicationDate;
        }
    }
}

