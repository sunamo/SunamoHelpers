namespace SunamoHelpers.Helpers;

public class GridHelperSunamo
{
    public static List<string> ForAllTheSame(int count)
    {
        var result = new List<string>(count);
        var proportion = 100d / count;
        for (int i = 0; i < count; i++)
        {
            result.Add(proportion + "*");
        }

        return result;
    }
}
