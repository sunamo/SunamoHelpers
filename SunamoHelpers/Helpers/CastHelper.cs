namespace SunamoHelpers.Helpers;

/// <summary>
/// Represents the cast helper type.
/// </summary>
public class CastHelper
{
    /// <summary>
    /// To string.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The to string result.</returns>
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
