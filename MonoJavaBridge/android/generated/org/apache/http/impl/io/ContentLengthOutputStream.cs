namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentLengthOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentLengthOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "write", "([BII)V", ref global::org.apache.http.impl.io.ContentLengthOutputStream._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "write", "([B)V", ref global::org.apache.http.impl.io.ContentLengthOutputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "write", "(I)V", ref global::org.apache.http.impl.io.ContentLengthOutputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "flush", "()V", ref global::org.apache.http.impl.io.ContentLengthOutputStream._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "close", "()V", ref global::org.apache.http.impl.io.ContentLengthOutputStream._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ContentLengthOutputStream(org.apache.http.io.SessionOutputBuffer arg0, long arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.ContentLengthOutputStream._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.ContentLengthOutputStream._m5 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionOutputBuffer;J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.ContentLengthOutputStream.staticClass, global::org.apache.http.impl.io.ContentLengthOutputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ContentLengthOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/ContentLengthOutputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
