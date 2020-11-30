using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class UserDao
    {
        DataDbContext db = null;
        public UserDao()
        {
            db = new DataDbContext();
        }
        public long Insert(Account entity)
        {
            db.Accounts.Add(entity);
            db.SaveChanges();
            return entity.UserID;
        }
        public Account GetById(string userName)
        {
            return db.Accounts.SingleOrDefault(x => x.UserName == userName);
        }
        public int Login(string username, string password)
        {
            var result = db.Accounts.SingleOrDefault(x => x.UserName == username);
            if (result == null)
                return 0;
            else if (result.Password == password)
                return 1;
            else
                return -2;

        }
        public long InsertQuestion(Question question)
        {
            db.Questions.Add(question);
            db.SaveChanges();
            return question.QuestionsID;
        }
        public long InsertEQ(Exam_Questions exam_Questions)
        {
            
            db.Exam_Questions.Add(exam_Questions);
            db.SaveChanges();
            return exam_Questions.Exam_QuestionsID;
            
        }
        //public long Insert_Questions(Question question)
        //{
        //    db.Questions.Add(question);
        //    db.SaveChanges();
        //    return question.QuestionsID;
        //}
    }
}
