using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        //public int UserId { get; set; } 
        [Required]
        public string AspNetUserId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Required]
        public decimal Quantity { get; set; }

    }
}