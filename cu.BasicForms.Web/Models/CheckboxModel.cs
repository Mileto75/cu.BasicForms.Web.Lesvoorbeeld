using Microsoft.AspNetCore.Mvc;

namespace cu.BasicForms.Web.Models
{
    public class CheckboxModel
    {
        public bool IsSelected { get; set; }
        [HiddenInput]
        public string Value { get; set; }
        [HiddenInput]
        public int Id { get; set; }
    }
}
