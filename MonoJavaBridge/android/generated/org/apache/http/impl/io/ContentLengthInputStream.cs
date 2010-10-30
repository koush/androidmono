namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentLengthInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentLengthInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "close", "()V", ref global::org.apache.http.impl.io.ContentLengthInputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "read", "()I", ref global::org.apache.http.impl.io.ContentLengthInputStream._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "read", "([BII)I", ref global::org.apache.http.impl.io.ContentLengthInputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "read", "([B)I", ref global::org.apache.http.impl.io.ContentLengthInputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "skip", "(J)J", ref global::org.apache.http.impl.io.ContentLengthInputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ContentLengthInputStream(org.apache.http.io.SessionInputBuffer arg0, long arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.ContentLengthInputStream._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.ContentLengthInputStream._m5 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionInputBuffer;J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.ContentLengthInputStream.staticClass, global::org.apache.http.impl.io.ContentLengthInputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
