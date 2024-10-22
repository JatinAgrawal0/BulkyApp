using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Bulky.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartId {get; set;}

        
        public int ProductId {get; set;}
        [ForeignKey("ProductId")]
        [ValidateNever]
        public Product Product {get; set;}



        [Range(1,1000,ErrorMessage = "Please Enter a value between 1-1000")]
        public int count {get; set;}



        public string ApplicationUserId{get; set;}
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser {get; set;}

        [NotMapped]
        public double Price {get; set;}
        
    }
}