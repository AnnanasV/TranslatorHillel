namespace ua_en
{
    internal static class TranslatorUkrainian
    {
        internal static string TranslateUkrainian(string ukrainianWord)
        {
            ukrainianWord = ukrainianWord.ToLower();
            switch (ukrainianWord)
            {
                case "привіт":
                    return "hello";
                case "бувай":
                    return "bye";
            }
            return "i dunno how to translate it :(";
        }
    }
}
