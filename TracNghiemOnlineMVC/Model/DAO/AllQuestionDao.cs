using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
namespace Model.DAO
{    
    public class AllQuestionDao
    {
        DataDbContext db = null;
        public AllQuestionDao()
        {
            db = new DataDbContext();
        }
        public IEnumerable<Question> ListAllPaging(int page , int pageSize )
        {
            return db.Questions.OrderByDescending(x=>x.QuestionsID).ToPagedList(page,pageSize);
        }
        //public IEnumerable<Lesson> ListAll(int page, int pageSize)
        //{
        //    return db.Lessons.OrderByDescending(x => x.LessonID).ToPagedList(page, pageSize);
        //}
    }
}
