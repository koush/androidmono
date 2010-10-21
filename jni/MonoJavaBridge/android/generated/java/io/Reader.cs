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
		internal static global::MonoJavaBridge.MethodId _close19435;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _mark19436;
		public virtual void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Reader._mark19436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._mark19436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19437;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Reader._reset19437);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._reset19437);
		}
		internal static global::MonoJavaBridge.MethodId _read19438;
		public abstract int read(char[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read19439;
		public virtual int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.Reader._read19439);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._read19439);
		}
		internal static global::MonoJavaBridge.MethodId _read19440;
		public virtual int read(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.Reader._read19440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._read19440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read19441;
		public virtual int read(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.Reader._read19441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._read19441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skip19442;
		public virtual long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.Reader._skip19442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._skip19442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported19443;
		public virtual bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.Reader._markSupported19443);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._markSupported19443);
		}
		internal static global::MonoJavaBridge.MethodId _ready19444;
		public virtual bool ready() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.Reader._ready19444);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._ready19444);
		}
		internal static global::MonoJavaBridge.MethodId _Reader19445;
		protected Reader()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Reader.staticClass, global::java.io.Reader._Reader19445);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Reader19446;
		protected Reader(java.lang.Object arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Reader.staticClass, global::java.io.Reader._Reader19446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Reader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Reader"));
			global::java.io.Reader._close19435 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "close", "()V");
			global::java.io.Reader._mark19436 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "mark", "(I)V");
			global::java.io.Reader._reset19437 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "reset", "()V");
			global::java.io.Reader._read19438 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "read", "([CII)I");
			global::java.io.Reader._read19439 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "read", "()I");
			global::java.io.Reader._read19440 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "read", "([C)I");
			global::java.io.Reader._read19441 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "read", "(Ljava/nio/CharBuffer;)I");
			global::java.io.Reader._skip19442 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "skip", "(J)J");
			global::java.io.Reader._markSupported19443 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "markSupported", "()Z");
			global::java.io.Reader._ready19444 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "ready", "()Z");
			global::java.io.Reader._Reader19445 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "<init>", "()V");
			global::java.io.Reader._Reader19446 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "<init>", "(Ljava/lang/Object;)V");
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
		internal static global::MonoJavaBridge.MethodId _close19447;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Reader_._close19447);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Reader_.staticClass, global::java.io.Reader_._close19447);
		}
		internal static global::MonoJavaBridge.MethodId _read19448;
		public override int read(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.Reader_._read19448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.Reader_.staticClass, global::java.io.Reader_._read19448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Reader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Reader"));
			global::java.io.Reader_._close19447 = @__env.GetMethodIDNoThrow(global::java.io.Reader_.staticClass, "close", "()V");
			global::java.io.Reader_._read19448 = @__env.GetMethodIDNoThrow(global::java.io.Reader_.staticClass, "read", "([CII)I");
		}
	}
}
