﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_WebApplication1_DBFirst.Models;

namespace ASP.NET_WebApplication1_DBFirst.Controllers
{
    public class HomeController : Controller
    {
        //Get FootBalLeague
        FootBallLeagueContext db = new FootBallLeagueContext();
        public ViewResult Index()
        {
            return View(db.FootBallLeague.ToList());
        }

    }
}