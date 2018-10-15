using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ator.Model
{
    public class LoginDto
    {
        #region Attribute

        /// <summary>
        /// 帐户名
        /// </summary>
        [Required(ErrorMessage = "登录名不能为空")]
        [Display(Name = "登录名")]
        public string Account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = "密码不能为空")]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        /// <summary>
        /// 是否记住帐户名
        /// </summary>
        [Display(Name = "验证码")]
        public bool PIN { get; set; }

        #endregion
    }
}
