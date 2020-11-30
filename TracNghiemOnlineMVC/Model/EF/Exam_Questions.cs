namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Exam_Questions
    {
        [Key]
        [Column("Exam_Questions")]
        public int Exam_QuestionsID { get; set; }

        [StringLength(250)]
        public string Exam_QuestionsName { get; set; }

        public DateTime? Exam_Time { get; set; }

        public bool? Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? Number_of_Question { get; set; }
    }
}
