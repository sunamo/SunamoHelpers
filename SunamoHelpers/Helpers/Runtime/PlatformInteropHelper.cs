namespace SunamoHelpers.Helpers.Runtime;

public class PlatformInteropHelper
{
    public static bool IsSellingApp()
    {
        return false;
    }

    private static bool? isUwp = null;

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name + ": " + ex.Message);
                ThrowEx.Custom(ex);
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

    public static Type GetTypeOfResources()
    {
        throw new Exception();
    }

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
