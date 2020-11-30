using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.SeeAQViewModel
{
    public class AllQuestion
    {
        [Key]
        public long QuestionID { set; get; }
        public string LessonName { set; get; }
        public string QuestionName { set; get; }
        public string Questions_A { set; get; }
        public string Questions_B { set; get; }
        public string Questions_C { set; get; }
        public string Questions_D { set; get; }
        public int? Correct_Answer { set; get; }
        public DateTime? CreatedTime { set; get; }

    }
}
