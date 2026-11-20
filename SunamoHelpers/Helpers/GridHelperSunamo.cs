namespace SunamoHelpers.Helpers;

/// <summary>
/// Represents the grid helper sunamo type.
/// </summary>
public class GridHelperSunamo
{
    /// <summary>
    /// For all the same.
    /// </summary>
    /// <param name="count">The count.</param>
    /// <returns>The for all the same result.</returns>
    public static List<string> ForAllTheSame(int count)
    {
        var result = new List<string>(count);
        var proportion = 100d / count;
        for (int index = 0; index < count; index++)
        {
            result.Add(proportion + "*");
        }

        return result;
    }
}
