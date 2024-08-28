using Ganss.Xss;
using System.Runtime.CompilerServices;

namespace LoginProjectCore.Utilities
{

    //ورودی‌های کاربر از هرگونه کد مخرب پاک شود
    public static class XssSecurity
    {
        public static string CheckText(this string text)
        {
            var htmlSanitizer = new HtmlSanitizer();
            htmlSanitizer.KeepChildNodes = true;
            htmlSanitizer.AllowDataAttributes = true;

            return htmlSanitizer.Sanitize(text);
        }
    }
}
