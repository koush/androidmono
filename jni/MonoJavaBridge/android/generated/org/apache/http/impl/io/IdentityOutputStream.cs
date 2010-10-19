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
		internal static global::MonoJavaBridge.MethodId _write26712;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream._write26712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream.staticClass, global::org.apache.http.impl.io.IdentityOutputStream._write26712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write26713;
		public override void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream._write26713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream.staticClass, global::org.apache.http.impl.io.IdentityOutputStream._write26713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write26714;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream._write26714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream.staticClass, global::org.apache.http.impl.io.IdentityOutputStream._write26714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush26715;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream._flush26715);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream.staticClass, global::org.apache.http.impl.io.IdentityOutputStream._flush26715);
		}
		internal static global::MonoJavaBridge.MethodId _close26716;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream._close26716);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.IdentityOutputStream.staticClass, global::org.apache.http.impl.io.IdentityOutputStream._close26716);
		}
		internal static global::MonoJavaBridge.MethodId _IdentityOutputStream26717;
		public IdentityOutputStream(org.apache.http.io.SessionOutputBuffer arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.IdentityOutputStream.staticClass, global::org.apache.http.impl.io.IdentityOutputStream._IdentityOutputStream26717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.IdentityOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/IdentityOutputStream"));
			global::org.apache.http.impl.io.IdentityOutputStream._write26712 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityOutputStream.staticClass, "write", "([BII)V");
			global::org.apache.http.impl.io.IdentityOutputStream._write26713 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityOutputStream.staticClass, "write", "([B)V");
			global::org.apache.http.impl.io.IdentityOutputStream._write26714 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityOutputStream.staticClass, "write", "(I)V");
			global::org.apache.http.impl.io.IdentityOutputStream._flush26715 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityOutputStream.staticClass, "flush", "()V");
			global::org.apache.http.impl.io.IdentityOutputStream._close26716 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityOutputStream.staticClass, "close", "()V");
			global::org.apache.http.impl.io.IdentityOutputStream._IdentityOutputStream26717 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.IdentityOutputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionOutputBuffer;)V");
		}
	}
}
