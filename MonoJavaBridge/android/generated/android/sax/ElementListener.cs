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
		internal static global::MonoJavaBridge.MethodId _start11608;
		void android.sax.StartElementListener.start(org.xml.sax.Attributes arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.sax.ElementListener_._start11608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _end11609;
		void android.sax.EndElementListener.end()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.sax.ElementListener_._end11609);
		}
		static ElementListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.ElementListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/ElementListener"));
			global::android.sax.ElementListener_._start11608 = @__env.GetMethodIDNoThrow(global::android.sax.ElementListener_.staticClass, "start", "(Lorg/xml/sax/Attributes;)V");
			global::android.sax.ElementListener_._end11609 = @__env.GetMethodIDNoThrow(global::android.sax.ElementListener_.staticClass, "end", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
