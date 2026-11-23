namespace SunamoHelpers.Helpers.Runtime;

/// <summary>
/// Represents the dynamic helper type.
/// </summary>
public class DynamicHelper
{
    /// <summary>
    /// List from dynamic object.
    /// </summary>
    /// <param name="dynamicObject">The dynamic object.</param>
    /// <returns>The list from dynamic object result.</returns>
    public static List<dynamic> ListFromDynamicObject(dynamic dynamicObject)
    {
        ThrowEx.NotImplementedMethod();

        if (dynamicObject is IList)
        {
            List<dynamic> result = new List<dynamic>();
            var outerList = (IList)dynamicObject;

            foreach (IList innerList in outerList)
            {
                foreach (var element in innerList)
                {
                    result.Add(element);
                }
            }

            return result;
        }

        List<dynamic> elements = new List<dynamic>();
        var objectType = (Type)dynamicObject.GetType();

        return null!;
    }
}
