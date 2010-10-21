namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SequenceInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SequenceInputStream()
		{
			InitJNI();
		}
		protected SequenceInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19449;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.SequenceInputStream._close19449);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.SequenceInputStream.staticClass, global::java.io.SequenceInputStream._close19449);
		}
		internal static global::MonoJavaBridge.MethodId _read19450;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.SequenceInputStream._read19450);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.SequenceInputStream.staticClass, global::java.io.SequenceInputStream._read19450);
		}
		internal static global::MonoJavaBridge.MethodId _read19451;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.SequenceInputStream._read19451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.SequenceInputStream.staticClass, global::java.io.SequenceInputStream._read19451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _available19452;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.SequenceInputStream._available19452);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.SequenceInputStream.staticClass, global::java.io.SequenceInputStream._available19452);
		}
		internal static global::MonoJavaBridge.MethodId _SequenceInputStream19453;
		public SequenceInputStream(java.util.Enumeration arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.SequenceInputStream.staticClass, global::java.io.SequenceInputStream._SequenceInputStream19453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SequenceInputStream19454;
		public SequenceInputStream(java.io.InputStream arg0, java.io.InputStream arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.SequenceInputStream.staticClass, global::java.io.SequenceInputStream._SequenceInputStream19454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.SequenceInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/SequenceInputStream"));
			global::java.io.SequenceInputStream._close19449 = @__env.GetMethodIDNoThrow(global::java.io.SequenceInputStream.staticClass, "close", "()V");
			global::java.io.SequenceInputStream._read19450 = @__env.GetMethodIDNoThrow(global::java.io.SequenceInputStream.staticClass, "read", "()I");
			global::java.io.SequenceInputStream._read19451 = @__env.GetMethodIDNoThrow(global::java.io.SequenceInputStream.staticClass, "read", "([BII)I");
			global::java.io.SequenceInputStream._available19452 = @__env.GetMethodIDNoThrow(global::java.io.SequenceInputStream.staticClass, "available", "()I");
			global::java.io.SequenceInputStream._SequenceInputStream19453 = @__env.GetMethodIDNoThrow(global::java.io.SequenceInputStream.staticClass, "<init>", "(Ljava/util/Enumeration;)V");
			global::java.io.SequenceInputStream._SequenceInputStream19454 = @__env.GetMethodIDNoThrow(global::java.io.SequenceInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/io/InputStream;)V");
		}
	}
}
