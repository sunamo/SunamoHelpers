namespace SunamoHelpers.Helpers.Resource;

/// <summary>
/// Represents the guid helper type.
/// </summary>
public class GuidHelper
{
    /// <summary>
    /// Remove dashes.
    /// </summary>
    /// <param name="guid">The guid.</param>
    /// <returns>The remove dashes result.</returns>
    public static string RemoveDashes(string guid)
    {
        return guid.Replace("-", "");
    }

    /// <summary>
    /// Add dashes.
    /// </summary>
    /// <param name="guid">The guid.</param>
    /// <returns>The add dashes result.</returns>
    public static string AddDashes(string guid)
    {
        if (guid.Contains("-"))
        {
            return guid;
        }
        guid = guid.Insert(8, "-");
        guid = guid.Insert(13, "-");
        guid = guid.Insert(18, "-");
        guid = guid.Insert(23, "-");
        return guid;
    }

    /// <summary>
    /// Guids only single letter.
    /// </summary>
    /// <returns>The guids only single letter result.</returns>
    public static string GuidsOnlySingleLetter()
    {
        List<string> list = new List<string>();
        for (int index = 0; index < 10; index++)
        {
            var text = index.ToString();
            text = text.PadLeft(32, text[0]);

            list.Add(AddDashes(text));
        }

        for (char letter = 'a'; letter < 'g'; letter++)
        {
            var text = letter.ToString();
            text = text.PadLeft(32, text[0]);

            list.Add(AddDashes(text));
        }

        return string.Join(Environment.NewLine, list);
    }
}
