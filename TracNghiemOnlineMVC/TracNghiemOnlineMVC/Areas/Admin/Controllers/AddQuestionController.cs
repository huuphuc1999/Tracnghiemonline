using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using Model.EF;
namespace taometlamroi.Areas.Admin.Controllers
{
    public class AddQuestionController : Controller
    {
        // GET: Admin/AddQuestion
        [HttpGet]
        public ActionResult Index()
        {
            SetViewBag();
            SetViewBag_Curriculum();
            SetViewBag_Lesson();
            return View();
        }
        [HttpPost]
        public ActionResult AddQuestion(Question question)
        {
            
            if (ModelState.IsValid)
            {
                
                var dao = new UserDao();

                long id = dao.InsertQuestion(question);


            }
            SetViewBag();
            SetViewBag_Curriculum();
            SetViewBag_Lesson();
            return View("Index");
        }
        public void SetViewBag(long? selectedID = null )
        {
            var dao = new SubjectDao();
            
            ViewBag.SubjectsID = new SelectList(dao.ListAll(), "SubjectsID", "SubjectsName", selectedID);
        }
        public void SetViewBag_Curriculum(long? selectedID = null)
        {
            var dao = new CurriculumDao();
            ViewBag.CurriculumID = new SelectList(dao.ListAll(), "CurriculumID", "CurriculumName", selectedID);
        }
        public void SetViewBag_Lesson(long? selectedID = null)
        {
            var dao = new LessonDao();
            ViewBag.LessonID = new SelectList(dao.ListAll(), "LessonID", "LessonName", selectedID);
        }
        public void SetViewBagData()
        {
            SetViewBag();
            SetViewBag_Curriculum();
            SetViewBag_Lesson();
        }

    }
}