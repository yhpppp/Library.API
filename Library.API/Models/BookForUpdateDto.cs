using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Models
{
    public class BookForUpdateDto
    {
        [Required(ErrorMessage ="缺少书籍名称")]
        public string Title { get; set; }
        //[Required(ErrorMessage = "缺少书籍描述")]
        public string Description { get; set; }
        //[Required(ErrorMessage = "缺少页数")]
        public int Pages { get; set; }
    }
}
