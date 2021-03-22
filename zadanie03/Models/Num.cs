using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace zadanie03.Models
{
    public class Num
    {
        [Required(ErrorMessage = "This field is required!")]
        [Range(0, 1000, ErrorMessage ="Please enter number between 0 and 1000.")]
        public int? Value { get; set; }

        public string Result { get; set; }
        public string When { get; set; }
    }
}
