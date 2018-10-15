﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ator.Entity.Sys
{
    [Table("Sys_LinkItem")]
    public class SysLinkItem : EntityBase
    {
        [Key]
        [StringLength(32)]
        public string SysLinkItemId { get; set; }

        [Display(Name = "链接类型ID")]
        [StringLength(32)]
        public string SysLinkTypeId { get; set; }

        [Display(Name = "链接名称")]
        [StringLength(32)]
        public string SysLinkName { get; set; }

        [Display(Name = "链接图片")]
        [StringLength(255)]
        public string SysLinkImg { get; set; }

        [Display(Name = "排序")]
        public int Sort { get; set; } = 0;

        [ForeignKey("SysLinkTypeId")]
        public virtual SysLinkType SysLinkType { get; set; }
    }
}
