using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Praktika
{
    public class Phone : Device
    {
        public override void DeviceInfo()
        {
            Console.WriteLine("telefon");
        }


        public override void DeviceName()
        {
            Console.WriteLine("xiaomi");
        }
 
        public override void DeviceType()
        {
            Console.WriteLine("el telefonu");
        }
    }
    
    
}
