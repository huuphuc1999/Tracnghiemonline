using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using Model.EF;
using Model.SeeAQViewModel;
using PagedList;
namespace taometlamroi.Areas.Admin.Controllers
{
    
    public class SeeAllQuestionController : Controller
    {
        // GET: Admin/SeeAllQuestion
        public ActionResult Index(int page = 1, int pageSize = 15)
        {
            var db = new DataDbContext();
            var dao = new AllQuestionDao();
            var model = dao.ListAllPaging(page, pageSize);           
           
            //var Question = (from qs in db.Questions 
            //               join ls in db.Lessons on qs.QuestionsID equals ls.LessonID

            //               select  new AllQuestion
            //               {
            //                   QuestionID = qs.QuestionsID,
            //                   LessonName = ls.LessonName,
            //                   QuestionName = qs.QuestionsName,
            //                   Questions_A = qs.Questions_A,
            //                   Questions_B = qs.Questions_B,
            //                   Questions_C = qs.Questions_C,
            //                   Questions_D = qs.Questions_D,
            //                   Correct_Answer = qs.Correct_Answer,
            //                   CreatedTime = qs.CreatedDate,

            //               }).ToList();
            //ViewBag.QuestionID = Question;

            //var Question = from s in db.Questions.GroupBy(s => s.QuestionsID).Select(g => new
            //{
            //    g.FirstOrDefault().QuestionsName,
            //    g.FirstOrDefault().Questions_A,
            //    g.FirstOrDefault().Questions_B,
            //    g.FirstOrDefault().Questions_C,
            //    g.FirstOrDefault().Questions_D,
            //    g.FirstOrDefault().Correct_Answer,
            //    g.FirstOrDefault().CreatedDate,

            //});
            //var donvi = _db.DONVIs.GroupBy(s => s.MaDV)
            //    .Select(g => new {
            //        g.FirstOrDefault().TenDV,
            //        g.FirstOrDefault().NHANVIENs.Count
            //    });


            return View(model);
        }
        

    }
}