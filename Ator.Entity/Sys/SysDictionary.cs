﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ator.Entity.Sys
{
    [Table("Sys_Dictionary")]
    public class SysDictionary : EntityBase
    {
        [Key]
        [StringLength(32)]
        public string SysDictionaryId { get; set; }

        [Display(Name = "字典名称")]
        [StringLength(32)]
        public string SysDictionaryName { get; set; }

        [Display(Name = "排序")]
        public int Sort { get; set; } = 0;
    }
}
