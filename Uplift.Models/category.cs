using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uplift.Models
{
    internal class category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="category Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }

    }
}
