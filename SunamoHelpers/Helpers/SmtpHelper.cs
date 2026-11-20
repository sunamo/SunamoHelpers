namespace SunamoHelpers.Helpers;

/// <summary>
/// Represents the smtp helper type.
/// </summary>
public class SmtpHelper
{
    /// <summary>
    /// Parse port.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The parse port result.</returns>
    public static int ParsePort(string text)
    {
        return BTS.ParseInt(text, NumConsts.DefaultPortIfCannotBeParsed);
    }
}
