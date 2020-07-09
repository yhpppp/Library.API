using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Helper
{
    public class AuthorResourceParameters
    {
        private int _pageSize = 10;
        public const int MaxPageSize = 20;
        public int PageNumber { get; set; } = 1;
        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
            }
        }
        public string BirthPlace { get; set; }
        public string SearchQuery { get; set; }
        public string SortBy { get; set; } = "Name";
    }
}
