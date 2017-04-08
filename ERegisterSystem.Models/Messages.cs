namespace ERegisterSystem.Models
{
    using System;
    class Messages
    {
        public Guid MessageID { get; set; }

        public DateTime CreationDate { get; set; }

        public string AttachmentPath { get; set; }
    }
}
