namespace SunamoHelpers.Helpers.DataTypes;

public class BitHelper
{
    public static bool StartsWith(byte[] source, params byte[] prefix)
    {
        for (int i = 0; i < prefix.Length; i++)
        {
            if (prefix[i] != source[i])
            {
                return false;
            }
        }
        return true;
    }
}
