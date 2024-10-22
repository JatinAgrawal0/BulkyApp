using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace Bulky.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set;} 
        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}