namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentLengthOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentLengthOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write33434;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, global::org.apache.http.impl.io.ContentLengthOutputStream._write33434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write33435;
		public override void write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, global::org.apache.http.impl.io.ContentLengthOutputStream._write33435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write33436;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, global::org.apache.http.impl.io.ContentLengthOutputStream._write33436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush33437;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, global::org.apache.http.impl.io.ContentLengthOutputStream._flush33437);
		}
		internal static global::MonoJavaBridge.MethodId _close33438;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, global::org.apache.http.impl.io.ContentLengthOutputStream._close33438);
		}
		internal static global::MonoJavaBridge.MethodId _ContentLengthOutputStream33439;
		public ContentLengthOutputStream(org.apache.http.io.SessionOutputBuffer arg0, long arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.ContentLengthOutputStream.staticClass, global::org.apache.http.impl.io.ContentLengthOutputStream._ContentLengthOutputStream33439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ContentLengthOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/ContentLengthOutputStream"));
			global::org.apache.http.impl.io.ContentLengthOutputStream._write33434 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "write", "([BII)V");
			global::org.apache.http.impl.io.ContentLengthOutputStream._write33435 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "write", "([B)V");
			global::org.apache.http.impl.io.ContentLengthOutputStream._write33436 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "write", "(I)V");
			global::org.apache.http.impl.io.ContentLengthOutputStream._flush33437 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "flush", "()V");
			global::org.apache.http.impl.io.ContentLengthOutputStream._close33438 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "close", "()V");
			global::org.apache.http.impl.io.ContentLengthOutputStream._ContentLengthOutputStream33439 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionOutputBuffer;J)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
