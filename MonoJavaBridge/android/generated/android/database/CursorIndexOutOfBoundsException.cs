namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CursorIndexOutOfBoundsException : java.lang.IndexOutOfBoundsException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CursorIndexOutOfBoundsException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public CursorIndexOutOfBoundsException(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorIndexOutOfBoundsException._m0.native == global::System.IntPtr.Zero)
				global::android.database.CursorIndexOutOfBoundsException._m0 = @__env.GetMethodIDNoThrow(global::android.database.CursorIndexOutOfBoundsException.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CursorIndexOutOfBoundsException.staticClass, global::android.database.CursorIndexOutOfBoundsException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public CursorIndexOutOfBoundsException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorIndexOutOfBoundsException._m1.native == global::System.IntPtr.Zero)
				global::android.database.CursorIndexOutOfBoundsException._m1 = @__env.GetMethodIDNoThrow(global::android.database.CursorIndexOutOfBoundsException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CursorIndexOutOfBoundsException.staticClass, global::android.database.CursorIndexOutOfBoundsException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CursorIndexOutOfBoundsException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.CursorIndexOutOfBoundsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CursorIndexOutOfBoundsException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
