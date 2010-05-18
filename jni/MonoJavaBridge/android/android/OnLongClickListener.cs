using System;
using android.view;
using java.lang;
using net.sf.jni4net.jni;

namespace com.koushikdutta.monojavabridge.android
{
    public class OnLongClickListener : java.lang.Object, View.OnLongClickListener
    {
        static Class staticClass;
        static MethodId constructor;
        
        static OnLongClickListener()
        {
            var env = JNIEnv.ThreadEnv;
            staticClass = env.FindClass("com/koushikdutta/monojavabridge/android/OnLongClickListener");
            constructor = env.GetMethodID(staticClass, "<init>", "()V"); 
        }
        
        public OnLongClickListener()
            : base(JNIEnv.ThreadEnv)
        {
            var env = JNIEnv.ThreadEnv; 
            env.NewObject(staticClass, constructor, this);
            MonoJavaBridge.JavaBridge.Attach(this, this);
        }
        
        protected OnLongClickListener(net.sf.jni4net.jni.JNIEnv env)
            : base(env)
        {
        }
        
        #region OnLongClickListener implementation
        public bool onLongClick (View arg0)
        {
            return OnLongClick(arg0);
        }
        #endregion
        
        public delegate bool OnLongClickHandler(View arg0);
        public OnLongClickHandler OnLongClick;           
    }
}
