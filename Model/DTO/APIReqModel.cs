using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class APIReqModel
    {
        public string sort { get; set; } = "";

        public int pageNumber { get; set; } = 1;

        public int pageSize { get; set; } = 1;
    }
}
