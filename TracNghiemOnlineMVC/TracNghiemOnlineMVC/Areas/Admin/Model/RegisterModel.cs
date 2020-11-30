using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace taometlamroi.Areas.Admin.Model
{
    public class RegisterModel
    {

        [Required(ErrorMessage = "Hãy Nhập Tài Khoản")]
        public string UserName { set; get; }
        [Required(ErrorMessage = "Hãy Nhật Mật Khẩu")]
        public string Password { set; get; }        
        public string ConfirmPassword { set; get; }
        
    }
}