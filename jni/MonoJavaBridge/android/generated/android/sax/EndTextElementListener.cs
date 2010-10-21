namespace android.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.sax.EndTextElementListener_))]
	public interface EndTextElementListener  : global::MonoJavaBridge.IJavaObject 
	{
		void end(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.sax.EndTextElementListener))]
	public sealed partial class EndTextElementListener_ : java.lang.Object, EndTextElementListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EndTextElementListener_()
		{
			InitJNI();
		}
		internal EndTextElementListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _end11559;
		 void android.sax.EndTextElementListener.end(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.sax.EndTextElementListener_._end11559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.sax.EndTextElementListener_.staticClass, global::android.sax.EndTextElementListener_._end11559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.EndTextElementListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/EndTextElementListener"));
			global::android.sax.EndTextElementListener_._end11559 = @__env.GetMethodIDNoThrow(global::android.sax.EndTextElementListener_.staticClass, "end", "(Ljava/lang/String;)V");
		}
	}
}
