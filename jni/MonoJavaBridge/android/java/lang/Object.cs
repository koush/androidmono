using System;
namespace java.lang
{
    public partial class Object : MonoJavaBridge.JavaObject
    {
        internal Object(global::MonoJavaBridge.JniGlobalHandle handle) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
        {
            Init(global::MonoJavaBridge.JNIEnv.ThreadEnv, handle);
        }
        
        public override string ToString()
        {
            return toString();
        }
    }
}
