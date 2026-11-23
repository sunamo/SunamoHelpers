namespace SunamoHelpers.Helpers.Runtime;

/// <summary>
/// Represents the platform interop helper type.
/// </summary>
public class PlatformInteropHelper
{
    /// <summary>
    /// Is selling app.
    /// </summary>
    /// <returns>The is selling app result.</returns>
    public static bool IsSellingApp()
    {
        return false;
    }

    private static bool? isUwp = null;

    /// <summary>
    /// Is uwp windows store app.
    /// </summary>
    /// <returns>The is uwp windows store app result.</returns>
    public static bool IsUwpWindowsStoreApp()
    {
        if (isUwp.HasValue)
        {
            return isUwp.Value;
        }

        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        foreach (var item in assemblies)
        {
            Type[]? types = null;
            try
            {
                types = item.GetTypes();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.GetType().Name + ": " + exception.Message);
                ThrowEx.Custom(exception);
            }

            if (types != null)
            {
                foreach (var currentType in types)
                {
                    if (currentType.Namespace != null)
                    {
                        if (currentType.Namespace.StartsWith("Windows.UI"))
                        {
                            isUwp = true;
                            break;
                        }
                    }
                }

                if (isUwp.HasValue)
                {
                    break;
                }
            }
        }

        if (!isUwp.HasValue)
        {
            isUwp = false;
        }

        return isUwp.Value;
    }

    /// <summary>
    /// Get type of resources.
    /// </summary>
    /// <returns>The get type of resources result.</returns>
    public static Type GetTypeOfResources()
    {
        throw new Exception();
    }

    /// <summary>
    /// Is use standard project.
    /// </summary>
    /// <returns>The is use standard project result.</returns>
    public static bool IsUseStandardProject()
    {
        var result = RuntimeInformation.FrameworkDescription;
        if (result.StartsWith(RuntimeFrameworks.NetCore))
        {
            return true;
        }

        return false;
    }
}
