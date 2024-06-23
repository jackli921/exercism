using System;
using System.Linq;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        var bytes = reading switch
        {
            < int.MinValue => BitConverter.GetBytes((long)reading).Prepend((byte)(256 - 8)), // if the value is smaller than the min value of int data type, then the next big data type, long, must be used, 8 bytes,
            < Int16.MinValue => BitConverter.GetBytes((int)reading).Prepend((byte)(256 - 4)), // if the value is smaller than the min value of the Int16 (short data type), then the next big data type must be used, which is int, at 32 bits/4 bytes
            < UInt16.MinValue => BitConverter.GetBytes((short)reading).Prepend((byte)(256 - 2)), // if the value is smaller than min value of unsigned short, which is 0, then the signed version of that data type should be used to hold it, which is short at 2 bytes, with min value of  -32_768
            <= UInt16.MaxValue => BitConverter.GetBytes((ushort)reading).Prepend((byte)2), //if the value is smaller or equal to max value of unsigned short, at 65_535, then it can be held by unsigned short. Since it's unsigned, 2 byte is prepended without being subtracted by 256
            // the next level of max data size is not UInt32, because maximum value of unsigned int values are double of their signed counter parts, so the next level is the opposite, i.e, signed data type of the next level  
            <= Int32.MaxValue => BitConverter.GetBytes((int)reading).Prepend((byte)(256 - 4)), // if the value is smaller than the max value of int32, or regular int, then it can be held by the signed int data type, which includes both +/- numbers, which means it needs to be prepended with 256 - 4 bytes 
            <= UInt32.MaxValue => BitConverter.GetBytes((uint)reading).Prepend((byte)4), // if the value is smaller than the max value of unsigned int at 4 bytes, then it can be held by uint, which can be prepended without being subtracted by 256
            _ => BitConverter.GetBytes((long)reading).Prepend((byte)(256 - 8)), // any other data type must be handled by the max possible storage room for preventing data and precision lost 
        };

        return bytes.Concat(new byte [9 - bytes.Count()]).ToArray(); // create the byte array by concatenating the buffer (number of bytes, value itself) with trailing zeros that combine to a total of 9 bytes
    }

    public static long FromBuffer(byte[] buffer) => buffer[0] switch //read the buffer byte at index 0 to if its signed/unsigned data type and how big it is
    {
        256 - 8 or 4 or 2 => BitConverter.ToInt64(buffer, 1), // if it's long, unsigned int or short, change to 64 bit int
        256 - 4 => BitConverter.ToInt32(buffer, 1), // if it's signed int, change to 32 bit int
        256 - 2 => BitConverter.ToInt16(buffer, 1), // if it's signed short, change to 16 bit short 
        _ => 0
    };
}
