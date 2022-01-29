using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Extension
{   
    public static class NullGuard
    {
        public static void ThrowExpIfNull<T>(this T obg, string name)
        {
            if (obg.IsNull())
            {
                throw new ArgumentException(name);
            }
        }

        public static bool IsNull<T>(this T obg) => obg == null;

        public static bool IsNotNull<T>(this T obg) => obg != null;
    }
}
