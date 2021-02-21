
using adminPortal.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace adminPortal.Models
    {
        public class SchoolClass
        { 
            [Key]
            [Required]
            [Column(TypeName = "nvarchar(10)")]
            public string Id { get; set; }

            [Required]
            [Column(TypeName = "date")]
            public DateTime Year { get; set; }

           
            public AppUser Teacher { get; set; } //associera med appuser

           

            //specifiera elev till class i tabel
            public virtual ICollection<AppUser> Students { get; set; } //(user tabel -new del FK -ClassId) --> (Classes-tabel)
                                                                       //virtual - används i tabel , som inte exiteras

             public virtual ICollection<SchoolCourse> Courses { get; set; }  //++koopla classcourses

        }
}



