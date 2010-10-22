namespace android.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.sax.EndElementListener_))]
	public partial interface EndElementListener  : global::MonoJavaBridge.IJavaObject 
	{
		void end();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.sax.EndElementListener))]
	public sealed partial class EndElementListener_ : java.lang.Object, EndElementListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EndElementListener_()
		{
			InitJNI();
		}
		internal EndElementListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _end11558;
		 void android.sax.EndElementListener.end() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.sax.EndElementListener_._end11558);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.sax.EndElementListener_.staticClass, global::android.sax.EndElementListener_._end11558);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.EndElementListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/EndElementListener"));
			global::android.sax.EndElementListener_._end11558 = @__env.GetMethodIDNoThrow(global::android.sax.EndElementListener_.staticClass, "end", "()V");
		}
	}
}
