using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App_LocalIdentity.Entities
{
    public class ProductCategoryEntity
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }




        //ska koppla med ProductEntity-->relation i DB
        public virtual ICollection<ProductEntity> Products { get; set; }


    }
}
