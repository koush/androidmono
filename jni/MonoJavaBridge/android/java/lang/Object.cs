using System;
namespace java.lang
{
    public partial class Object : MonoJavaBridge.JavaObject
    {
        public Object(global::MonoJavaBridge.JniGlobalHandle handle) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
        {
            Init(global::MonoJavaBridge.JNIEnv.ThreadEnv, handle);
        }
        
        public static implicit operator global::java.lang.Object(global::java.lang.Throwable throwable)
        {
            return new global::java.lang.Object(throwable.JvmHandle);
        }
    }
}
