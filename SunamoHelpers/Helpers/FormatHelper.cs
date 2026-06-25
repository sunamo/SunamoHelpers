namespace SunamoHelpers.Helpers;

public class FormatHelper
{
    public static string? ParsedName { get; set; } = null;

    public static string? ParsedSurname { get; set; } = null;

    public static string FormatEmail(string nameSurname, string postfix)
    {
        var parts = SHSplit.Split(nameSurname, " ");
        if (parts.Count != 2)
        {
            ThrowEx.WrongNumberOfElements(2, "parts", parts);
        }
        ParsedName = parts[0];
        ParsedSurname = parts[1];
        return FormatEmail(parts[0], parts[1], postfix);
    }

    public static string FormatEmail(string name, string surname, string postfix)
    {
        return SH.TextWithoutDiacritic(name.ToLower()) + "." + SH.TextWithoutDiacritic(surname.ToLower()) + "@" + postfix.TrimStart('@');
    }
}
