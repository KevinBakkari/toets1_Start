namespace I1SD_Toets1_Start
{
    public static class MyFunctions
    {
        /// <summary>
        /// Returns the string "Welkom bij deze ASP-NET / C# toets"
        /// </summary>
        /// <returns></returns>
        public static string Hallo()
        {
            return "Welkom bij deze ASP-NET / C# toets";
        }
        public static string GenereerGetallenreeks(int getal)
        {
            if (getal < 10 || getal > 1000)
            {
                return "Ongeldige invoer.";
            }

            string result = "Start met " + getal + ": ";
    }
}