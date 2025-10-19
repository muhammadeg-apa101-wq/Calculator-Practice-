
namespace Abstract_Interface_Praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalPC pc = new();
            pc.DeviceInfo();
            pc.DeviceName();
            pc.DeviceType();
            Phone phone = new();
            phone.DeviceInfo();
            phone.DeviceName();
            phone.DeviceType();   
        }
    }
}
