namespace Chris.CSharp.NewFeature.PatternMatch
{
    public static class ExtensionMethod
    {
        public static bool IsLetter(this char c) =>
            c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

        public static bool IsLetterOrSeparator(this char c) =>
            c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';

        public static bool IsEmpty(this string c)
        {
            return c is not null;
        }
    }
}