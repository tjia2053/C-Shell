using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class NumberSizeandRange_01
    {
        public static void Show_the_Type()
        {
            Console.WriteLine($"The number of bytes of sbyte in memory is {sizeof(sbyte)}");
            Console.WriteLine($"The maximum value of sbyte is {int.MaxValue}");
            Console.WriteLine($"The minimum value of sbyte is {int.MinValue}");
            Console.WriteLine($"The number of bytes of byte in memory is {sizeof(byte)}");
            Console.WriteLine($"The maximum value of byte is {byte.MaxValue}");
            Console.WriteLine($"The minimum value of byte is {byte.MinValue}");
            Console.WriteLine($"The number of bytes of short in memory is {sizeof(short)}");
            Console.WriteLine($"The maximum value of short is {short.MaxValue}");
            Console.WriteLine($"The minimum value of short is {short.MinValue}");
            Console.WriteLine($"The number of bytes of ushort in memory is {sizeof(ushort)}");
            Console.WriteLine($"The maximum value of ushort is {ushort.MaxValue}");
            Console.WriteLine($"The minimum value of ushort is {ushort.MinValue}");
            Console.WriteLine($"The number of bytes of int in memory is {sizeof(int)}");
            Console.WriteLine($"The maximum value of int is {int.MaxValue}");
            Console.WriteLine($"The minimum value of int is {int.MinValue}");
            Console.WriteLine($"The number of bytes of uint in memory is {sizeof(uint)}");
            Console.WriteLine($"The maximum value of uint is {uint.MaxValue}");
            Console.WriteLine($"The minimum value of uint is {uint.MinValue}");
            Console.WriteLine($"The number of bytes of long in memory is {sizeof(long)}");
            Console.WriteLine($"The maximum value of long is {long.MaxValue}");
            Console.WriteLine($"The minimum value of long is {long.MinValue}");
            Console.WriteLine($"The number of bytes of ulong in memory is {sizeof(ulong)}");
            Console.WriteLine($"The maximum value of ulong is {ulong.MaxValue}");
            Console.WriteLine($"The minimum value of ulong is {ulong.MinValue}");
            Console.WriteLine($"The number of bytes of float in memory is {sizeof(float)}");
            Console.WriteLine($"The maximum value of float is {float.MaxValue}");
            Console.WriteLine($"The minimum value of float is {float.MinValue}");
            Console.WriteLine($"The number of bytes of double in memory is {sizeof(double)}");
            Console.WriteLine($"The maximum value of double is {double.MaxValue}");
            Console.WriteLine($"The minimum value of double is {double.MinValue}");
            Console.WriteLine($"The number of bytes of decimal in memory is {sizeof(decimal)}");
            Console.WriteLine($"The maximum value of decimal is {decimal.MaxValue}");
            Console.WriteLine($"The minimum value of decimal is {decimal.MinValue}");
        }

        public static void CenturiesConvert(byte centuries)
        {
            ushort year = Convert.ToUInt16(centuries * 100);
            uint day = Convert.ToUInt32(year * 365 + year /4);
            uint hour = day * 24;
            ulong minute = hour * 60;
            ulong second = Convert.ToUInt64(minute * 60);
            ulong milliesecond = second * 1000;
            ulong microsecond = milliesecond * 1000;
            string nanosecond = Convert.ToString(microsecond * 1000);
            Console.WriteLine($"{centuries} Centuries = {year} Years = {day} Days = {hour} Hours = {minute} Minutes = {second} Seconds = {milliesecond} Milliesconds = {microsecond} Micorsecond = {nanosecond} Nanosecond");
        }
    }
}
