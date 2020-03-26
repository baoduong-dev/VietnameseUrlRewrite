namespace VietnameseUrlRewrite
{
    public class UrlWrite
    {
        public static string Url(string strSource)
        {
            return HandleString.RemoveSpecialChar(strSource);
        }
    }
}
