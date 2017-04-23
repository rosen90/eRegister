namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Actor
    {
        private ICollection<Absence> absences;
        private ICollection<Actor> actors1;
        private ICollection<ClassDevisionDetail> classDevisionDetails;
        private ICollection<ClassStudent> classStudents;
        private ICollection<Message> messages;
        private ICollection<Message> messages1;
        private ICollection<Register> registers;
        private ICollection<TeacherSubject> teacherSubjects;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Actor()
        {
            this.ActorID = Guid.NewGuid(); 
            this.absences = new HashSet<Absence>();
            this.actors1 = new HashSet<Actor>();
            this.classDevisionDetails = new HashSet<ClassDevisionDetail>();
            this.classStudents = new HashSet<ClassStudent>();
            this.messages = new HashSet<Message>();
            this.messages1 = new HashSet<Message>();
            this.registers = new HashSet<Register>();
            this.teacherSubjects = new HashSet<TeacherSubject>();
        }

        public Guid ActorID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public bool Gender { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [Required]
        [StringLength(10)]
        public string EGN { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public bool? Status { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; }

        public Guid? ParentlID { get; set; }

        public int? UserID { get; set; }

        public int? ClassDivisionID { get; set; }

        public int? SchoolID { get; set; }

        public int? CityVillageID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Absence> Absences {
            get { return this.absences;  }
            set { this.absences = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actor> Actors1 {
            get { return this.actors1;  }
            set { this.actors1 = value; }
        }

        public virtual Actor Actor1 { get; set; }

        public virtual CityVillage CityVillage { get; set; }

        public virtual School School { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassDevisionDetail> ClassDevisionDetails {
            get { return this.classDevisionDetails;  }
            set { this.classDevisionDetails = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassStudent> ClassStudents {
            get { return this.classStudents;  }
            set { this.classStudents = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages {
            get { return this.messages;  }
            set { this.messages = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages1 {
            get { return this.messages1;  }
            set { this.messages1 = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Register> Registers
        {
            get { return this.registers; }
            set { this.registers = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeacherSubject> TeacherSubjects
        {
            get { return this.teacherSubjects; }
            set { this.teacherSubjects = value; }
        }
    }
}
