namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Base64OutputStream : java.io.FilterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Base64OutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write13722;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64OutputStream._write13722.native == global::System.IntPtr.Zero)
				global::android.util.Base64OutputStream._write13722 = @__env.GetMethodIDNoThrow(global::android.util.Base64OutputStream.staticClass, "write", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._write13722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write13723;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64OutputStream._write13723.native == global::System.IntPtr.Zero)
				global::android.util.Base64OutputStream._write13723 = @__env.GetMethodIDNoThrow(global::android.util.Base64OutputStream.staticClass, "write", "([BII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._write13723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _close13724;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64OutputStream._close13724.native == global::System.IntPtr.Zero)
				global::android.util.Base64OutputStream._close13724 = @__env.GetMethodIDNoThrow(global::android.util.Base64OutputStream.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._close13724);
		}
		internal static global::MonoJavaBridge.MethodId _Base64OutputStream13725;
		public Base64OutputStream(java.io.OutputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64OutputStream._Base64OutputStream13725.native == global::System.IntPtr.Zero)
				global::android.util.Base64OutputStream._Base64OutputStream13725 = @__env.GetMethodIDNoThrow(global::android.util.Base64OutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._Base64OutputStream13725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Base64OutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Base64OutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Base64OutputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
