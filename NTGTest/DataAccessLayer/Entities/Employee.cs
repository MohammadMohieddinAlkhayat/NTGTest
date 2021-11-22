using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NTGTest.DataAccessLayer.Entities
{
    public class Employee : BaseEntity
    {

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        [StringLength(9)]
        public string PhoneNumber { get; set; }

    }
     
}
