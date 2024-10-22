using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;


namespace Bulky.Models
{
    public class OrderDetail
    {
        public int OrderDetailId {get; set;}

        [Required]
        public int OrderHeaderId {get; set;}
        [ForeignKey("OrderHeaderId")]
        [ValidateNever]
        public OrderHeader OrderHeader { get; set; }


        [Required]
        public int ProductId {get; set;}
        [ForeignKey("ProductId")]
        [ValidateNever]
        public Product Product { get; set; }

        public int count{get; set;}
        public double Price{get; set;}


    }
}