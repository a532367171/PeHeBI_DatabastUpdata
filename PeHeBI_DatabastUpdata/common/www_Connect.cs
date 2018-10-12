using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace PeHeBI_DatabastUpdata.common
{
    class www_Connect
    {
        public bool Ping(string ip)
        {
            System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
            System.Net.NetworkInformation.PingOptions options = new System.Net.NetworkInformation.PingOptions();
            options.DontFragment = true;
            string data = "T";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 1000; // Timeout 时间，单位：毫秒
            System.Net.NetworkInformation.PingReply reply = p.Send(ip, timeout, buffer, options);
            if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                return true;
            else
                return false;
        }

        [DllImport("winInet.dll")]
        private static extern bool InternetGetConnectedState(ref int dwFlag, int dwReserved);

        private const int INTERNET_CONNECTION_MODEM = 1;
        private const int INTERNET_CONNECTION_LAN = 2;

        /// <summary>
        /// 判断本机是否联网
        /// </summary>
        /// <returns></returns>
        public static bool IsConnectNetwork()
        {
            try
            {
                int dwFlag = 0;

                //false表示没有连接到任何网络,true表示已连接到网络上
                if (!InternetGetConnectedState(ref dwFlag, 0))
                {

                    //if (!InternetGetConnectedState(ref dwFlag, 0))
                    //     Console.WriteLine("未连网!");
                    //else if ((dwFlag & INTERNET_CONNECTION_MODEM) != 0)
                    //    Console.WriteLine("采用调治解调器上网。");
                    //else if ((dwFlag & INTERNET_CONNECTION_LAN) != 0)
                    //    Console.WriteLine("采用网卡上网。");  
                    return false;
                }

                //判断当前网络是否可用
                IPAddress[] addresslist = Dns.GetHostAddresses("www.baidu.com");
                if (addresslist[0].ToString().Length <= 6)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }

}
