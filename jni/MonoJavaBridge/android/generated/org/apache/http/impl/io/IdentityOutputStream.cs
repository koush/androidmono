namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IdentityOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IdentityOutputStream()
		{
			InitJNI();
		}
		protected IdentityOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write33457;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream._write33457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream.staticClass, global::org.apache.http.impl.io.IdentityOutputStream._write33457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write33458;
		public override void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream._write33458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream.staticClass, global::org.apache.http.impl.io.IdentityOutputStream._write33458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write33459;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream._write33459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream.staticClass, global::org.apache.http.impl.io.IdentityOutputStream._write33459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush33460;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream._flush33460);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream.staticClass, global::org.apache.http.impl.io.IdentityOutputStream._flush33460);
		}
		internal static global::MonoJavaBridge.MethodId _close33461;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream._close33461);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream.staticClass, global::org.apache.http.impl.io.IdentityOutputStream._close33461);
		}
		internal static global::MonoJavaBridge.MethodId _IdentityOutputStream33462;
		public IdentityOutputStream(org.apache.http.io.SessionOutputBuffer arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.IdentityOutputStream.staticClass, global::org.apache.http.impl.io.IdentityOutputStream._IdentityOutputStream33462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.IdentityOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/IdentityOutputStream"));
			global::org.apache.http.impl.io.IdentityOutputStream._write33457 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityOutputStream.staticClass, "write", "([BII)V");
			global::org.apache.http.impl.io.IdentityOutputStream._write33458 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityOutputStream.staticClass, "write", "([B)V");
			global::org.apache.http.impl.io.IdentityOutputStream._write33459 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityOutputStream.staticClass, "write", "(I)V");
			global::org.apache.http.impl.io.IdentityOutputStream._flush33460 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityOutputStream.staticClass, "flush", "()V");
			global::org.apache.http.impl.io.IdentityOutputStream._close33461 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityOutputStream.staticClass, "close", "()V");
			global::org.apache.http.impl.io.IdentityOutputStream._IdentityOutputStream33462 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityOutputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionOutputBuffer;)V");
		}
	}
}
