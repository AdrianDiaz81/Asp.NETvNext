using static System.Console;

namespace ADC.News
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new ContactNew();
           WriteLine( persona.FullName());
           ReadLine();
        }
    }
}
