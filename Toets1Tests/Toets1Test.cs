using I1SD_Toets1_Start;

namespace Toets1Tests
{
    public class Toets1Test
    {
        [Fact]
        public void TestHallo()
        {
            var result = MyFunctions.Hallo();
            Assert.Equal("Welkom bij deze ASP-NET / C# toets", result);
        }
    }
}