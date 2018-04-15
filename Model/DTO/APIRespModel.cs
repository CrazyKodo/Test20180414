using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{   
    //"Sort": "Make",
    //"PageNumber": 1,
    //"PageSize": 2,
    //"TotalCount": 26,
    //"TotalPageCount": 13,
    //"Results"
    public class APIRespModel
    {
        public string sort { get; set; } = "";

        public int pageNumber { get; set; } = 1;

        public int pageSize { get; set; } = 1;

        public int totalCount { get; set; } = 1;

        public int totalPageCount { get; set; } = 1;

        public Car[] results { get; set; }
    }
}
