using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace taometlamroi.Areas.Admin.Model
{
    public class AddEQ
    {
        [Key]
        public long Exam_Questions { set; get; }
        public string Exam_QuestionsName { set; get; }
        public long Number_of_Question { set; get; }
    }
}