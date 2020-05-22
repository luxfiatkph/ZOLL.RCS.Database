using System;

namespace ZOLL.RCS.Database.DataUnitTests
{
    public static class UnitTestHelper
    {
        public static string Tweak(string s)
        {
            var array = new char[s.Length];
            var index = 0;
            for (var i = s.Length - 1; i >= 0; i--)
            {
                array[index++] = s[i];
            }

            return new string(array);
        }

        public static short Tweak(short value)
        {
            if (value > 0) return --value;
            return ++value;
        }

        public static short? Tweak(short? value)
        {
            if (value == null) return 0;
            if (value > 0) return --value;
            return ++value;
        }

        public static int? Tweak(int? value)
        {
            if (value == null) return 0;
            if (value > 0) return --value;
            return ++value;
        }

        public static bool? Tweak(bool? value)
        {
            if (value == null) return true;
            return !value.Value;
        }

        public static DateTime? Tweak(DateTime? value)
        {
            return value?.AddDays(1) ?? DateTime.Today;
        }

        public static Guid Tweak(Guid value)
        {
            var s = value.ToString().Replace("-", "");
            s = Tweak(s);
            var result = Guid.Parse(s);
            return result;
        }

        public static Guid? Tweak(Guid? value)
        {
            Guid? result;
            if (value == null)
            {
                result = Guid.NewGuid();
            }
            else
            {
                var s = value.ToString().Replace("-", "");
                s = Tweak(s);
                result = Guid.Parse(s);
            }

            return result;
        }
    }
}