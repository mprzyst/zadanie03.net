using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace zadanie03.Models
{
    public class Num
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [Range(0, 1000, ErrorMessage ="Please enter number between 0 and 1000.")]
        public int? Value { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Result { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime When { get; set; }
    }
}
