namespace VietnameseUrlRewrite
{
    public class UrlWrite
    {
        private static string StringStandard(string strSource)
        {
            strSource = strSource.Trim();
            int len = strSource.Length;
            int i = 0;
            while (i < len)
            {
                if (strSource[i] == ' ' && strSource[i] == strSource[i + 1])
                {
                    strSource = strSource.Remove(i, 1);
                    len = strSource.Length;
                }
                else
                {
                    i++;
                }
            }
            return strSource;
        }

        private static string RemoveSign(string str)
        {
            string[,] arr = new string[14, 18];
            const string chain = "aAeEoOuUiIdDyY";
            const string lowerA = "áàạảãâấầậẩẫăắằặẳẵ";
            const string upperA = "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ";
            const string lowerE = "éèẹẻẽêếềệểễeeeeee";
            const string upperE = "ÉÈẸẺẼÊẾỀỆỂỄEEEEEE";
            const string lowerO = "óòọỏõôốồộổỗơớờợởỡ";
            const string upperO = "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ";
            const string lowerU = "úùụủũưứừựửữuuuuuu";
            const string upperU = "ÚÙỤỦŨƯỨỪỰỬỮUUUUUU";
            const string lowerI = "íìịỉĩiiiiiiiiiiii";
            const string upperI = "ÍÌỊỈĨIIIIIIIIIIII";
            const string lowerD = "đdddddddddddddddd";
            const string upperD = "ĐDDDDDDDDDDDDDDDD";
            const string lowerY = "ýỳỵỷỹyyyyyyyyyyyy";
            const string upperY = "ÝỲỴỶỸYYYYYYYYYYYY";

            for (byte i = 0; i < 14; i++)
                arr[i, 0] = chain.Substring(i, 1);

            for (byte j = 1; j < 18; j++)
                for (byte i = 1; i < 18; i++)
                {
                    arr[0, i] = lowerA.Substring(i - 1, 1);
                    arr[1, i] = upperA.Substring(i - 1, 1);
                    arr[2, i] = lowerE.Substring(i - 1, 1);
                    arr[3, i] = upperE.Substring(i - 1, 1);
                    arr[4, i] = lowerO.Substring(i - 1, 1);
                    arr[5, i] = upperO.Substring(i - 1, 1);
                    arr[6, i] = lowerU.Substring(i - 1, 1);
                    arr[7, i] = upperU.Substring(i - 1, 1);
                    arr[8, i] = lowerI.Substring(i - 1, 1);
                    arr[9, i] = upperI.Substring(i - 1, 1);
                    arr[10, i] = lowerD.Substring(i - 1, 1);
                    arr[11, i] = upperD.Substring(i - 1, 1);
                    arr[12, i] = lowerY.Substring(i - 1, 1);
                    arr[13, i] = upperY.Substring(i - 1, 1);
                }

            for (byte j = 0; j < 14; j++)
                for (byte i = 1; i < 18; i++)
                    str = str.Replace(arr[j, i], arr[j, 0]);

            return str;
        }

        private static string RemoveSpecialChar(string str)
        {
            str = RemoveSign(str);
            string SpecialChar = "~!?#$&@%^*()[]{}<>+-_=|\\\"\',./:;`";
            for (byte i = 0; i < SpecialChar.Length; i++)
            {
                str = str.Replace(SpecialChar.Substring(i, 1), "");
            }
            str = StringStandard(str);
            str = str.Replace(" ", "-");
            return str.ToLower();
        }

        public static string Url(string strSource)
        {
            return RemoveSpecialChar(strSource);
        }
    }
}
