﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ator.Entity.Sys
{
    [Table("Sys_User")]
    public class SysUser: EntityBase
    {
        [Key]
        [StringLength(32)]
        public string SysUserId { get; set; } = Guid.NewGuid().ToString("N");

        [Display(Name = "用户名")]
        [StringLength(32)]
        public string UserName { get; set; }

        [Display(Name = "密码")]
        [StringLength(255)]
        public string Password { get; set; }

        [Display(Name = "真实姓名")]
        [StringLength(32)]
        public string TrueName { get; set; }

        [Display(Name = "昵称")]
        [StringLength(32)]
        public string NikeName { get; set; }

        [Display(Name = "手机号")]
        [StringLength(20)]
        public string Mobile { get; set; }

        [Display(Name = "邮箱")]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Display(Name = "QQ号")]
        [StringLength(20)]
        public string QQ { get; set; }

        public virtual ICollection<SysUserRole> SysUserRoles { get; set; }
    }
}
