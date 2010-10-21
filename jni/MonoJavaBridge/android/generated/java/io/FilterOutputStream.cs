namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FilterOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FilterOutputStream()
		{
			InitJNI();
		}
		protected FilterOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write18950;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream._write18950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream.staticClass, global::java.io.FilterOutputStream._write18950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write18951;
		public override void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream._write18951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream.staticClass, global::java.io.FilterOutputStream._write18951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write18952;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream._write18952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream.staticClass, global::java.io.FilterOutputStream._write18952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush18953;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream._flush18953);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream.staticClass, global::java.io.FilterOutputStream._flush18953);
		}
		internal static global::MonoJavaBridge.MethodId _close18954;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream._close18954);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream.staticClass, global::java.io.FilterOutputStream._close18954);
		}
		internal static global::MonoJavaBridge.MethodId _FilterOutputStream18955;
		public FilterOutputStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilterOutputStream.staticClass, global::java.io.FilterOutputStream._FilterOutputStream18955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterOutputStream"));
			global::java.io.FilterOutputStream._write18950 = @__env.GetMethodIDNoThrow(global::java.io.FilterOutputStream.staticClass, "write", "(I)V");
			global::java.io.FilterOutputStream._write18951 = @__env.GetMethodIDNoThrow(global::java.io.FilterOutputStream.staticClass, "write", "([B)V");
			global::java.io.FilterOutputStream._write18952 = @__env.GetMethodIDNoThrow(global::java.io.FilterOutputStream.staticClass, "write", "([BII)V");
			global::java.io.FilterOutputStream._flush18953 = @__env.GetMethodIDNoThrow(global::java.io.FilterOutputStream.staticClass, "flush", "()V");
			global::java.io.FilterOutputStream._close18954 = @__env.GetMethodIDNoThrow(global::java.io.FilterOutputStream.staticClass, "close", "()V");
			global::java.io.FilterOutputStream._FilterOutputStream18955 = @__env.GetMethodIDNoThrow(global::java.io.FilterOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
