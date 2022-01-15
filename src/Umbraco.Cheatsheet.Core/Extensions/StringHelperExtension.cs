using System.Web;

namespace Umbraco.Cheatsheet.Core.Extensions
{
    public static class StringHelperExtension
    {
        public static IHtmlString ToReplaceLineBreak(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return new HtmlString("");

            text = text
                .Replace("\r\n", "<br/>")
                .Replace("\r", "<br/>")
                .Replace("\n", "<br/>");

            return new HtmlString(text);
        }
    }
}
