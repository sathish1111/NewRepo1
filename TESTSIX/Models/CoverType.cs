﻿
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TESTSIX.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = "";


    }
}
