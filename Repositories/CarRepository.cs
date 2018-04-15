using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using Model;

namespace Repositories
{
    public class CarRepository
    {
        public static APIRespModel GatCarsList(APIReqModel req)
        {
            APIRespModel resp = new APIRespModel();
            var parm = JsonHelper.Serialize(req);
            var re = HttpHelper.request(Config.APIServer, parm, 30000);
            resp = JsonHelper.Deserialize<APIRespModel>(re);

            return resp;
        }
    }
}
