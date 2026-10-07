namespace SunamoHelpers.Helpers.DataTypes;

public class BitHelper
{
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
