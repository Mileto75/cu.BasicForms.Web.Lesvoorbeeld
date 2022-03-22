using cu.BasicForms.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cu.BasicForms.Web.ViewModels
{
    public class OrdersOrderViewModel
    {
        [DisplayName("Email of gebruikersnaam:")]
        [Required(ErrorMessage = "Geef gebruikersnaam in!")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Geef een correct emailadres in!")]
        public string Username { get; set; }
        [DisplayName("Wanneer?")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Geef een datum in!")]
        public DateTime OrderDate { get; set; }
        [DisplayName("Wat?")]
        public int FoodId { get; set; }
        public IEnumerable<SelectListItem> Foods { get; set; }
        [DisplayName("Hoeveel?")]
        [Required(ErrorMessage = "Geef aantal stuks in!")]
        [Range(1,5,ErrorMessage = "Aantal moet tussen 1 en 5 liggen!")]
        public int Quantity { get; set; }
        public List<CheckboxModel> Extras { get; set; }
    }
}
