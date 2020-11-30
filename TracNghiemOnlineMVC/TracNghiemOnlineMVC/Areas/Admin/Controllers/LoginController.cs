using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using taometlamroi.Areas.Admin.Model;
using taometlamroi.Areas.Common;

namespace taometlamroi.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
      
        // GET: Admin/Login

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.UserName, Encryptor.MD5Hash(model.Password));
                if (result == 1)
                {
                    var user = dao.GetById(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.UserID = user.UserID;
                    Session.Add(CommonConstants.USER_SESSION, userSession);

                    return RedirectToAction("Index", "Home");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài Khoản chưa đăng ký");
                }
                else
                {
                    ModelState.AddModelError("", "Lỗi Đăng Nhập");
                }
            }
            return View("Index");
        }
    }
}