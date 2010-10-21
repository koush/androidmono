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
		internal static global::MonoJavaBridge.MethodId _close18976;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.InputStream._close18976);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._close18976);
		}
		internal static global::MonoJavaBridge.MethodId _mark18977;
		public virtual void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.InputStream._mark18977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._mark18977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset18978;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.InputStream._reset18978);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._reset18978);
		}
		internal static global::MonoJavaBridge.MethodId _read18979;
		public virtual int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.InputStream._read18979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._read18979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read18980;
		public virtual int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.InputStream._read18980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._read18980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read18981;
		public abstract int read();
		internal static global::MonoJavaBridge.MethodId _skip18982;
		public virtual long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.InputStream._skip18982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._skip18982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available18983;
		public virtual int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.InputStream._available18983);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._available18983);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported18984;
		public virtual bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.InputStream._markSupported18984);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._markSupported18984);
		}
		internal static global::MonoJavaBridge.MethodId _InputStream18985;
		public InputStream()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStream.staticClass, global::java.io.InputStream._InputStream18985);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InputStream"));
			global::java.io.InputStream._close18976 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "close", "()V");
			global::java.io.InputStream._mark18977 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "mark", "(I)V");
			global::java.io.InputStream._reset18978 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "reset", "()V");
			global::java.io.InputStream._read18979 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "read", "([BII)I");
			global::java.io.InputStream._read18980 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "read", "([B)I");
			global::java.io.InputStream._read18981 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "read", "()I");
			global::java.io.InputStream._skip18982 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "skip", "(J)J");
			global::java.io.InputStream._available18983 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "available", "()I");
			global::java.io.InputStream._markSupported18984 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "markSupported", "()Z");
			global::java.io.InputStream._InputStream18985 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.InputStream))]
	public sealed partial class InputStream_ : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputStream_()
		{
			InitJNI();
		}
		internal InputStream_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _read18986;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.InputStream_._read18986);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.InputStream_.staticClass, global::java.io.InputStream_._read18986);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InputStream_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InputStream"));
			global::java.io.InputStream_._read18986 = @__env.GetMethodIDNoThrow(global::java.io.InputStream_.staticClass, "read", "()I");
		}
	}
}
