using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Operations.UserOperations
{
    public class UserOperator
    {
        public string ValidateIpAddress()
        {
            HttpContext context = HttpContext.Current;
            string Ip = context.Request.ServerVariables["REMOTE_ADDR"];

            if (Ip.Contains("255"))
            {
                return "255.255.255.255";
            }
            else
            {
                return Ip;
            }
        }
    }
}
