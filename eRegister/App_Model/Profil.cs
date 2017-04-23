namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Profil")]
    public partial class Profil
    {
        private ICollection<ClassDevisionDetail> classDevisionDetails;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profil()
        {
            this.classDevisionDetails = new HashSet<ClassDevisionDetail>();
        }

        [Key]
        public int IDProfil { get; set; }

        [Column("Profil")]
        [Required]
        [StringLength(100)]
        public string Profil1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassDevisionDetail> ClassDevisionDetails {
            get { return this.classDevisionDetails;  }
            set { this.classDevisionDetails = value; }
        }
    }
}
