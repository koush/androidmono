using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoJavaBridge
{
    public class JavaException : Exception
    {
        internal JniGlobalHandle mHandle;
        public JavaException(JniGlobalHandle handle)
        {
            mHandle = handle;
        }
    }
}
