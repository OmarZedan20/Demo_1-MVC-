using Microsoft.AspNetCore.Mvc;

namespace Demo_1__MVC_.Controllers
{
    public class MovieController :Controller
    {
        public IActionResult GetMovie(int id , string name , Employee emp)
        {
            // ContentResult result = new ContentResult();
            return Content  ($"Movie with id = {id}");  
            //return result;
        }   
        public IActionResult index() 
        {
            return Redirect("{BaseUrl}/Movie/GetMovie/10");
            //return "index";
        }
    }
}
