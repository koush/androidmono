namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IdentityInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IdentityInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close33453;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.IdentityInputStream._close33453.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.IdentityInputStream._close33453 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityInputStream.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.IdentityInputStream.staticClass, global::org.apache.http.impl.io.IdentityInputStream._close33453);
		}
		internal static global::MonoJavaBridge.MethodId _read33454;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.IdentityInputStream._read33454.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.IdentityInputStream._read33454 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityInputStream.staticClass, "read", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.IdentityInputStream.staticClass, global::org.apache.http.impl.io.IdentityInputStream._read33454);
		}
		internal static global::MonoJavaBridge.MethodId _read33455;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.IdentityInputStream._read33455.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.IdentityInputStream._read33455 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityInputStream.staticClass, "read", "([BII)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.IdentityInputStream.staticClass, global::org.apache.http.impl.io.IdentityInputStream._read33455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _available33456;
		public override int available()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.IdentityInputStream._available33456.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.IdentityInputStream._available33456 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityInputStream.staticClass, "available", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.IdentityInputStream.staticClass, global::org.apache.http.impl.io.IdentityInputStream._available33456);
		}
		internal static global::MonoJavaBridge.MethodId _IdentityInputStream33457;
		public IdentityInputStream(org.apache.http.io.SessionInputBuffer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.IdentityInputStream._IdentityInputStream33457.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.IdentityInputStream._IdentityInputStream33457 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityInputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionInputBuffer;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.IdentityInputStream.staticClass, global::org.apache.http.impl.io.IdentityInputStream._IdentityInputStream33457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IdentityInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.IdentityInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/IdentityInputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
