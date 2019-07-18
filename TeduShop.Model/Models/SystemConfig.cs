﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("SystemConfig")]
    public class SystemConfig
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName ="varchar")]
        public string Code { get; set; }

        [MaxLength(250)]
        public string ValueString { get; set; }

        public int? ValueInt { get; set; }
    }
}