using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ator.Entity
{
    public class EntityBase
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        public DateTime? CreateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name = "创建人")]
        [StringLength(32)]
        public string CreateUser { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [Display(Name = "修改时间")]
        public DateTime? EditTime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [Display(Name = "修改人")]
        [StringLength(32)]
        public string EditUser { get; set; }

        /// <summary>
        /// 状态0-删除，1-正常，2-禁用
        /// </summary>
        [Display(Name = "状态0-删除，1-正常，2-禁用,...")]
        public int? Status { get; set; } = 1;

        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        [StringLength(200)]
        public string Remark { get; set; } = "";
    }
}
