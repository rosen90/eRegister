namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Class
    {
        private ICollection<ClassDevisionDetail> classDevisionDetails;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Class()
        {
            this.classDevisionDetails = new HashSet<ClassDevisionDetail>();
        }

        public int ClassID { get; set; }

        [Column("Class")]
        public int Class1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassDevisionDetail> ClassDevisionDetails {
            get { return this.classDevisionDetails;  }
            set { this.classDevisionDetails = value; }
        }
    }
}
