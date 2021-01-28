using System.Collections.Generic;

namespace Chris.CSharp.NewFeature.Foreach
{
    public static class ForEachExtensions
    {
        public static IEnumerator<char> GetEnumerator(this int num)
        {
            return num.ToString().GetEnumerator();
        }
    }
}