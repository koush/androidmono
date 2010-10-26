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
		internal static global::MonoJavaBridge.MethodId _write19352;
		public abstract void write(int arg0);
		internal static global::MonoJavaBridge.MethodId _write19353;
		public virtual void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStream._write19353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStream.staticClass, global::java.io.OutputStream._write19353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19354;
		public virtual void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStream._write19354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStream.staticClass, global::java.io.OutputStream._write19354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush19355;
		public virtual void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStream._flush19355);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStream.staticClass, global::java.io.OutputStream._flush19355);
		}
		internal static global::MonoJavaBridge.MethodId _close19356;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStream._close19356);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStream.staticClass, global::java.io.OutputStream._close19356);
		}
		internal static global::MonoJavaBridge.MethodId _OutputStream19357;
		public OutputStream()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStream.staticClass, global::java.io.OutputStream._OutputStream19357);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.OutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/OutputStream"));
			global::java.io.OutputStream._write19352 = @__env.GetMethodIDNoThrow(global::java.io.OutputStream.staticClass, "write", "(I)V");
			global::java.io.OutputStream._write19353 = @__env.GetMethodIDNoThrow(global::java.io.OutputStream.staticClass, "write", "([B)V");
			global::java.io.OutputStream._write19354 = @__env.GetMethodIDNoThrow(global::java.io.OutputStream.staticClass, "write", "([BII)V");
			global::java.io.OutputStream._flush19355 = @__env.GetMethodIDNoThrow(global::java.io.OutputStream.staticClass, "flush", "()V");
			global::java.io.OutputStream._close19356 = @__env.GetMethodIDNoThrow(global::java.io.OutputStream.staticClass, "close", "()V");
			global::java.io.OutputStream._OutputStream19357 = @__env.GetMethodIDNoThrow(global::java.io.OutputStream.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.OutputStream))]
	internal sealed partial class OutputStream_ : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OutputStream_()
		{
			InitJNI();
		}
		internal OutputStream_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write19358;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStream_._write19358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStream_.staticClass, global::java.io.OutputStream_._write19358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.OutputStream_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/OutputStream"));
			global::java.io.OutputStream_._write19358 = @__env.GetMethodIDNoThrow(global::java.io.OutputStream_.staticClass, "write", "(I)V");
		}
	}
}
