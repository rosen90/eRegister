namespace eRegister.App_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Picture
    {
        [Key]
        public int IDPictures { get; set; }

        public int IDGallery { get; set; }

        [Required]
        public string PicturePath { get; set; }

        public virtual Gallery Gallery { get; set; }
    }
}
