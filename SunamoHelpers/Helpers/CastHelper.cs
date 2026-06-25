namespace SunamoHelpers.Helpers;

public class CastHelper
{
    public static string ToString(object value)
    {
        var objectType = value.GetType();
        if (objectType == typeof(string))
        {
            return value.ToString()!;
        }
        else if (objectType == typeof(List<string>))
        {
            return string.Join(Environment.NewLine, (List<string>)value);
        }
        else
        {
            ThrowEx.DoesntHaveRequiredType(nameof(value));
        }

        return null!;
    }
}
