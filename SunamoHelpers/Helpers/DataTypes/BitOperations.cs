namespace SunamoHelpers.Helpers.DataTypes;

public static class BitOperations
{
    public static byte[] CopyBlock(byte[] bytes, int offset, int length)
    {
        int startByte = offset / 8;
        int endByte = (offset + length - 1) / 8;
        int shiftA = offset % 8;
        int shiftB = 8 - shiftA;
        var destination = new byte[(length + 7) / 8];

        if (shiftA == 0)
        {
            Buffer.BlockCopy(bytes, startByte, destination, 0, destination.Length);
        }

        else
        {
            int i;

            for (i = 0; i < endByte - startByte; i++)
            {
                destination[i] = (byte)(bytes[startByte + i] << shiftA | bytes[startByte + i + 1] >> shiftB);
            }

            if (i < destination.Length)
            {
                destination[i] = (byte)(bytes[startByte + i] << shiftA);
            }
        }

        destination[destination.Length - 1] &= (byte)(0xFF << destination.Length * 8 - length);

        return destination;
    }

    public static void CopyBytes(byte[] destination, int destinationOffset, byte[] source)
    {
        Buffer.BlockCopy(source, 0, destination, destinationOffset, source.Length);
    }

    public static int Read(ref ulong bits, int length)
    {
        int result = (int)(bits >> 64 - length);
        bits <<= length;
        return result;
    }

    public static int Read(byte[] bytes, ref int offset, int length)
    {
        int startByte = offset / 8;
        int endByte = (offset + length - 1) / 8;
        int skipBits = offset % 8;
        ulong bits = 0;

        for (int i = 0; i <= Math.Min(endByte - startByte, 7); i++)
        {
            bits |= (ulong)bytes[startByte + i] << 56 - i * 8;
        }

        if (skipBits != 0)
        {
            Read(ref bits, skipBits);
        }

        offset += length;

        return Read(ref bits, length);
    }

    public static void Write(ref ulong bits, int length, int value)
    {
        ulong mask = 0xFFFFFFFFFFFFFFFF >> 64 - length;
        bits = bits << length | (ulong)value & mask;
    }
}
