namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ChunkedInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ChunkedInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close33411;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.ChunkedInputStream.staticClass, "close", "()V", ref global::org.apache.http.impl.io.ChunkedInputStream._close33411);
		}
		internal static global::MonoJavaBridge.MethodId _read33412;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.ChunkedInputStream.staticClass, "read", "()I", ref global::org.apache.http.impl.io.ChunkedInputStream._read33412);
		}
		internal static global::MonoJavaBridge.MethodId _read33413;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.ChunkedInputStream.staticClass, "read", "([BII)I", ref global::org.apache.http.impl.io.ChunkedInputStream._read33413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read33414;
		public override int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.io.ChunkedInputStream.staticClass, "read", "([B)I", ref global::org.apache.http.impl.io.ChunkedInputStream._read33414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.Header[] Footers
		{
			get
			{
				return getFooters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFooters33415;
		public virtual global::org.apache.http.Header[] getFooters()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.Header>(this, global::org.apache.http.impl.io.ChunkedInputStream.staticClass, "getFooters", "()[Lorg/apache/http/Header;", ref global::org.apache.http.impl.io.ChunkedInputStream._getFooters33415) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _ChunkedInputStream33416;
		public ChunkedInputStream(org.apache.http.io.SessionInputBuffer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.ChunkedInputStream._ChunkedInputStream33416.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.ChunkedInputStream._ChunkedInputStream33416 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedInputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionInputBuffer;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.ChunkedInputStream.staticClass, global::org.apache.http.impl.io.ChunkedInputStream._ChunkedInputStream33416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ChunkedInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.ChunkedInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/ChunkedInputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
