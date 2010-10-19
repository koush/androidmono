namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IdentityInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IdentityInputStream()
		{
			InitJNI();
		}
		protected IdentityInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close26707;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityInputStream._close26707);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityInputStream.staticClass, global::org.apache.http.impl.io.IdentityInputStream._close26707);
		}
		internal static global::MonoJavaBridge.MethodId _read26708;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityInputStream._read26708);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityInputStream.staticClass, global::org.apache.http.impl.io.IdentityInputStream._read26708);
		}
		internal static global::MonoJavaBridge.MethodId _read26709;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityInputStream._read26709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityInputStream.staticClass, global::org.apache.http.impl.io.IdentityInputStream._read26709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _available26710;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityInputStream._available26710);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityInputStream.staticClass, global::org.apache.http.impl.io.IdentityInputStream._available26710);
		}
		internal static global::MonoJavaBridge.MethodId _IdentityInputStream26711;
		public IdentityInputStream(org.apache.http.io.SessionInputBuffer arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.IdentityInputStream.staticClass, global::org.apache.http.impl.io.IdentityInputStream._IdentityInputStream26711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.IdentityInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/IdentityInputStream"));
			global::org.apache.http.impl.io.IdentityInputStream._close26707 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityInputStream.staticClass, "close", "()V");
			global::org.apache.http.impl.io.IdentityInputStream._read26708 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityInputStream.staticClass, "read", "()I");
			global::org.apache.http.impl.io.IdentityInputStream._read26709 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityInputStream.staticClass, "read", "([BII)I");
			global::org.apache.http.impl.io.IdentityInputStream._available26710 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityInputStream.staticClass, "available", "()I");
			global::org.apache.http.impl.io.IdentityInputStream._IdentityInputStream26711 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityInputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionInputBuffer;)V");
		}
	}
}
