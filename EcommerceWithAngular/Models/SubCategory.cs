﻿using System.ComponentModel.DataAnnotations;

namespace EcommerceWithAngular.Models
{
    public class SubCategory
    {
        public int Id { get; set; }

        [Required]
        [StringLength(70)]
        [Display(Name ="SubCategory Name")]
        public string SubCategoryNqme { get; set; }

        public virtual Category Category { get; set; }
    }
}