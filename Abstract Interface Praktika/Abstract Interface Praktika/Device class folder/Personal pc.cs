using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Praktika
{
    public class PersonalPC : Device
    {
        public override void DeviceInfo()
        {
            Console.WriteLine("asus pcsidi");
        }

        public override void DeviceName()
        {
            Console.WriteLine("asus pc");
        }

        public override void DeviceType()
        {
            Console.WriteLine("personal computerdi");
        }
    }
}
