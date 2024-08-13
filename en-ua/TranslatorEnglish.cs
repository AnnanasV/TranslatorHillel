namespace en_ua
{
    internal static class TranslatorEnglish
    {
        internal static string TranslateEnglish(string englishWord)
        {
            englishWord = englishWord.ToLower();
            switch (englishWord)
            {
                case "hello":
                    return "привіт";
                case "bye":
                    return "бувай";
            }
            return "я не знаю перекладу :(";
        }
    }
}
