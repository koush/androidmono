namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.Reader_))]
	public abstract partial class Reader : java.lang.Object, java.lang.Readable, Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Reader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19553;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _mark19554;
		public virtual void mark(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Reader._mark19554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._mark19554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19555;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Reader._reset19555);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._reset19555);
		}
		internal static global::MonoJavaBridge.MethodId _read19556;
		public abstract int read(char[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read19557;
		public virtual int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.Reader._read19557);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._read19557);
		}
		internal static global::MonoJavaBridge.MethodId _read19558;
		public virtual int read(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.Reader._read19558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._read19558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read19559;
		public virtual int read(java.nio.CharBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.Reader._read19559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._read19559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skip19560;
		public virtual long skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.Reader._skip19560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._skip19560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported19561;
		public virtual bool markSupported()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.Reader._markSupported19561);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._markSupported19561);
		}
		internal static global::MonoJavaBridge.MethodId _ready19562;
		public virtual bool ready()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.Reader._ready19562);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.Reader.staticClass, global::java.io.Reader._ready19562);
		}
		internal static global::MonoJavaBridge.MethodId _Reader19563;
		protected Reader() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Reader.staticClass, global::java.io.Reader._Reader19563);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Reader19564;
		protected Reader(java.lang.Object arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Reader.staticClass, global::java.io.Reader._Reader19564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Reader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Reader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Reader"));
			global::java.io.Reader._close19553 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "close", "()V");
			global::java.io.Reader._mark19554 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "mark", "(I)V");
			global::java.io.Reader._reset19555 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "reset", "()V");
			global::java.io.Reader._read19556 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "read", "([CII)I");
			global::java.io.Reader._read19557 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "read", "()I");
			global::java.io.Reader._read19558 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "read", "([C)I");
			global::java.io.Reader._read19559 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "read", "(Ljava/nio/CharBuffer;)I");
			global::java.io.Reader._skip19560 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "skip", "(J)J");
			global::java.io.Reader._markSupported19561 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "markSupported", "()Z");
			global::java.io.Reader._ready19562 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "ready", "()Z");
			global::java.io.Reader._Reader19563 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "<init>", "()V");
			global::java.io.Reader._Reader19564 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "<init>", "(Ljava/lang/Object;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.Reader))]
	internal sealed partial class Reader_ : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Reader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19565;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Reader_._close19565);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Reader_.staticClass, global::java.io.Reader_._close19565);
		}
		internal static global::MonoJavaBridge.MethodId _read19566;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.Reader_._read19566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.Reader_.staticClass, global::java.io.Reader_._read19566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static Reader_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Reader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Reader"));
			global::java.io.Reader_._close19565 = @__env.GetMethodIDNoThrow(global::java.io.Reader_.staticClass, "close", "()V");
			global::java.io.Reader_._read19566 = @__env.GetMethodIDNoThrow(global::java.io.Reader_.staticClass, "read", "([CII)I");
		}
		internal static void InitJNI()
		{
		}
	}
}
