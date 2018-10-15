﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ator.Entity.Sys
{
    [Table("Sys_Setting")]
    public class SysSetting : EntityBase
    {
        [Key]
        [StringLength(32)]
        public string SysSettingId { get; set; } = Guid.NewGuid().ToString("N");

        [Display(Name = "设置名称")]
        [StringLength(50)]
        public string SysSettingName { get; set; }

        [Display(Name = "设置分组")]
        [StringLength(50)]
        public string SysSettingGroup { get; set; }

        [Display(Name = "设置值")]
        [StringLength(500)]
        public string SetValue { get; set; }

        [Display(Name = "排序")]
        public int Sort { get; set; }

    }
}
