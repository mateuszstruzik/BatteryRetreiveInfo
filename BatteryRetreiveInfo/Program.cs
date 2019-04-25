using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Management;

namespace BatteryRetreiveInfo
{
    public class Program
    {
        static void Main(string[] args)
        {
            ObjectQuery query = new ObjectQuery("Select * from Win32_Battery");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection collection = searcher.Get();

            foreach(var single in collection)
            {
                foreach(var prop in single.Properties)
                {
                    Console.WriteLine("Name :{0}");
                }
            }

            Console.ReadKey();
        }
    }
}
