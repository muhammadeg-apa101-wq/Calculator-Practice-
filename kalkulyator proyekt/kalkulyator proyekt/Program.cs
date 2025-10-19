namespace kalkulyator_proyekt
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICalculation calculation = new Calculation();
            Console.WriteLine("1-ci ededi daxil edin:");
            double eded1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hesablama  (+, -, *, /):");
            string emeliyyat = Console.ReadLine();
            Console.WriteLine("2-ci ededi daxil edin:");
            double eded2 = Convert.ToDouble(Console.ReadLine());
            switch (emeliyyat)
            {
                case "+":
                    Console.WriteLine("Netice: " + calculation.Toplama(eded1, eded2));
                    break;
                case "-":
                    Console.WriteLine("Netice: " + calculation.Cixma(eded1, eded2));
                    break;
                case "*":
                    Console.WriteLine("Netice: " + calculation.Vurma(eded1, eded2));
                    break;
                case "/":
                    Console.WriteLine("Netice: " + calculation.Bolme(eded1, eded2));
                   break;
                default:
                    Console.WriteLine("Sehv emeliyyat daxil etdiniz.");
                    break;
            }
        }
    }
}
