namespace SunamoHelpers.Helpers;

/// <summary>
/// Represents the locale helper type.
/// </summary>
public class LocaleHelper
{
    /// <summary>
    /// Init.
    /// </summary>
    public static void Init()
    {
        foreach (var item in CultureInfo.GetCultures(CultureTypes.AllCultures))
        {
        }
    }

    // Note: not reliable because for "en" it returns "AG". Use GetCountryForLang2 instead.
    /// <summary>
    /// Get country for lang.
    /// </summary>
    /// <param name="lang">The lang.</param>
    /// <returns>The get country for lang result.</returns>
    public static string GetCountryForLang(string lang)
    {
        lang = lang.ToLower();
        foreach (var item in CultureInfo.GetCultures(CultureTypes.AllCultures))
        {
            var parts = SHSplit.Split(item.Name, "-");
            if (parts.Count > 1)
            {
                if (parts[0] == lang)
                {
                    if (parts[1].Length == 2)
                    {
                        ComplexInfoString complexInfo = new ComplexInfoString(parts[1]);
                        if (complexInfo.QuantityUpperChars == 2)
                        {
                            return parts[1];
                        }
                    }
                }
            }
        }
        return null!;
    }
}
