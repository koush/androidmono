using System;
using MonoJavaBridge;

namespace java.lang
{
    public partial class Object : MonoJavaBridge.JavaObject
    {
        internal Object(global::MonoJavaBridge.JniGlobalHandle handle) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
        {
            JvmHandle = handle;
        }
        
        /*
        public override string ToString()
        {
            return toString();
        }
        */
        
        
        /*
        public static bool operator==(Object one, IJavaObject two)
        {
            if (one == null && two == null)
                return true;
            if (one == null ^ two == null)
                return false;
            var env = JNIEnv.ThreadEnv;
            return env.IsSameObject(one.JvmHandle, two.JvmHandle);
        }
        
        public static bool operator!=(Object one, IJavaObject two)
        {
            if (one == null && two == null)
                return true;
            if (one == null ^ two == null)
                return false;
            var env = JNIEnv.ThreadEnv;
            return !env.IsSameObject(one.JvmHandle, two.JvmHandle);
        }
  
        public override bool Equals (object obj)
        {
            return equals(obj as java.lang.Object);
        }
        */
    }
}
