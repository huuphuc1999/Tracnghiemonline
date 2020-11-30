using System;
using System.ComponentModel.DataAnnotations;

namespace taometlamroi.Areas.Admin.Model
{
    public class AddQuestion
    {
        [Key]
        public long QuestionsID { set; get; }
        public string QuestionsName { set; get; }
        public string Questions_A { set; get; }
        public string Questions_B { set; get; }
        public string Questions_C { set; get; }
        public string Questions_D { set; get; }
        public string Explain { set; get; }
        public int Correct_Answer { set; get; }

        public DateTime? Questions_TimeAdded { set; get; } = DateTime.Now;


        public long SubjectsID { get; set; }
        public long LessonID { set; get; }
        public long CurriculumID { set; get; }


        //public string Type { set; get; }
        //public IEnumerable<SelectListItem> TypeList
        //{
        //    get
        //    {
        //        return new List<SelectListItem>
        //{
        //    new SelectListItem { Text = "1", Value = "1"},
        //    new SelectListItem { Text = "2", Value = "2"},
        //    new SelectListItem { Text = "3", Value = "3"},
        //    new SelectListItem { Text = "4", Value = "4"}
        //};
        //    }
        //}



    }



}

