using System;
using MonoJavaBridge;

namespace java.lang
{
    public partial class String
    {
        public static implicit operator String(string str)
        {
            JNIEnv env = JNIEnv.ThreadEnv;
            JniLocalHandle handle = env.NewString(str);
            String ret = new String(env);
            ret.Init(env, handle);
            return ret;
        }

        public static implicit operator string(String str)
        {
            if (str == (String) null)
            {
                return null;
            }
            JNIEnv env = JNIEnv.ThreadEnv;
            return env.ConvertToString(str.JvmHandle);
        }
    }
}

