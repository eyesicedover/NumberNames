using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using NumberNames.Models;
using System;

namespace NumberNames.Controllers
{
  public class HomeController : Controller
  {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpPost("/")]
      public ActionResult Create()
      {
        Naming newNaming = new Naming(Request.Form["input"]);
        newNaming.SetChunks();
        return View("Result", newNaming);
      }

  }

}
