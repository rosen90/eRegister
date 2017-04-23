namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Absence
    {
        public int AbsenceID { get; set; }

        public Guid StudentID { get; set; }

        public short SubjectID { get; set; }

        public bool Excused { get; set; }

        public byte AbsenceTypeID { get; set; }

        public int? ScheduleID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public virtual AbsenceType AbsenceType { get; set; }

        public virtual Actor Actor { get; set; }

        public virtual Schedule Schedule { get; set; }
    }
}
