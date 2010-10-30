namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InterruptedIOException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InterruptedIOException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public InterruptedIOException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InterruptedIOException._m0.native == global::System.IntPtr.Zero)
				global::java.io.InterruptedIOException._m0 = @__env.GetMethodIDNoThrow(global::java.io.InterruptedIOException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InterruptedIOException.staticClass, global::java.io.InterruptedIOException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public InterruptedIOException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InterruptedIOException._m1.native == global::System.IntPtr.Zero)
				global::java.io.InterruptedIOException._m1 = @__env.GetMethodIDNoThrow(global::java.io.InterruptedIOException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InterruptedIOException.staticClass, global::java.io.InterruptedIOException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _bytesTransferred6382;
		public int bytesTransferred
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _bytesTransferred6382);
			}
			set
			{
			}
		}
		static InterruptedIOException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InterruptedIOException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InterruptedIOException"));
			global::java.io.InterruptedIOException._bytesTransferred6382 = @__env.GetFieldIDNoThrow(global::java.io.InterruptedIOException.staticClass, "bytesTransferred", "I");
		}
		internal static void InitJNI()
		{
		}
	}
}
