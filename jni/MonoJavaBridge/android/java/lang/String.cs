using System;
using MonoJavaBridge;

namespace java.lang
{
    public partial class String
    {
        public static implicit operator global::java.lang.String(string str)
        {
            JNIEnv env = JNIEnv.ThreadEnv;
            JniLocalHandle handle = env.NewString(str);
            String ret = new String(env);
            ret.Init(env, handle);
            return ret;
        }

        public static implicit operator string(global::java.lang.String str)
        {
            if (str == null)
            {
                return null;
            }
            JNIEnv env = JNIEnv.ThreadEnv;
            return env.ConvertToString(str.JvmHandle);
        }
    }
}

