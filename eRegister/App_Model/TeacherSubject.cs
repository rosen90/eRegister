namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TeacherSubject")]
    public partial class TeacherSubject
    {
        public int TeacherSubjectID { get; set; }

        public Guid TeacherID { get; set; }

        public short SubjectID { get; set; }

        public virtual Actor Actor { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
