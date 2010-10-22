namespace android.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.sax.TextElementListener_))]
	public partial interface TextElementListener : StartElementListener, EndTextElementListener
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.sax.TextElementListener))]
	public sealed partial class TextElementListener_ : java.lang.Object, TextElementListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TextElementListener_()
		{
			InitJNI();
		}
		internal TextElementListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _start11564;
		 void android.sax.StartElementListener.start(org.xml.sax.Attributes arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.sax.TextElementListener_._start11564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.sax.TextElementListener_.staticClass, global::android.sax.TextElementListener_._start11564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _end11565;
		 void android.sax.EndTextElementListener.end(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.sax.TextElementListener_._end11565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.sax.TextElementListener_.staticClass, global::android.sax.TextElementListener_._end11565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.TextElementListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/TextElementListener"));
			global::android.sax.TextElementListener_._start11564 = @__env.GetMethodIDNoThrow(global::android.sax.TextElementListener_.staticClass, "start", "(Lorg/xml/sax/Attributes;)V");
			global::android.sax.TextElementListener_._end11565 = @__env.GetMethodIDNoThrow(global::android.sax.TextElementListener_.staticClass, "end", "(Ljava/lang/String;)V");
		}
	}
}
