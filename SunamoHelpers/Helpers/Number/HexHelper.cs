namespace SunamoHelpers.Helpers.Number;

/// <summary>
/// Represents the hex helper type.
/// </summary>
public static class HexHelper
{
    /// <summary>
    /// Is in hex format.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The is in hex format result.</returns>
    public static bool IsInHexFormat(string text)
    {
        foreach (var item in text)
        {
            if (!"0123456789abcdef".Contains(item.ToString()))
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// To hex.
    /// </summary>
    /// <param name="bytes">The bytes.</param>
    /// <returns>The to hex result.</returns>
    public static string ToHex(List<byte> bytes)
    {
        return Utils.ToHex(bytes);
    }

    /// <summary>
    /// From hex.
    /// </summary>
    /// <param name="hexEncoded">The hex encoded.</param>
    /// <returns>The from hex result.</returns>
    public static List<byte> FromHex(string hexEncoded)
    {
        return Utils.FromHex(hexEncoded);
    }
}
