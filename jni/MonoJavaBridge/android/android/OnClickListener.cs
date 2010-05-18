using System;
using android.view;
using java.lang;
using net.sf.jni4net.jni;

namespace com.koushikdutta.monojavabridge.android
{
    public class OnClickListener : java.lang.Object, View.OnClickListener
    {
        static Class staticClass;
        static MethodId constructor;
        
        static OnClickListener()
        {
            var env = JNIEnv.ThreadEnv;
            staticClass = env.FindClass("com/koushikdutta/monojavabridge/android/OnClickListener");
            constructor = env.GetMethodID(staticClass, "<init>", "()V");
        }
        
        public OnClickListener()
            : base(JNIEnv.ThreadEnv)
        {
            Console.WriteLine("Foo bar moo goo");
            var env = JNIEnv.ThreadEnv; 
            env.NewObject(staticClass, constructor, this);
            MonoJavaBridge.JavaBridge.Attach(this, this);
        }
        
        protected OnClickListener(net.sf.jni4net.jni.JNIEnv env)
            : base(env)
        {
        }
        
        #region OnClickListener implementation
        public void onClick (View arg0)
        {
            OnClick(arg0);
        }
        #endregion
        
        public delegate void OnClickHandler(View arg0);
        public OnClickHandler OnClick;           
    }
}
