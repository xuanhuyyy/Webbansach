﻿using System.ComponentModel.DataAnnotations;

namespace WebBanSach.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int DisplayOrder {  get; set; }
        public DateTime CreateDatetime { get; set; } = DateTime.Now;

    }
}
