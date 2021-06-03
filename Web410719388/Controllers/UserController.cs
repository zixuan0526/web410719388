using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web410719388.ViewModels;

namespace Web410719388.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View(new SignUpData());
        }

        [HttpPost]
        public ActionResult SignUp(SignUpData data)
        {
            if (data.Name.IsNullOrWhiteSpace())
            {
                ViewBag.NameMessage = "請輸入姓名";
            }
            if (data.Account.IsNullOrWhiteSpace())
            {
                ViewBag.AccountMessage = "請輸入帳號";
            }
            if (data.Password.IsNullOrWhiteSpace())
            {
                ViewBag.PasswordMessage = "請輸入密碼";
            }

            if (!data.Name.IsNullOrWhiteSpace() &&
               !data.Account.IsNullOrWhiteSpace() &&
               !data.Password.IsNullOrWhiteSpace()) {
                ViewBag.Message = "註冊成功";
            }

            return View(data);
        }
    }
}