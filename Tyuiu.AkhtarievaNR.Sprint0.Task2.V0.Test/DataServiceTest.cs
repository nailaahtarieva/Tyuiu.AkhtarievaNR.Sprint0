using Tyuiu.AkhtarievaNR.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Наиля";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEqua
            Assert.AreEqual("Привет, Наиля", res);
        }
    }      
}           