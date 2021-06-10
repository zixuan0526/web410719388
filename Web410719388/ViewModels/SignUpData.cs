﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web410719388.ViewModels
{
    public class SignUpData
    {
        [Display(Name = "姓名")]
        [Required(ErrorMessage = "請輸入姓名")]
        [MinLength(5, ErrorMessage = "請輸入5-10個字")]
        [MaxLength(10, ErrorMessage = "請輸入5-10個字")]
        public string Name { get; set; }


        [Display(Name = "帳號")]
        [Required(ErrorMessage = "請輸入帳號")]
        [EmailAddress(ErrorMessage = "請輸入正確的email格式")]
        public string Account { get; set; }


        [Display(Name = "密碼")]
        [Required(ErrorMessage = "請輸入密碼")]
        [StringLength(10, MinimumLength =5, ErrorMessage = "請輸入5-10個字")]
        public string Password { get; set; }

        public string Message { get; set; }

        
    }
}