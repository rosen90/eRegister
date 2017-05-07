namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClassStudent
    {
        [Key]
        public int NumInClassDetID { get; set; }

        public int StudentID { get; set; }

        public int Number { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateofChange { get; set; }

        public int? ClassDevisionDetailsID { get; set; }

        public virtual Actor Actor { get; set; }

        public virtual ClassDevisionDetail ClassDevisionDetail { get; set; }
    }
}
