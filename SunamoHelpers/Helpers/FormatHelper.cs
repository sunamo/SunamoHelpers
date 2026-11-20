namespace SunamoHelpers.Helpers;

/// <summary>
/// Represents the format helper type.
/// </summary>
public class FormatHelper
{
    /// <summary>
    /// Gets or sets the parsed name.
    /// </summary>
    public static string? ParsedName { get; set; } = null;

    /// <summary>
    /// Gets or sets the parsed surname.
    /// </summary>
    public static string? ParsedSurname { get; set; } = null;

    /// <summary>
    /// Format email.
    /// </summary>
    /// <param name="nameSurname">The name surname.</param>
    /// <param name="postfix">The postfix.</param>
    /// <returns>The format email result.</returns>
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

    /// <summary>
    /// Format email.
    /// </summary>
    /// <param name="parts[0]">The parts 0.</param>
    /// <param name="parts[1]">The parts 1.</param>
    /// <param name="postfix">The postfix.</param>
    /// <returns>The format email result.</returns>
    public static string FormatEmail(string name, string surname, string postfix)
    {
        return SH.TextWithoutDiacritic(name.ToLower()) + "." + SH.TextWithoutDiacritic(surname.ToLower()) + "@" + postfix.TrimStart('@');
    }
}
