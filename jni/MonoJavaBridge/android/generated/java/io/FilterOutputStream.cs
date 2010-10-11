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
		internal static global::MonoJavaBridge.MethodId _write12591;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream._write12591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream.staticClass, global::java.io.FilterOutputStream._write12591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write12592;
		public override void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream._write12592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream.staticClass, global::java.io.FilterOutputStream._write12592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write12593;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream._write12593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream.staticClass, global::java.io.FilterOutputStream._write12593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush12594;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream._flush12594);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream.staticClass, global::java.io.FilterOutputStream._flush12594);
		}
		internal static global::MonoJavaBridge.MethodId _close12595;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream._close12595);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterOutputStream.staticClass, global::java.io.FilterOutputStream._close12595);
		}
		internal static global::MonoJavaBridge.MethodId _FilterOutputStream12596;
		public FilterOutputStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilterOutputStream.staticClass, global::java.io.FilterOutputStream._FilterOutputStream12596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterOutputStream"));
			global::java.io.FilterOutputStream._write12591 = @__env.GetMethodIDNoThrow(global::java.io.FilterOutputStream.staticClass, "write", "(I)V");
			global::java.io.FilterOutputStream._write12592 = @__env.GetMethodIDNoThrow(global::java.io.FilterOutputStream.staticClass, "write", "([B)V");
			global::java.io.FilterOutputStream._write12593 = @__env.GetMethodIDNoThrow(global::java.io.FilterOutputStream.staticClass, "write", "([BII)V");
			global::java.io.FilterOutputStream._flush12594 = @__env.GetMethodIDNoThrow(global::java.io.FilterOutputStream.staticClass, "flush", "()V");
			global::java.io.FilterOutputStream._close12595 = @__env.GetMethodIDNoThrow(global::java.io.FilterOutputStream.staticClass, "close", "()V");
			global::java.io.FilterOutputStream._FilterOutputStream12596 = @__env.GetMethodIDNoThrow(global::java.io.FilterOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
