namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClassDevisionDetail
    {
        private ICollection<ClassStudent> classStudents;
        private ICollection<Schedule> schedules;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClassDevisionDetail()
        {
            this.classStudents = new HashSet<ClassStudent>();
            this.schedules = new HashSet<Schedule>();
        }

        [Key]
        public int ClassDevisionDetailsID { get; set; }

        public int ClassID { get; set; }

        public byte DivID { get; set; }

        public int StudyYearID { get; set; }

        public int IDProfil { get; set; }

        public int? TeacherID { get; set; }

        public virtual Actor Actor { get; set; }

        public virtual Class Class { get; set; }

        public virtual Division Division { get; set; }

        public virtual Profil Profil { get; set; }

        public virtual StudyYear StudyYear { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassStudent> ClassStudents {
            get { return this.classStudents;  }
            set { this.classStudents = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules
        {
            get { return this.schedules; }
            set { this.schedules = value; }
        }
    }
}
