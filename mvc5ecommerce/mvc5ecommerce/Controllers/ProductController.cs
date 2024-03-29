﻿using mvc5ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc5ecommerce.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View("List");
        }

        [Route ("product/{productName}")]
        public ActionResult Detail(string productName)
        {
            ViewBag.Product = new Product
            {
                Name = "Women's Winter Jacket",
                FullPrice = 20.00M,
                CurrentPrice = 16.00M,
                PercentOff = 20,
                ImagePath = "/Content/Images/Products/1.jpg",
                StarRating = 4
            };

            return View();
        }
    }
}