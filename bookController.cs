using Microsoft.AspNetCore.Mvc;
using mvc_mine.Models;
using System.Collections.Generic;

namespace mvc_mine.Controllers
{
    public class bookController : Controller

    {
        List<book> books = new List<book>() {
                new book(){Title ="Asp.net " , price = 50, author = "mohamed"  ,
                    description= "for beginners easy explaination of Asp.net that you find your self inside joureny never want to end"} ,
                new book (){Title = "c#" , price = 880,author="ahmed & gorge" , 
                    description= "for beginners easy explaination of C# that you find your self inside joureny never want to end" },
                new book(){Title ="SQl " , price = 900, author = "ali", description = "for beginners easy explaination of SQL that you find your self inside joureny never want to end" } ,

            };

        public IActionResult index()
        {

            return View(books);
        }

        public IActionResult detalis()
        {

            return View();
        }
    }
}
