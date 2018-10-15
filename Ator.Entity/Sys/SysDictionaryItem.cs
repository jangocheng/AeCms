using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ator.Entity.Sys
{
    [Table("Sys_Dictionary_Item")]
    public class SysDictionaryItem
    {
        [Key]
        [StringLength(32)]
        public string SysDictionaryItemId { get; set; }

        [Display(Name = "字典ID")]
        [StringLength(32)]
        public string SysDictionaryId { get; set; }

        [Display(Name = "字典项值")]
        [StringLength(255)]
        public string SysDictionaryValue { get; set; }

        [Display(Name = "字典项名称")]
        [StringLength(32)]
        public string SysDictionaryName { get; set; }

        [Display(Name = "排序")]
        public int Sort { get; set; } = 0;

        [Display(Name = "状态")]
        public int Status { get; set; } = 1;

        [Display(Name = "创建时间")]
        public DateTime? CreateTime { get; set; } = DateTime.Now;

        [ForeignKey("SysDictionaryId")]
        public virtual SysDictionary SysDictionary { get; set; }
    }
}
