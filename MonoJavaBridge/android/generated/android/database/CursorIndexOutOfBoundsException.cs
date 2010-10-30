namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CursorIndexOutOfBoundsException : java.lang.IndexOutOfBoundsException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CursorIndexOutOfBoundsException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CursorIndexOutOfBoundsException4514;
		public CursorIndexOutOfBoundsException(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorIndexOutOfBoundsException._CursorIndexOutOfBoundsException4514.native == global::System.IntPtr.Zero)
				global::android.database.CursorIndexOutOfBoundsException._CursorIndexOutOfBoundsException4514 = @__env.GetMethodIDNoThrow(global::android.database.CursorIndexOutOfBoundsException.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CursorIndexOutOfBoundsException.staticClass, global::android.database.CursorIndexOutOfBoundsException._CursorIndexOutOfBoundsException4514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CursorIndexOutOfBoundsException4515;
		public CursorIndexOutOfBoundsException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorIndexOutOfBoundsException._CursorIndexOutOfBoundsException4515.native == global::System.IntPtr.Zero)
				global::android.database.CursorIndexOutOfBoundsException._CursorIndexOutOfBoundsException4515 = @__env.GetMethodIDNoThrow(global::android.database.CursorIndexOutOfBoundsException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CursorIndexOutOfBoundsException.staticClass, global::android.database.CursorIndexOutOfBoundsException._CursorIndexOutOfBoundsException4515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
