namespace SunamoHelpers.Helpers;

/// <summary>
/// Represents the day segments helper type.
/// </summary>
public class DaySegmentsHelper
{
    private const int SecondsInOneSegment = 300;
    private const int CountOfSegments = 288;
    private static readonly DateTime MinDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0);

    /// <summary>
    /// Get segment.
    /// </summary>
    /// <returns>The get segment result.</returns>
    public static int GetSegment()
    {
        var dateTime = DateTime.Now;
        return GetSegment(dateTime);
    }

    /// <summary>
    /// Get segment.
    /// </summary>
    /// <param name="dateTime">The date time.</param>
    /// <returns>The get segment result.</returns>
    public static int GetSegment(DateTime dateTime)
    {
        var timeOnly = new DateTime(1, 1, 1, dateTime.Hour, dateTime.Minute, dateTime.Second);

        var totalSeconds = (timeOnly - MinDateTime).TotalSeconds;
        var segmentIndex = totalSeconds / SecondsInOneSegment;
        return (int)segmentIndex;
    }
}
