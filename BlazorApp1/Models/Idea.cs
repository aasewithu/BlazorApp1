﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BlazorApp1.Models
{
    public class Idea
    {
        public int Id { get; set; }
        [Required]
        public string Note { get; set; }
    }
}
