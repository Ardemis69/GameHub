﻿using Microsoft.AspNetCore.Mvc;

namespace GameHub.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}