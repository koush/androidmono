namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ReceiverCallNotAllowedException : android.util.AndroidRuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ReceiverCallNotAllowedException()
		{
			InitJNI();
		}
		protected ReceiverCallNotAllowedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ReceiverCallNotAllowedException3499;
		public ReceiverCallNotAllowedException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ReceiverCallNotAllowedException.staticClass, global::android.content.ReceiverCallNotAllowedException._ReceiverCallNotAllowedException3499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ReceiverCallNotAllowedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ReceiverCallNotAllowedException"));
			global::android.content.ReceiverCallNotAllowedException._ReceiverCallNotAllowedException3499 = @__env.GetMethodIDNoThrow(global::android.content.ReceiverCallNotAllowedException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
