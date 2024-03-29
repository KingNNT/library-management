﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tên nhà xuất bản")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Giới thiệu về nxb")]
        public string Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}