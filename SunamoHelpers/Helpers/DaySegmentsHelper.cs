namespace SunamoHelpers.Helpers;

public class DaySegmentsHelper
{
    private const int SecondsInOneSegment = 300;
    private const int CountOfSegments = 288;
    private static readonly DateTime MinDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0);

    public static int GetSegment()
    {
        var dateTime = DateTime.Now;
        return GetSegment(dateTime);
    }

    public static int GetSegment(DateTime dateTime)
    {
        var timeOnly = new DateTime(1, 1, 1, dateTime.Hour, dateTime.Minute, dateTime.Second);

        var totalSeconds = (timeOnly - MinDateTime).TotalSeconds;
        var segmentIndex = totalSeconds / SecondsInOneSegment;
        return (int)segmentIndex;
    }
}
