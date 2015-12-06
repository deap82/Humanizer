using Xunit;

namespace Humanizer.Tests.Localisation.sv
{
    [UseCulture("sv-SE")]
    public class OrdinalizeTests
    {

        [Theory]
        [InlineData("0", "0:e")]
        [InlineData("1", "1:a")]
        [InlineData("2", "2:a")]
        [InlineData("3", "3:e")]
        [InlineData("4", "4:e")]
        [InlineData("5", "5:e")]
        [InlineData("6", "6:e")]
        [InlineData("7", "7:e")]
        [InlineData("8", "8:e")]
        [InlineData("9", "9:e")]
        [InlineData("10", "10:e")]
        [InlineData("11", "11:e")]
        [InlineData("12", "12:e")]
        [InlineData("13", "13:e")]
        [InlineData("14", "14:e")]
        [InlineData("20", "20:e")]
        [InlineData("21", "21:a")]
        [InlineData("22", "22:a")]
        [InlineData("23", "23:e")]
        [InlineData("24", "24:e")]
        [InlineData("100", "100:e")]
        [InlineData("101", "101:a")]
        [InlineData("102", "102:a")]
        [InlineData("103", "103:e")]
        [InlineData("104", "104:e")]
        [InlineData("110", "110:e")]
        [InlineData("1000", "1000:e")]
        [InlineData("1001", "1001:a")]
        public void OrdinalizeString(string number, string ordinalized)
        {
            Assert.Equal(number.Ordinalize(), ordinalized);
        }
    
        [Theory]
        [InlineData(0, "0:e")]
        [InlineData(1, "1:a")]
        [InlineData(2, "2:a")]
        [InlineData(3, "3:e")]
        [InlineData(4, "4:e")]
        [InlineData(5, "5:e")]
        [InlineData(6, "6:e")]
        [InlineData(7, "7:e")]
        [InlineData(8, "8:e")]
        [InlineData(9, "9:e")]
        [InlineData(10, "10:e")]
        [InlineData(11, "11:e")]
        [InlineData(12, "12:e")]
        [InlineData(13, "13:e")]
        [InlineData(14, "14:e")]
        [InlineData(20, "20:e")]
        [InlineData(21, "21:a")]
        [InlineData(22, "22:a")]
        [InlineData(23, "23:e")]
        [InlineData(24, "24:e")]
        [InlineData(100, "100:e")]
        [InlineData(101, "101:a")]
        [InlineData(102, "102:a")]
        [InlineData(103, "103:e")]
        [InlineData(104, "104:e")]
        [InlineData(110, "110:e")]
        [InlineData(1000, "1000:e")]
        [InlineData(1001, "1001:a")]
        public void OrdinalizeNumber(int number, string ordinalized)
        {
            Assert.Equal(number.Ordinalize(), ordinalized);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(8)]
        public void OrdinalizeNumberGenderIsImmaterial(int number)
        {
            var masculineOrdinalized = number.Ordinalize(GrammaticalGender.Masculine);
            var feminineOrdinalized = number.Ordinalize(GrammaticalGender.Feminine);
            Assert.Equal(masculineOrdinalized, feminineOrdinalized);
        }

        [Theory]
        [InlineData("0")]
        [InlineData("1")]
        [InlineData("8")]
        public void OrdinalizeStringGenderIsImmaterial(string number)
        {
            var masculineOrdinalized = number.Ordinalize(GrammaticalGender.Masculine);
            var feminineOrdinalized = number.Ordinalize(GrammaticalGender.Feminine);
            Assert.Equal(masculineOrdinalized, feminineOrdinalized);
        }
    }
}
