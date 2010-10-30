namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ReceiverCallNotAllowedException : android.util.AndroidRuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ReceiverCallNotAllowedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ReceiverCallNotAllowedException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ReceiverCallNotAllowedException._m0.native == global::System.IntPtr.Zero)
				global::android.content.ReceiverCallNotAllowedException._m0 = @__env.GetMethodIDNoThrow(global::android.content.ReceiverCallNotAllowedException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ReceiverCallNotAllowedException.staticClass, global::android.content.ReceiverCallNotAllowedException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ReceiverCallNotAllowedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ReceiverCallNotAllowedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ReceiverCallNotAllowedException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
