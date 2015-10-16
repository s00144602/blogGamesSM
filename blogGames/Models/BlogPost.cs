using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blogGames.Models
{
    public class Blog
    {
        public string BlogTitle { get; set; }

        public string BlogAuthor { get; set; }

        public List<Post>  BlogPosts { get; set; }

        public Blog() { }
    }

    public class Post
    {
        public string PostTitle { get; set; }
        public string PostContent { get; set; }

        public Post() { }
    }
}