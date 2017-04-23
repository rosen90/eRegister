namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AbsenceType")]
    public partial class AbsenceType
    {
        private ICollection<Absence> absences;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AbsenceType()
        {
            this.absences = new HashSet<Absence>();
        }

        public byte AbsenceTypeID { get; set; }

        [Required]
        [StringLength(20)]
        public string Absence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Absence> Absences {
            get { return this.absences;  }
            set { this.absences = value; }
        }
    }
}
