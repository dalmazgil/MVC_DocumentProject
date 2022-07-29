﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class HelpDocument
    {
        [Key]
        public int Id { get; set; }
        public int HelpCategoriesId { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(10000)]
        public string Body { get; set; }
        public int Order { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
    }
}
