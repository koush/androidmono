namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.OutputStream_))]
	public abstract partial class OutputStream : java.lang.Object, Closeable, Flushable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OutputStream()
		{
			InitJNI();
		}
		protected OutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write19234;
		public abstract void write(int arg0);
		internal static global::MonoJavaBridge.MethodId _write19235;
		public virtual void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStream._write19235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStream.staticClass, global::java.io.OutputStream._write19235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19236;
		public virtual void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStream._write19236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStream.staticClass, global::java.io.OutputStream._write19236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush19237;
		public virtual void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStream._flush19237);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStream.staticClass, global::java.io.OutputStream._flush19237);
		}
		internal static global::MonoJavaBridge.MethodId _close19238;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStream._close19238);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStream.staticClass, global::java.io.OutputStream._close19238);
		}
		internal static global::MonoJavaBridge.MethodId _OutputStream19239;
		public OutputStream()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStream.staticClass, global::java.io.OutputStream._OutputStream19239);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.OutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/OutputStream"));
			global::java.io.OutputStream._write19234 = @__env.GetMethodIDNoThrow(global::java.io.OutputStream.staticClass, "write", "(I)V");
			global::java.io.OutputStream._write19235 = @__env.GetMethodIDNoThrow(global::java.io.OutputStream.staticClass, "write", "([B)V");
			global::java.io.OutputStream._write19236 = @__env.GetMethodIDNoThrow(global::java.io.OutputStream.staticClass, "write", "([BII)V");
			global::java.io.OutputStream._flush19237 = @__env.GetMethodIDNoThrow(global::java.io.OutputStream.staticClass, "flush", "()V");
			global::java.io.OutputStream._close19238 = @__env.GetMethodIDNoThrow(global::java.io.OutputStream.staticClass, "close", "()V");
			global::java.io.OutputStream._OutputStream19239 = @__env.GetMethodIDNoThrow(global::java.io.OutputStream.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.OutputStream))]
	public sealed partial class OutputStream_ : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OutputStream_()
		{
			InitJNI();
		}
		internal OutputStream_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write19240;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStream_._write19240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStream_.staticClass, global::java.io.OutputStream_._write19240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.OutputStream_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/OutputStream"));
			global::java.io.OutputStream_._write19240 = @__env.GetMethodIDNoThrow(global::java.io.OutputStream_.staticClass, "write", "(I)V");
		}
	}
}
