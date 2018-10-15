using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ator.Entity.Sys
{
    [Table("Sys_LinkType")]
    public class SysLinkType : EntityBase
    {
        [Key]
        [StringLength(32)]
        public string SysLinkTypeId { get; set; }

        [Display(Name = "链接类型名称")]
        [StringLength(32)]
        public string SysLinkTypeName { get; set; }

        [Display(Name = "分组")]
        [StringLength(32)]
        public string Group { get; set; }

        [Display(Name = "排序")]
        public int Sort { get; set; } = 0;
    }
}
