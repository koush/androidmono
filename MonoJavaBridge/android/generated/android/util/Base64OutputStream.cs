namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Base64OutputStream : java.io.FilterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Base64OutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.Base64OutputStream.staticClass, "write", "(I)V", ref global::android.util.Base64OutputStream._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.Base64OutputStream.staticClass, "write", "([BII)V", ref global::android.util.Base64OutputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.Base64OutputStream.staticClass, "close", "()V", ref global::android.util.Base64OutputStream._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public Base64OutputStream(java.io.OutputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64OutputStream._m3.native == global::System.IntPtr.Zero)
				global::android.util.Base64OutputStream._m3 = @__env.GetMethodIDNoThrow(global::android.util.Base64OutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Base64OutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Base64OutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Base64OutputStream"));
		}
	}
}
