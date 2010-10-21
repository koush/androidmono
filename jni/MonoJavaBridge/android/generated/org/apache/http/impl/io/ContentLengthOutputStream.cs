namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentLengthOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentLengthOutputStream()
		{
			InitJNI();
		}
		protected ContentLengthOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write33315;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthOutputStream._write33315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, global::org.apache.http.impl.io.ContentLengthOutputStream._write33315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write33316;
		public override void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthOutputStream._write33316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, global::org.apache.http.impl.io.ContentLengthOutputStream._write33316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write33317;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthOutputStream._write33317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, global::org.apache.http.impl.io.ContentLengthOutputStream._write33317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush33318;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthOutputStream._flush33318);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, global::org.apache.http.impl.io.ContentLengthOutputStream._flush33318);
		}
		internal static global::MonoJavaBridge.MethodId _close33319;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthOutputStream._close33319);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, global::org.apache.http.impl.io.ContentLengthOutputStream._close33319);
		}
		internal static global::MonoJavaBridge.MethodId _ContentLengthOutputStream33320;
		public ContentLengthOutputStream(org.apache.http.io.SessionOutputBuffer arg0, long arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.ContentLengthOutputStream.staticClass, global::org.apache.http.impl.io.ContentLengthOutputStream._ContentLengthOutputStream33320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/ContentLengthOutputStream"));
			global::org.apache.http.impl.io.ContentLengthOutputStream._write33315 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "write", "([BII)V");
			global::org.apache.http.impl.io.ContentLengthOutputStream._write33316 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "write", "([B)V");
			global::org.apache.http.impl.io.ContentLengthOutputStream._write33317 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "write", "(I)V");
			global::org.apache.http.impl.io.ContentLengthOutputStream._flush33318 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "flush", "()V");
			global::org.apache.http.impl.io.ContentLengthOutputStream._close33319 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "close", "()V");
			global::org.apache.http.impl.io.ContentLengthOutputStream._ContentLengthOutputStream33320 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthOutputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionOutputBuffer;J)V");
		}
	}
}
