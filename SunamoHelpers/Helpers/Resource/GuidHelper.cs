namespace SunamoHelpers.Helpers.Resource;

public class GuidHelper
{
    public static string RemoveDashes(string guid)
    {
        return guid.Replace("-", "");
    }

    public static string AddDashes(string guid)
    {
        if (guid.Contains("-"))
        {
            return guid;
        }
        guid = guid.Insert(8, "-");
        guid = guid.Insert(13, "-");
        guid = guid.Insert(18, "-");
        guid = guid.Insert(23, "-");
        return guid;
    }

    public static string GuidsOnlySingleLetter()
    {
        List<string> list = new List<string>();
        for (int index = 0; index < 10; index++)
        {
            var text = index.ToString();
            text = text.PadLeft(32, text[0]);

            list.Add(AddDashes(text));
        }

        for (char letter = 'a'; letter < 'g'; letter++)
        {
            var text = letter.ToString();
            text = text.PadLeft(32, text[0]);

            list.Add(AddDashes(text));
        }

        return string.Join(Environment.NewLine, list);
    }
}
