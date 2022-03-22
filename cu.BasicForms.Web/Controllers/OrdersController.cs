using cu.BasicForms.Web.Models;
using cu.BasicForms.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace cu.BasicForms.Web.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Order()
        {
            OrdersOrderViewModel ordersOrderViewModel = new OrdersOrderViewModel();
            ordersOrderViewModel.Foods
                = new List<SelectListItem> {
                new SelectListItem
                {
                    Value = "1",Text="Spaghetti Marinara"
                },
                new SelectListItem
                {
                    Value = "2",Text="Spaghetti Carbonara"
                },
                new SelectListItem
                {
                    Value = "3",Text="Rigatoni al Forno"
                },
                new SelectListItem
                {
                    Value = "4",Text="Pizza Diavola"
                }
                };
            //set the extras
            ordersOrderViewModel.Extras = new List<CheckboxModel> { 
                new CheckboxModel{Id = 1, Value = "Cheese"},
                new CheckboxModel{Id = 2, Value = "Spicy oil"},
                new CheckboxModel{Id = 3, Value = "Garlic bread"},
                new CheckboxModel{Id = 4, Value = "Basil oil"},
            };


            //set the date
            ordersOrderViewModel.OrderDate = DateTime.Parse(DateTime.Now.ToString("g"));
            return View(ordersOrderViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Order(OrdersOrderViewModel
            ordersOrderViewModel)
        {
            //perform model validation
            if(!ModelState.IsValid)
            {
                //form has errors
                //repopulate list of foods
                ordersOrderViewModel.Foods
                = new List<SelectListItem> {
                new SelectListItem
                {
                    Value = "1",Text="Spaghetti Marinara"
                },
                new SelectListItem
                {
                    Value = "2",Text="Spaghetti Carbonara"
                },
                new SelectListItem
                {
                    Value = "3",Text="Rigatoni al Forno"
                },
                new SelectListItem
                {
                    Value = "4",Text="Pizza Diavola"
                }
                };
                //send back the view
                return View(ordersOrderViewModel);
            }
            //everything ok!
            //store order
            return RedirectToAction("Confirmation");
        }
        [HttpGet]
        public IActionResult Confirmation()
        {
            return View();
        }
    }
}
