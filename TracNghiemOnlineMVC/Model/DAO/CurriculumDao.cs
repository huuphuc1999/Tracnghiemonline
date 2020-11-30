using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class CurriculumDao
    {
        DataDbContext db = null;
        public CurriculumDao()
        {
            db = new DataDbContext();
        }
        public List<Curriculum> ListAll()
        {
            return db.Curricula.ToList();
        }
    }
}
