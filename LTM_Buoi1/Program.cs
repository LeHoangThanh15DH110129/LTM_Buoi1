using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace LTM_Buoi1
{
    class Program
    {
     
        [STAThread]
        static void Main(string[] args)
        {
            //BaiTap1
            //  Hostname
            String strHostName = Dns.GetHostName();
            Console.WriteLine("Host Name: " + strHostName);

            // tim dia chi ip
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            // Xuat ip
            int nIP = 0;
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                Console.WriteLine("IP #" + ++nIP + ": " + ipaddress.ToString());
            }
            //BaiTap2
            // Nhap ten mien hoac ip
            Console.Write("Hostname hoac IP: ");
            string host = Console.ReadLine();

            IPHostEntry e = Dns.GetHostEntry(host);
            Console.WriteLine("Hostname: {0}", e.HostName);

            // xuat ten mien
            foreach (string s in e.Aliases)
                Console.WriteLine("Alias: {0} \n", s);

            // Xuat ip
            foreach (IPAddress i in e.AddressList)
                Console.WriteLine("IP: {0}", i);
        }
    }
}

