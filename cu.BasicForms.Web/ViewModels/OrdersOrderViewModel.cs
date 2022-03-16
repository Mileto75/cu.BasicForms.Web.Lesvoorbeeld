using cu.BasicForms.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace cu.BasicForms.Web.ViewModels
{
    public class OrdersOrderViewModel
    {
        [DisplayName("Email of gebruikersnaam:")]
        public string Username { get; set; }
        [DisplayName("Wanneer?")]
        public DateTime OrderDate { get; set; }
        [DisplayName("Wat?")]
        public int FoodId { get; set; }
        public IEnumerable<SelectListItem> Foods { get; set; }
        [DisplayName("Hoeveel?")]
        public int Quantity { get; set; }
        public List<CheckboxModel> Extras { get; set; }

    }
}
