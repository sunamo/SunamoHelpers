namespace SunamoHelpers.Helpers.DataTypes;

/// <summary>
/// Represents the bit helper type.
/// </summary>
public class BitHelper
{
    /// <summary>
    /// Starts with.
    /// </summary>
    /// <param name="source">The source.</param>
    /// <param name="prefix">The prefix.</param>
    /// <returns>The starts with result.</returns>
    public static bool StartsWith(byte[] source, params byte[] prefix)
    {
        for (int index = 0; index < prefix.Length; index++)
        {
            if (prefix[index] != source[index])
            {
                return false;
            }
        }
        return true;
    }
}
