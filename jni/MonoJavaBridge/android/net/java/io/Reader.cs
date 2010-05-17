namespace java.io 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Reader : java.lang.Object, java.lang.Readable, Closeable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Reader() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.io.Reader), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Reader(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close10632; 
		public abstract void close(); 
		internal static global::net.sf.jni4net.jni.MethodId _mark10633; 
		public virtual void mark(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.Reader)) 
				@__env.CallVoidMethod(this, _mark10633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.Reader.staticClass, _mark10633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset10634; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.Reader)) 
				@__env.CallVoidMethod(this, _reset10634); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.Reader.staticClass, _reset10634); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read10635; 
		public abstract int read(char[] arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _read10636; 
		public virtual int read() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.Reader)) 
				return @__env.CallIntMethod(this, _read10636); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.io.Reader.staticClass, _read10636); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read10637; 
		public virtual int read(char[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.Reader)) 
				return @__env.CallIntMethod(this, _read10637, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.io.Reader.staticClass, _read10637, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read10638; 
		public virtual int read(java.nio.CharBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.Reader)) 
				return @__env.CallIntMethod(this, _read10638, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.io.Reader.staticClass, _read10638, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _skip10639; 
		public virtual long skip(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.Reader)) 
				return @__env.CallLongMethod(this, _skip10639, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.io.Reader.staticClass, _skip10639, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _markSupported10640; 
		public virtual bool markSupported() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.Reader)) 
				return @__env.CallBooleanMethod(this, _markSupported10640); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.io.Reader.staticClass, _markSupported10640); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ready10641; 
		public virtual bool ready() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.Reader)) 
				return @__env.CallBooleanMethod(this, _ready10641); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.io.Reader.staticClass, _ready10641); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Reader10642; 
		protected Reader()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.Reader.staticClass, _Reader10642, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Reader10643; 
		protected Reader(java.lang.Object arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.Reader.staticClass, _Reader10643, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.io.Reader.staticClass = @__class; 
			global::java.io.Reader._close10632 = @__env.GetMethodID(global::java.io.Reader.staticClass, "close", "()V"); 
			global::java.io.Reader._mark10633 = @__env.GetMethodID(global::java.io.Reader.staticClass, "mark", "(I)V"); 
			global::java.io.Reader._reset10634 = @__env.GetMethodID(global::java.io.Reader.staticClass, "reset", "()V"); 
			global::java.io.Reader._read10635 = @__env.GetMethodID(global::java.io.Reader.staticClass, "read", "([CII)I"); 
			global::java.io.Reader._read10636 = @__env.GetMethodID(global::java.io.Reader.staticClass, "read", "()I"); 
			global::java.io.Reader._read10637 = @__env.GetMethodID(global::java.io.Reader.staticClass, "read", "([C)I"); 
			global::java.io.Reader._read10638 = @__env.GetMethodID(global::java.io.Reader.staticClass, "read", "(Ljava/nio/CharBuffer;)I"); 
			global::java.io.Reader._skip10639 = @__env.GetMethodID(global::java.io.Reader.staticClass, "skip", "(J)J"); 
			global::java.io.Reader._markSupported10640 = @__env.GetMethodID(global::java.io.Reader.staticClass, "markSupported", "()Z"); 
			global::java.io.Reader._ready10641 = @__env.GetMethodID(global::java.io.Reader.staticClass, "ready", "()Z"); 
			global::java.io.Reader._Reader10642 = @__env.GetMethodID(global::java.io.Reader.staticClass, "<init>", "()V"); 
			global::java.io.Reader._Reader10643 = @__env.GetMethodID(global::java.io.Reader.staticClass, "<init>", "(Ljava/lang/Object;)V"); 
		} 
	} 
} 
