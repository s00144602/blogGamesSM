using blogGames.Models;
using blogGames.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace blogGames.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Typically we retrieve data from the database
            //...and inject the retrievevd data into ViewModel -> View
            //For now we will fake the data rather than use a database
            Blog otc = new Blog { BlogTitle = "Ode to Code", BlogAuthor = "Scott Allen" };
            Blog hm = new Blog
            {
                BlogTitle = "Hanselman Minutes",
                BlogAuthor = "Hanselman",
                BlogPosts = new List<Post> {
                    new Post { PostTitle = "Ef 6 Launched", PostContent="EF6 is wonderful" },
                    new Post { PostTitle= "Blah Blah" , PostContent = "Great yeah"}
             }
            };

            BlogViewModel bvm = new BlogViewModel()
            { TheBlogs = new List<Blog>() { otc, hm } };
            bvm.NumberOfBlogs = bvm.TheBlogs.Count;
            return View(bvm);//pass the viewmodel to the view to display
        }

        public ActionResult Details(string id)
        {
       
            Blog otc = new Blog { BlogTitle = "Ode to Code", BlogAuthor = "Scott Allen" };
            Blog hm = new Blog
            {
                BlogTitle = "Hanselman Minutes",
                BlogAuthor = "Hanselman",
                BlogPosts = new List<Post> {
                    new Post { PostTitle = "Ef 6 Launched", PostContent="EF6 is wonderful" },
                    new Post { PostTitle= "Blah Blah" , PostContent = "Great yeah"}
             }
            };

            BlogViewModel bvm = new BlogViewModel()
            { TheBlogs = new List<Blog>() { otc, hm } };
            bvm.NumberOfBlogs = bvm.TheBlogs.Count;

            foreach (Blog blog in bvm.TheBlogs)
            {
                if (blog.BlogTitle == id) return View(blog);
            }
            return View(bvm);//pass the viewmodel to the view to display
        }
    }
}
