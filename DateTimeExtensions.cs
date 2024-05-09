using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekikalkulator
{
    public static class DateTimeExtensions
    {
        public static string ToCustomDateTimeFormat(this DateTime dateTime)
        {
            return dateTime.ToString("dd.MM.yyyy. HH:mm:ss");
        }
    }
}
