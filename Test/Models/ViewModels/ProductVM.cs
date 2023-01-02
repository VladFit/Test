using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Test.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategorySelectListItem { get; set; }
        public IEnumerable<SelectListItem> ApplicationTypeSelectListItem { get; set; }
    }
}
