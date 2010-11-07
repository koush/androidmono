using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoJavaBridge
{
    public abstract class JavaObject : IJavaObject
    {
        internal JniGlobalHandle mJvmHandle;

        public JniGlobalHandle JvmHandle
        {
            get { return mJvmHandle; }
            set { mJvmHandle = value; }
        }
  
        bool mIsClrObject;
        public virtual bool IsClrObject
        {
            get
            {
                return mIsClrObject;
            }
        }
        
        public JavaObject(JNIEnv env)
        {
            Type type = GetType();
            mIsClrObject = type.GetCustomAttributes(typeof(JavaClassAttribute), false).Length == 0 && type.GetCustomAttributes(typeof(JavaProxyAttribute), false).Length == 0;
            
            //if (!mIsClrObject)
            //    GC.SuppressFinalize(this);
        }
        
        public void Init(JNIEnv env, JniLocalHandle handle)
        {
            if (JniLocalHandle.IsNull(handle))
                mJvmHandle = null;
            else
                mJvmHandle = env.NewGlobalRef(handle);
        }
      
        /*
        ~JavaObject()
        {
            if (IsClrObject)
                MonoJavaBridge.JavaBridge.AddToMortuary(this);
        }
        */
    }
}
