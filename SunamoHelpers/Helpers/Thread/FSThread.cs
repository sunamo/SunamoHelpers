namespace SunamoHelpers.Helpers.Thread;

/// <summary>
/// Represents the FS thread type.
/// </summary>
public class FSThread
{
    /// <summary>
    /// Get file name.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <returns>The get file name result.</returns>
    public static string GetFileName(string path) => Path.GetFileName(path);
}
