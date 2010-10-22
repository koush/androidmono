namespace android.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.sax.StartElementListener_))]
	public partial interface StartElementListener  : global::MonoJavaBridge.IJavaObject 
	{
		void start(org.xml.sax.Attributes arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.sax.StartElementListener))]
	public sealed partial class StartElementListener_ : java.lang.Object, StartElementListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StartElementListener_()
		{
			InitJNI();
		}
		internal StartElementListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _start11563;
		 void android.sax.StartElementListener.start(org.xml.sax.Attributes arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.sax.StartElementListener_._start11563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.sax.StartElementListener_.staticClass, global::android.sax.StartElementListener_._start11563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.StartElementListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/StartElementListener"));
			global::android.sax.StartElementListener_._start11563 = @__env.GetMethodIDNoThrow(global::android.sax.StartElementListener_.staticClass, "start", "(Lorg/xml/sax/Attributes;)V");
		}
	}
}
