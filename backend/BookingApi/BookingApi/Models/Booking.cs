using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApi.Models
{
    public class Booking
    {
        [Key]
        public int bookID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string times { get; set; }
    }

    /*
    public class BookTime
    {
        [Key]
        public int timeID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string mail { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string arende { get; set; }

        public int tele { get; set; }

        public int bookID { get; set; } // forein key
    }*/
}
