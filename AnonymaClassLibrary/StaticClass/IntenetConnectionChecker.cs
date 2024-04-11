using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AnonymaClassLibrary.StaticClass
{
    public static class IntenetConnectionChecker
    {
        public static bool IsConnectedToInternet()
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send("8.8.8.8", 1000); 
                    return reply.Status == IPStatus.Success;
                }
            }
            catch (Exception)
            {
                return false; 
            }
        }
    }
}
