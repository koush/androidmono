namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.InputStream_))]
	public abstract partial class InputStream : java.lang.Object, Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputStream()
		{
			InitJNI();
		}
		protected InputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19094;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.InputStream._close19094);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._close19094);
		}
		internal static global::MonoJavaBridge.MethodId _mark19095;
		public virtual void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.InputStream._mark19095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._mark19095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19096;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.InputStream._reset19096);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._reset19096);
		}
		internal static global::MonoJavaBridge.MethodId _read19097;
		public virtual int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.InputStream._read19097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._read19097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read19098;
		public virtual int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.InputStream._read19098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._read19098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read19099;
		public abstract int read();
		internal static global::MonoJavaBridge.MethodId _skip19100;
		public virtual long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.InputStream._skip19100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._skip19100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available19101;
		public virtual int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.InputStream._available19101);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._available19101);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported19102;
		public virtual bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.InputStream._markSupported19102);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._markSupported19102);
		}
		internal static global::MonoJavaBridge.MethodId _InputStream19103;
		public InputStream()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStream.staticClass, global::java.io.InputStream._InputStream19103);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InputStream"));
			global::java.io.InputStream._close19094 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "close", "()V");
			global::java.io.InputStream._mark19095 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "mark", "(I)V");
			global::java.io.InputStream._reset19096 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "reset", "()V");
			global::java.io.InputStream._read19097 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "read", "([BII)I");
			global::java.io.InputStream._read19098 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "read", "([B)I");
			global::java.io.InputStream._read19099 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "read", "()I");
			global::java.io.InputStream._skip19100 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "skip", "(J)J");
			global::java.io.InputStream._available19101 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "available", "()I");
			global::java.io.InputStream._markSupported19102 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "markSupported", "()Z");
			global::java.io.InputStream._InputStream19103 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.InputStream))]
	internal sealed partial class InputStream_ : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputStream_()
		{
			InitJNI();
		}
		internal InputStream_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _read19104;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.InputStream_._read19104);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.InputStream_.staticClass, global::java.io.InputStream_._read19104);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InputStream_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InputStream"));
			global::java.io.InputStream_._read19104 = @__env.GetMethodIDNoThrow(global::java.io.InputStream_.staticClass, "read", "()I");
		}
	}
}
