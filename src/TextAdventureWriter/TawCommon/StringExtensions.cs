namespace SloanKellyGames.TawCommon
{
    public static class StringExtensions
    {
        public static string Capitalize(this string stringIn)
        {
            string s = "";
            for (int i = 0; i < stringIn.Length; i++)
            {
                if (i == 0 || (stringIn[i - 1] == ' '))
                    s += char.ToUpper(stringIn[i]);
                else
                    s += char.ToLower(stringIn[i]);
            }

            return s;
        }
    }
}
