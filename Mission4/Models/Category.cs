﻿using System;
using System.ComponentModel.DataAnnotations;

//model for category
namespace Mission4.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}