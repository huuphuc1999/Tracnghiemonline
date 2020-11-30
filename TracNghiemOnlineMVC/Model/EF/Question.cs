namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Question
    {
        [Key]
        public int QuestionsID { get; set; }

        [StringLength(1000)]
        public string QuestionsName { get; set; }

        [StringLength(250)]
        public string Questions_A { get; set; }

        [StringLength(250)]
        public string Questions_B { get; set; }

        [StringLength(250)]
        public string Questions_C { get; set; }

        [StringLength(250)]
        public string Questions_D { get; set; }

        [StringLength(500)]
        public string Explain { get; set; }

        public int? Correct_Answer { get; set; }

        public int SubjectsID { get; set; }

        public int CurriculumID { get; set; }

        public int LessonID { get; set; }

        public bool? Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public virtual Curriculum Curriculum { get; set; }

        public virtual Lesson Lesson { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
