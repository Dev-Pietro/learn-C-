using System;

namespace ValidateIPv4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ipv4 = "1.1.1.1";
            if(IsValidIPv4(ipv4)) 
                Console.WriteLine($"{ipv4} is a valid IPv4 address");
            else 
                Console.WriteLine($"{ipv4} is an invalid IPv4 address");
            
        }

        static bool IsValidIPv4(string ipv4)
        {
            string[] arrayIpv4 = ipv4.Split('.');

            if (arrayIpv4.Length == 4) {
                foreach (string n in arrayIpv4)
                {
                    if(n.StartsWith("0")) return false;
                    if(Convert.ToInt32(n) < 0 || Convert.ToInt32(n) > 255) return false;
                }

                return true;
            }

            return false;
        }
    }
}
