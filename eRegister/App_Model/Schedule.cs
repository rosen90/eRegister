namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Schedule
    {
        private ICollection<Absence> absences;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schedule()
        {
            this.absences = new HashSet<Absence>();
        }

        public int ScheduleID { get; set; }

        public int TermID { get; set; }

        public byte PeriodNum { get; set; }

        public short SubjectID { get; set; }

        public byte WeekDayID { get; set; }

        public int ClassDevisionDetailsID { get; set; }

        public int TeacherID { get; set; }

        public int StudyYearID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Absence> Absences {
            get { return this.absences;  }
            set { this.absences = value; }
        }

        public virtual ClassDevisionDetail ClassDevisionDetail { get; set; }

        public virtual StudyYear StudyYear { get; set; }

        public virtual Subject Subject { get; set; }

        public virtual WeekDay WeekDay { get; set; }
    }
}
