using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using blogGames.Models;

namespace blogGames.ViewModels
{
    //a representation of a particular subset of the database
    public class BlogViewModel
    {
        public int NumberOfBlogs { get; set; }

        public List<Blog> TheBlogs { get; set; }
    }
}