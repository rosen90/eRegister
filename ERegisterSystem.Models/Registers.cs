
namespace ERegisterSystem.Models
{
    using System;
    class Registers
    {
        public int RegisterID { get; set; }

        public int StudentID { get; set; }
        
        public decimal? ScoreNum { get; set; }

        public DateTime? Date { get; set; }

        public int TermID { get; set; }
    }
}
