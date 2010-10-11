namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.Reader_))]
	public abstract partial class Reader : java.lang.Object, java.lang.Readable, Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Reader()
		{
			InitJNI();
		}
		protected Reader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close12704;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _mark12705;
		public virtual void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Reader._mark12705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._mark12705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset12706;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Reader._reset12706);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._reset12706);
		}
		internal static global::MonoJavaBridge.MethodId _read12707;
		public abstract int read(char[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read12708;
		public virtual int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.Reader._read12708);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._read12708);
		}
		internal static global::MonoJavaBridge.MethodId _read12709;
		public virtual int read(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.Reader._read12709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._read12709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read12710;
		public virtual int read(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.Reader._read12710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._read12710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skip12711;
		public virtual long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.Reader._skip12711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._skip12711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported12712;
		public virtual bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.Reader._markSupported12712);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._markSupported12712);
		}
		internal static global::MonoJavaBridge.MethodId _ready12713;
		public virtual bool ready() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.Reader._ready12713);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._ready12713);
		}
		internal static global::MonoJavaBridge.MethodId _Reader12714;
		protected Reader()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Reader.staticClass, global::java.io.Reader._Reader12714);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Reader12715;
		protected Reader(java.lang.Object arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Reader.staticClass, global::java.io.Reader._Reader12715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Reader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Reader"));
			global::java.io.Reader._close12704 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "close", "()V");
			global::java.io.Reader._mark12705 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "mark", "(I)V");
			global::java.io.Reader._reset12706 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "reset", "()V");
			global::java.io.Reader._read12707 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "read", "([CII)I");
			global::java.io.Reader._read12708 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "read", "()I");
			global::java.io.Reader._read12709 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "read", "([C)I");
			global::java.io.Reader._read12710 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "read", "(Ljava/nio/CharBuffer;)I");
			global::java.io.Reader._skip12711 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "skip", "(J)J");
			global::java.io.Reader._markSupported12712 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "markSupported", "()Z");
			global::java.io.Reader._ready12713 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "ready", "()Z");
			global::java.io.Reader._Reader12714 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "<init>", "()V");
			global::java.io.Reader._Reader12715 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "<init>", "(Ljava/lang/Object;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.Reader))]
	public sealed partial class Reader_ : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Reader_()
		{
			InitJNI();
		}
		internal Reader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close12716;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Reader_._close12716);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Reader_.staticClass, global::java.io.Reader_._close12716);
		}
		internal static global::MonoJavaBridge.MethodId _read12717;
		public override int read(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.Reader_._read12717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.Reader_.staticClass, global::java.io.Reader_._read12717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Reader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Reader"));
			global::java.io.Reader_._close12716 = @__env.GetMethodIDNoThrow(global::java.io.Reader_.staticClass, "close", "()V");
			global::java.io.Reader_._read12717 = @__env.GetMethodIDNoThrow(global::java.io.Reader_.staticClass, "read", "([CII)I");
		}
	}
}
