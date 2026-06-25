namespace SunamoHelpers.Helpers;

public class LocaleHelper
{
    public static void Init()
    {
        foreach (var item in CultureInfo.GetCultures(CultureTypes.AllCultures))
        {
        }
    }

    // Note: not reliable because for "en" it returns "AG". Use GetCountryForLang2 instead.
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
