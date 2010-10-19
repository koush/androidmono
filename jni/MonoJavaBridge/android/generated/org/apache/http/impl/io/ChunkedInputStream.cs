namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ChunkedInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ChunkedInputStream()
		{
			InitJNI();
		}
		protected ChunkedInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close26665;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedInputStream._close26665);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedInputStream.staticClass, global::org.apache.http.impl.io.ChunkedInputStream._close26665);
		}
		internal static global::MonoJavaBridge.MethodId _read26666;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedInputStream._read26666);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedInputStream.staticClass, global::org.apache.http.impl.io.ChunkedInputStream._read26666);
		}
		internal static global::MonoJavaBridge.MethodId _read26667;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedInputStream._read26667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedInputStream.staticClass, global::org.apache.http.impl.io.ChunkedInputStream._read26667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read26668;
		public override int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedInputStream._read26668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedInputStream.staticClass, global::org.apache.http.impl.io.ChunkedInputStream._read26668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.Header[] Footers
		{
			get
			{
				return getFooters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFooters26669;
		public virtual global::org.apache.http.Header[] getFooters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedInputStream._getFooters26669)) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.ChunkedInputStream.staticClass, global::org.apache.http.impl.io.ChunkedInputStream._getFooters26669)) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _ChunkedInputStream26670;
		public ChunkedInputStream(org.apache.http.io.SessionInputBuffer arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.ChunkedInputStream.staticClass, global::org.apache.http.impl.io.ChunkedInputStream._ChunkedInputStream26670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.ChunkedInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/ChunkedInputStream"));
			global::org.apache.http.impl.io.ChunkedInputStream._close26665 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedInputStream.staticClass, "close", "()V");
			global::org.apache.http.impl.io.ChunkedInputStream._read26666 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedInputStream.staticClass, "read", "()I");
			global::org.apache.http.impl.io.ChunkedInputStream._read26667 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedInputStream.staticClass, "read", "([BII)I");
			global::org.apache.http.impl.io.ChunkedInputStream._read26668 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedInputStream.staticClass, "read", "([B)I");
			global::org.apache.http.impl.io.ChunkedInputStream._getFooters26669 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedInputStream.staticClass, "getFooters", "()[Lorg/apache/http/Header;");
			global::org.apache.http.impl.io.ChunkedInputStream._ChunkedInputStream26670 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ChunkedInputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionInputBuffer;)V");
		}
	}
}
