namespace SunamoHelpers.Helpers.Number;

public static class HexHelper
{
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

    public static string ToHex(List<byte> bytes)
    {
        return Utils.ToHex(bytes);
    }

    public static List<byte> FromHex(string hexEncoded)
    {
        return Utils.FromHex(hexEncoded);
    }
}
