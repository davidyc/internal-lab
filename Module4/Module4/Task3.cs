using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    public static class Task3
    {
        public static bool IsNull<T>(this Nullable<T> obj) where T : struct
        {
            return obj == null ? true : false;
        }

        public static bool IsNull(this object obj)
        {
            return obj == null ? true : false;
        }
    }
}
