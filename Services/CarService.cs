using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.DTO;
using Repositories;

namespace Services
{
    public class CarService
    {
        public static APIRespModel GetCarsList(string sort = "Make", int page = 1, int size = 10)
        {
            APIReqModel req = new APIReqModel();
            req.sort = sort;
            req.pageSize = size;
            req.pageNumber = page;
           return CarRepository.GatCarsList(req);
        }
    }
}
