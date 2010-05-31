namespace java.io
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Reader : java.lang.Object, java.lang.Readable, Closeable
	{
		internal static global::java.lang.Class staticClass;
		static Reader()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.io.Reader), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Reader(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _close11455;
		public abstract void close();
		internal static global::net.sf.jni4net.jni.MethodId _mark11456;
		public virtual void mark(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.Reader._mark11456, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.Reader.staticClass, global::java.io.Reader._mark11456, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset11457;
		public virtual void reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.Reader._reset11457);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.Reader.staticClass, global::java.io.Reader._reset11457);
		}
		internal static global::net.sf.jni4net.jni.MethodId _read11458;
		public abstract int read(char[] arg0, int arg1, int arg2);
		internal static global::net.sf.jni4net.jni.MethodId _read11459;
		public virtual int read() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.io.Reader._read11459);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.io.Reader.staticClass, global::java.io.Reader._read11459);
		}
		internal static global::net.sf.jni4net.jni.MethodId _read11460;
		public virtual int read(char[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.io.Reader._read11460, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.io.Reader.staticClass, global::java.io.Reader._read11460, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _read11461;
		public virtual int read(java.nio.CharBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.io.Reader._read11461, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.io.Reader.staticClass, global::java.io.Reader._read11461, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _skip11462;
		public virtual long skip(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.io.Reader._skip11462, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.io.Reader.staticClass, global::java.io.Reader._skip11462, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _markSupported11463;
		public virtual bool markSupported() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.io.Reader._markSupported11463);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.io.Reader.staticClass, global::java.io.Reader._markSupported11463);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ready11464;
		public virtual bool ready() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.io.Reader._ready11464);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.io.Reader.staticClass, global::java.io.Reader._ready11464);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Reader11465;
		protected Reader()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.Reader.staticClass, global::java.io.Reader._Reader11465, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Reader11466;
		protected Reader(java.lang.Object arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.Reader.staticClass, global::java.io.Reader._Reader11466, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.io.Reader.staticClass = @__class;
			global::java.io.Reader._close11455 = @__env.GetMethodID(global::java.io.Reader.staticClass, "close", "()V");
			global::java.io.Reader._mark11456 = @__env.GetMethodID(global::java.io.Reader.staticClass, "mark", "(I)V");
			global::java.io.Reader._reset11457 = @__env.GetMethodID(global::java.io.Reader.staticClass, "reset", "()V");
			global::java.io.Reader._read11458 = @__env.GetMethodID(global::java.io.Reader.staticClass, "read", "([CII)I");
			global::java.io.Reader._read11459 = @__env.GetMethodID(global::java.io.Reader.staticClass, "read", "()I");
			global::java.io.Reader._read11460 = @__env.GetMethodID(global::java.io.Reader.staticClass, "read", "([C)I");
			global::java.io.Reader._read11461 = @__env.GetMethodID(global::java.io.Reader.staticClass, "read", "(Ljava/nio/CharBuffer;)I");
			global::java.io.Reader._skip11462 = @__env.GetMethodID(global::java.io.Reader.staticClass, "skip", "(J)J");
			global::java.io.Reader._markSupported11463 = @__env.GetMethodID(global::java.io.Reader.staticClass, "markSupported", "()Z");
			global::java.io.Reader._ready11464 = @__env.GetMethodID(global::java.io.Reader.staticClass, "ready", "()Z");
			global::java.io.Reader._Reader11465 = @__env.GetMethodID(global::java.io.Reader.staticClass, "<init>", "()V");
			global::java.io.Reader._Reader11466 = @__env.GetMethodID(global::java.io.Reader.staticClass, "<init>", "(Ljava/lang/Object;)V");
		}
	}
}
