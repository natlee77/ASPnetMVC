using RolesAndPolicy.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RolesAndPolicy.Models
{
    public class SchoolClass
    {
        [Key]
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public DateTime Year { get; set; }


        public AppUser Manager { get; set; } //associera med appuser

        // teacher?

        //specifiera elev till class i tabel
        public virtual ICollection<AppUser> Students { get; set; } //(user tabel -new del FK -ClassId) --> (Classes-tabel)
        public virtual ICollection<SchoolCourse> Courses { get; set; }  //++koopla classcourses

    }
}
