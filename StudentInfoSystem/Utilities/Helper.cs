using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem.Utilities
{
    public static class Helper
    {
        public static T CloneObject <T> (this object source)
        {
            T result = Activator.CreateInstance<T>();
            result = (T)source;
            return result;
        }
    }
}
