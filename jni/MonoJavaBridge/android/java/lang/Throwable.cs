using System;

namespace java.lang
{
    public partial class Throwable
    {
        public static implicit operator global::System.Exception(global::java.lang.Throwable t)
        {
            return new MonoJavaBridge.JavaException(t.JvmHandle);
        }
    }
}

