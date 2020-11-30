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
    public class RegisterController : Controller
    {
        // GET: Admin/Register
        [HttpGet]
        
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        
        public ActionResult Register(Account acc)
        {            
            if  (ModelState.IsValid)
            {
                var dao = new UserDao();
                var encryptedMd5Pas = Encryptor.MD5Hash(acc.Password);
                acc.Password = encryptedMd5Pas;
                long id = dao.Insert(acc);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng ký thất bại");
                }
            }
            return View("Index");
        }
    }
}
