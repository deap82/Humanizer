namespace Humanizer.Localisation.Ordinalizers
{
    internal class SwedishOrdinalizer : DefaultOrdinalizer
    {
        public override string Convert(int number, string numberString)
        {
            if ((numberString.EndsWith("1") || numberString.EndsWith("2"))
                && number != 11 && number != 12)
                return numberString + ":a";

            return numberString + ":e";
        }
    }
}