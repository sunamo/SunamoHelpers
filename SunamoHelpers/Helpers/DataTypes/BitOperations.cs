namespace SunamoHelpers.Helpers.DataTypes;

/// <summary>
/// Represents the bit operations type.
/// </summary>
public static class BitOperations
{
    /// <summary>
    /// Copy block.
    /// </summary>
    /// <param name="bytes">The bytes.</param>
    /// <param name="offset">The offset.</param>
    /// <param name="length">The length.</param>
    /// <returns>The copy block result.</returns>
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
            int index;

            for (index = 0; index < endByte - startByte; index++)
            {
                destination[index] = (byte)(bytes[startByte + index] << shiftA | bytes[startByte + index + 1] >> shiftB);
            }

            if (index < destination.Length)
            {
                destination[index] = (byte)(bytes[startByte + index] << shiftA);
            }
        }

        destination[destination.Length - 1] &= (byte)(0xFF << destination.Length * 8 - length);

        return destination;
    }

    /// <summary>
    /// Copy bytes.
    /// </summary>
    /// <param name="destination">The destination.</param>
    /// <param name="destinationOffset">The destination offset.</param>
    /// <param name="source">The source.</param>
    public static void CopyBytes(byte[] destination, int destinationOffset, byte[] source)
    {
        Buffer.BlockCopy(source, 0, destination, destinationOffset, source.Length);
    }

    /// <summary>
    /// Read.
    /// </summary>
    /// <param name="bits">The bits.</param>
    /// <param name="length">The length.</param>
    /// <returns>The read result.</returns>
    public static int Read(ref ulong bits, int length)
    {
        int result = (int)(bits >> 64 - length);
        bits <<= length;
        return result;
    }

    /// <summary>
    /// Read.
    /// </summary>
    /// <param name="bytes">The bytes.</param>
    /// <param name="offset">The offset.</param>
    /// <param name="length">The length.</param>
    /// <returns>The read result.</returns>
    public static int Read(byte[] bytes, ref int offset, int length)
    {
        int startByte = offset / 8;
        int endByte = (offset + length - 1) / 8;
        int skipBits = offset % 8;
        ulong bits = 0;

        for (int index = 0; index <= Math.Min(endByte - startByte, 7); index++)
        {
            bits |= (ulong)bytes[startByte + index] << 56 - index * 8;
        }

        if (skipBits != 0)
        {
            Read(ref bits, skipBits);
        }

        offset += length;

        return Read(ref bits, length);
    }

    /// <summary>
    /// Write.
    /// </summary>
    /// <param name="bits">The bits.</param>
    /// <param name="length">The length.</param>
    /// <param name="value">The value.</param>
    public static void Write(ref ulong bits, int length, int value)
    {
        ulong mask = 0xFFFFFFFFFFFFFFFF >> 64 - length;
        bits = bits << length | (ulong)value & mask;
    }
}
