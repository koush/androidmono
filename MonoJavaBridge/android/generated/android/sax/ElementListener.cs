namespace android.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.sax.ElementListener_))]
	public partial interface ElementListener : StartElementListener, EndElementListener
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.sax.ElementListener))]
	internal sealed partial class ElementListener_ : java.lang.Object, ElementListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ElementListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.sax.StartElementListener.start(org.xml.sax.Attributes arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.ElementListener_.staticClass, "start", "(Lorg/xml/sax/Attributes;)V", ref global::android.sax.ElementListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.sax.EndElementListener.end()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.ElementListener_.staticClass, "end", "()V", ref global::android.sax.ElementListener_._m1);
		}
		static ElementListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.ElementListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/ElementListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}
