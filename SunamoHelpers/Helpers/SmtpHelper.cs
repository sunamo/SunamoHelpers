namespace SunamoHelpers.Helpers;

public class SmtpHelper
{
    public static int ParsePort(string text)
    {
        return BTS.ParseInt(text, NumConsts.DefaultPortIfCannotBeParsed);
    }
}
