using Tyuiu.AkhtarievaNR.Sprint0.Task2.V0.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вызов класса DataService и метода GetMessage
            // из библиотеки
            Console.WriteLine(DataService.GetMessage("Наиля"));
            Console.ReadKey();
        }
    }
}
