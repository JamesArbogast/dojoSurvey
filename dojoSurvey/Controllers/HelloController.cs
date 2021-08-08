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

        Survey survey = new Survey()
        {
          Name = "",
          DojoLocation = dojoLocation,
          FavoriteLanguage = favoriteLanguage,
          Comment = ""

        };

        return View("Index", survey);
      }

      [HttpPost("/process-survey")]
      public IActionResult ProcessSurvey(Survey survey)
      {
        if(ModelState.IsValid)
        {
            // do somethng!  maybe insert into db?  then we will redirect
            return RedirectToAction("Results");
        }
        else
        {
            // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
            return View("Index");
        }
      }

      [HttpGet("/results")]
      // GET requests to "localhost:5000/about" go here
      public ViewResult Results()
      {
        return View("Results");
      }


    }
}