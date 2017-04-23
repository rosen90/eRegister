namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudyYear")]
    public partial class StudyYear
    {
        private ICollection<ClassDevisionDetail> classDevisionDetails;
        private ICollection<Register> registers;
        private ICollection<Schedule> schedules;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudyYear()
        {
            this.classDevisionDetails = new HashSet<ClassDevisionDetail>();
            this.registers = new HashSet<Register>();
            this.schedules = new HashSet<Schedule>();
        }

        public int StudyYearID { get; set; }

        [Column("StudyYear")]
        [Required]
        [StringLength(10)]
        public string StudyYear1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassDevisionDetail> ClassDevisionDetails {
            get { return this.classDevisionDetails;  }
            set { this.classDevisionDetails = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Register> Registers {
            get { return this.registers;  }
            set { this.registers = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules {
            get { return this.schedules;  }
            set { this.schedules = value; }
        }
    }
}
