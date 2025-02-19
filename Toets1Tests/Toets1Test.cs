using I1SD_Toets1_Start;
using Xunit;

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

        [Fact]
        public void TestGenereerGetallenreeks_Met13()
        {
            int getal = 13;
            string expected = "13 -> 40 -> 20 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1";
            var result = MyFunctions.GenereerGetallenreeks(getal);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestGenereerGetallenreeks_Met5()
        {
            int getal = 5;
            string expected = "Ongeldige invoer.";
            var result = MyFunctions.GenereerGetallenreeks(getal);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertStringToBinary_voorA()
        {
            string input = "A";
            string expected = "01000001 ";
            var result = MyFunctions.ConvertStringToBinary(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertStringToBinary_voorKevin()
        {
            string input = "Kevin";
            string expected = "01001011 01100101 01110110 01101001 01101110 ";
            var result = MyFunctions.ConvertStringToBinary(input);
            Assert.Equal(expected, result);
        }
    }
}
