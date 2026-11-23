namespace SunamoHelpers.Helpers.Text;

/// <summary>
/// Represents the bit converter BE type.
/// </summary>
public static class BitConverterBE
{
    /// <summary>
    /// Get bytes.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The get bytes result.</returns>
    public static byte[] GetBytes(ulong value)
    {
        var buffer = new byte[8];
        buffer[0] = (byte)(value >> 56);
        buffer[1] = (byte)(value >> 48);
        buffer[2] = (byte)(value >> 40);
        buffer[3] = (byte)(value >> 32);
        buffer[4] = (byte)(value >> 24);
        buffer[5] = (byte)(value >> 16);
        buffer[6] = (byte)(value >> 8);
        buffer[7] = (byte)value;
        return buffer;
    }

    /// <summary>
    /// Get bytes.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The get bytes result.</returns>
    public static byte[] GetBytes(uint value)
    {
        var buffer = new byte[4];
        buffer[0] = (byte)(value >> 24);
        buffer[1] = (byte)(value >> 16);
        buffer[2] = (byte)(value >> 8);
        buffer[3] = (byte)value;
        return buffer;
    }

    /// <summary>
    /// Get bytes.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The get bytes result.</returns>
    public static byte[] GetBytes(ushort value)
    {
        var buffer = new byte[2];
        buffer[0] = (byte)(value >> 8);
        buffer[1] = (byte)value;
        return buffer;
    }

    /// <summary>
    /// To u int 16.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The to u int 16 result.</returns>
    public static ushort ToUInt16(byte[] value, int startIndex)
    {
        return (ushort)(
            value[startIndex] << 8 |
            value[startIndex + 1]);
    }

    /// <summary>
    /// To u int 32.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The to u int 32 result.</returns>
    public static uint ToUInt32(byte[] value, int startIndex)
    {
        return
            (uint)value[startIndex] << 24 |
            (uint)value[startIndex + 1] << 16 |
            (uint)value[startIndex + 2] << 8 |
            value[startIndex + 3];
    }

    /// <summary>
    /// To u int 64.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The to u int 64 result.</returns>
    public static ulong ToUInt64(byte[] value, int startIndex)
    {
        return
            (ulong)value[startIndex] << 56 |
            (ulong)value[startIndex + 1] << 48 |
            (ulong)value[startIndex + 2] << 40 |
            (ulong)value[startIndex + 3] << 32 |
            (ulong)value[startIndex + 4] << 24 |
            (ulong)value[startIndex + 5] << 16 |
            (ulong)value[startIndex + 6] << 8 |
            value[startIndex + 7];
    }
}
