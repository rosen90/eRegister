namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MessageStatu
    {
        [Key]
        public int MessageStatusID { get; set; }

        public long MessageID { get; set; }

        public int StatusID { get; set; }

        public DateTime DateTime { get; set; }

        public virtual Message Message { get; set; }

        public virtual Status Status { get; set; }
    }
}
