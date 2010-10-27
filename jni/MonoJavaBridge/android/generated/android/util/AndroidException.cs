namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AndroidException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AndroidException()
		{
			InitJNI();
		}
		protected AndroidException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AndroidException13672;
		public AndroidException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.AndroidException.staticClass, global::android.util.AndroidException._AndroidException13672);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AndroidException13673;
		public AndroidException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.AndroidException.staticClass, global::android.util.AndroidException._AndroidException13673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AndroidException13674;
		public AndroidException(java.lang.Exception arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.AndroidException.staticClass, global::android.util.AndroidException._AndroidException13674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.AndroidException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/AndroidException"));
			global::android.util.AndroidException._AndroidException13672 = @__env.GetMethodIDNoThrow(global::android.util.AndroidException.staticClass, "<init>", "()V");
			global::android.util.AndroidException._AndroidException13673 = @__env.GetMethodIDNoThrow(global::android.util.AndroidException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.util.AndroidException._AndroidException13674 = @__env.GetMethodIDNoThrow(global::android.util.AndroidException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
		}
	}
}
