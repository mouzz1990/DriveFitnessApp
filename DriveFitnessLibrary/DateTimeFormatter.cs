using System;
using System.Threading;

namespace DriveFitnessLibrary
{
    internal sealed class DateTimeFormatter : IFormatProvider, ICustomFormatter
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            string s;

            IFormattable formattable = arg as IFormattable;

            if (formattable == null) s = arg.ToString();
            else s = formattable.ToString(format, formatProvider);

            if (arg.GetType() == typeof(DateTime))
                return string.Format("{0}-{1}-{2}",
                    ((DateTime)arg).Year,
                    ((DateTime)arg).Month,
                    ((DateTime)arg).Day
                    );

            if (arg.GetType() == typeof(float))
                return string.Format("{0}",
                    ((float)arg).ToString().Replace(',', '.')
                    );

            return s;
        }

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter)) return this;
            return Thread.CurrentThread.CurrentCulture.GetFormat(formatType);
        }
    }
}
