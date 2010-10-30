namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentLengthInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentLengthInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close33428;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.ContentLengthInputStream._close33428.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.ContentLengthInputStream._close33428 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, global::org.apache.http.impl.io.ContentLengthInputStream._close33428);
		}
		internal static global::MonoJavaBridge.MethodId _read33429;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.ContentLengthInputStream._read33429.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.ContentLengthInputStream._read33429 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "read", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, global::org.apache.http.impl.io.ContentLengthInputStream._read33429);
		}
		internal static global::MonoJavaBridge.MethodId _read33430;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.ContentLengthInputStream._read33430.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.ContentLengthInputStream._read33430 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "read", "([BII)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, global::org.apache.http.impl.io.ContentLengthInputStream._read33430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read33431;
		public override int read(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.ContentLengthInputStream._read33431.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.ContentLengthInputStream._read33431 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "read", "([B)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, global::org.apache.http.impl.io.ContentLengthInputStream._read33431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skip33432;
		public override long skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.ContentLengthInputStream._skip33432.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.ContentLengthInputStream._skip33432 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "skip", "(J)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, global::org.apache.http.impl.io.ContentLengthInputStream._skip33432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ContentLengthInputStream33433;
		public ContentLengthInputStream(org.apache.http.io.SessionInputBuffer arg0, long arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.ContentLengthInputStream._ContentLengthInputStream33433.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.ContentLengthInputStream._ContentLengthInputStream33433 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionInputBuffer;J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.ContentLengthInputStream.staticClass, global::org.apache.http.impl.io.ContentLengthInputStream._ContentLengthInputStream33433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ContentLengthInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.ContentLengthInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/ContentLengthInputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
