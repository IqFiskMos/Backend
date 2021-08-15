using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace View_Models.Models
{
    public class PeopleModel
    {
        [Required(ErrorMessage = "Id is Required. It cannot be empty")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required. It cannot be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Phone is Required. It cannot be empty")]
        public int Phone { get; set; }
        [Required(ErrorMessage = "City is Required. It cannot be empty")]
        public string City { get; set;  }
    }

}
