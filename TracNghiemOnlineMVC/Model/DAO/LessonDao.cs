using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class LessonDao
    {
        DataDbContext db = null;
        public LessonDao()
        {
            db = new DataDbContext();
        }
        public List<Lesson> ListAll()
        {
            return db.Lessons.ToList();
        }
    }
}

