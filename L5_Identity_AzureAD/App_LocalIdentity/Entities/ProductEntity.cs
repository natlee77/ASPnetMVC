using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App_LocalIdentity.Entities
{
    public class ProductEntity
    {

        [Required]
        public int Id { get; set; }

        [Required]
        [Column(TypeName="nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public double Price { get; set; }



        //koppla till ProductCategoryEntity://1 product kan befinnas i flera categories//relation i DB
        public virtual ICollection<ProductCategoryEntity> Categories { get; set; }
    }
}//go to Data/ApplicationDbContext-->
