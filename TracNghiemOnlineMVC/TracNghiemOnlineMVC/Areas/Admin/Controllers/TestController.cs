using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using Model.EF;

namespace taometlamroi.Areas.Admin.Controllers
{
    public class TestController : Controller
    {
        // GET: Admin/Test
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEQ (Exam_Questions exam_Questions)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                long id = dao.InsertEQ(exam_Questions);
            }
            else
            {
               
            }
            return View("Index");
        }
    }
}