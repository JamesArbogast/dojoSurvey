using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dojoSurvey.Models;

namespace dojoSurvey.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
      //for each route this controller is to handle:
      [HttpGet]       //type of request
      [Route("")]     //associated route string (exclude the leading /)
      public ViewResult Index()
      { 
        List<string> dojoLocation = new List<string>()
        {
          "San Jose",
          "Seattle",
          "Orange County",
          "Arlington"
        };
        List<string> favoriteLanguage = new List<string>()
        {
          "JavaScript",
          "Python",
          "Java",
          "C#"
        };

        User user = new User()
        {
          DojoLocation = dojoLocation,
          FavoriteLanguage = favoriteLanguage
        };

        return View("Index", user);
      }

      [HttpPost]
      [Route("/process-survey")]
      public ViewResult ProcessForm(User user)
      {
        return View("Results", user);
      }

      [HttpGet("/results")]
      // GET requests to "localhost:5000/about" go here
      public ViewResult Results()
      {
        return View("Results");
      }


    }
}