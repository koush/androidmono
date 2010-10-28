using System;

namespace java.lang
{
    public partial class Throwable
    {
        public static implicit operator global::java.lang.Object(global::java.lang.Throwable throwable)
        {
            return new global::java.lang.Object(throwable.JvmHandle);
        }
    }
}

