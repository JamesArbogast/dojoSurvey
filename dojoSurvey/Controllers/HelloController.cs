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
        List<string> dojoLocations = new List<string>()
        {
          "San Jose",
          "Seattle",
          "Orange County",
          "Arlington"
        };
        List<string> favoriteLanguages = new List<string>()
        {
          "JavaScript",
          "Python",
          "Java",
          "C#"
        };

        User user = new User()
        {
          DojoLocations = dojoLocations,
          FavoriteLanguage = favoriteLanguages
        };

        return View("Index", user);
      }

      [HttpPost]
      [Route("Index")]
      // POST requests to "localhost:5000/submission" go here
      // (Don't worry about form submissions for now, we will get to those later!)
      public ViewResult ProcessForm(ResultsView newResults)
      {
        return View("Results", newResults);
      }

      [HttpGet("results")]
      // GET requests to "localhost:5000/about" go here
      public ViewResult Results()
      {
        // Method body
        return View("Index");
      }


    }
}