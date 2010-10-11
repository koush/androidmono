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
		internal static global::MonoJavaBridge.MethodId _close12602;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.InputStream._close12602);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._close12602);
		}
		internal static global::MonoJavaBridge.MethodId _mark12603;
		public virtual void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.InputStream._mark12603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._mark12603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset12604;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.InputStream._reset12604);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._reset12604);
		}
		internal static global::MonoJavaBridge.MethodId _read12605;
		public virtual int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.InputStream._read12605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._read12605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read12606;
		public virtual int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.InputStream._read12606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._read12606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read12607;
		public abstract int read();
		internal static global::MonoJavaBridge.MethodId _skip12608;
		public virtual long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.InputStream._skip12608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._skip12608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available12609;
		public virtual int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.InputStream._available12609);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._available12609);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported12610;
		public virtual bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.InputStream._markSupported12610);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.InputStream.staticClass, global::java.io.InputStream._markSupported12610);
		}
		internal static global::MonoJavaBridge.MethodId _InputStream12611;
		public InputStream()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStream.staticClass, global::java.io.InputStream._InputStream12611);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InputStream"));
			global::java.io.InputStream._close12602 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "close", "()V");
			global::java.io.InputStream._mark12603 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "mark", "(I)V");
			global::java.io.InputStream._reset12604 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "reset", "()V");
			global::java.io.InputStream._read12605 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "read", "([BII)I");
			global::java.io.InputStream._read12606 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "read", "([B)I");
			global::java.io.InputStream._read12607 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "read", "()I");
			global::java.io.InputStream._skip12608 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "skip", "(J)J");
			global::java.io.InputStream._available12609 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "available", "()I");
			global::java.io.InputStream._markSupported12610 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "markSupported", "()Z");
			global::java.io.InputStream._InputStream12611 = @__env.GetMethodIDNoThrow(global::java.io.InputStream.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _read12612;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.InputStream_._read12612);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.InputStream_.staticClass, global::java.io.InputStream_._read12612);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InputStream_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InputStream"));
			global::java.io.InputStream_._read12612 = @__env.GetMethodIDNoThrow(global::java.io.InputStream_.staticClass, "read", "()I");
		}
	}
}
