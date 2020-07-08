using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Models
{
    public class BookForCreationDto
    {
        [Required]
        [MaxLength(100, ErrorMessage = "长度不能大于500")]
        public string Title { get; set; }

        public string Description { get; set; }

        public int Pages { get; set; }
    }
}
