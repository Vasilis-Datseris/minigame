using System.Drawing;

namespace minigame
{
    internal static class ExtenssionMethods
    {
        public static Color FromHex(this string hex) => ColorTranslator.FromHtml(hex);
    }
}
