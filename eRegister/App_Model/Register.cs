namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Register
    {
        public int RegisterID { get; set; }

        public int StudentID { get; set; }

        public int StudyYearID { get; set; }

        public short SubjectID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ScoreNum { get; set; }

        public byte? ScoreTypeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int TeacherID { get; set; }

        public int TermID { get; set; }

        public virtual Actor Actor { get; set; }

        public virtual ScoreType ScoreType { get; set; }

        public virtual StudyYear StudyYear { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
