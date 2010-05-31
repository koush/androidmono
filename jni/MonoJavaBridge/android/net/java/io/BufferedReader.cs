namespace java.io 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class BufferedReader : java.io.Reader
	{ 
		internal new static global::java.lang.Class staticClass; 
		static BufferedReader() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.io.BufferedReader), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.io.BufferedReader(@__env); 
			} 
		} 
		protected BufferedReader(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readLine11377; 
		public virtual global::java.lang.String readLine() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.BufferedReader._readLine11377)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._readLine11377)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close11378; 
		public override void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.io.BufferedReader._close11378); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._close11378); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mark11379; 
		public override void mark(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.io.BufferedReader._mark11379, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._mark11379, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset11380; 
		public override void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.io.BufferedReader._reset11380); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._reset11380); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read11381; 
		public override int read(char[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.io.BufferedReader._read11381, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._read11381, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read11382; 
		public override int read() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.io.BufferedReader._read11382); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._read11382); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _skip11383; 
		public override long skip(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::java.io.BufferedReader._skip11383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._skip11383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _markSupported11384; 
		public override bool markSupported() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.io.BufferedReader._markSupported11384); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._markSupported11384); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ready11385; 
		public override bool ready() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.io.BufferedReader._ready11385); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._ready11385); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BufferedReader11386; 
		public BufferedReader(java.io.Reader arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.BufferedReader.staticClass, global::java.io.BufferedReader._BufferedReader11386, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BufferedReader11387; 
		public BufferedReader(java.io.Reader arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.BufferedReader.staticClass, global::java.io.BufferedReader._BufferedReader11387, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.io.BufferedReader.staticClass = @__class; 
			global::java.io.BufferedReader._readLine11377 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "readLine", "()Ljava/lang/String;"); 
			global::java.io.BufferedReader._close11378 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "close", "()V"); 
			global::java.io.BufferedReader._mark11379 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "mark", "(I)V"); 
			global::java.io.BufferedReader._reset11380 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "reset", "()V"); 
			global::java.io.BufferedReader._read11381 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "read", "([CII)I"); 
			global::java.io.BufferedReader._read11382 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "read", "()I"); 
			global::java.io.BufferedReader._skip11383 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "skip", "(J)J"); 
			global::java.io.BufferedReader._markSupported11384 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "markSupported", "()Z"); 
			global::java.io.BufferedReader._ready11385 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "ready", "()Z"); 
			global::java.io.BufferedReader._BufferedReader11386 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "<init>", "(Ljava/io/Reader;I)V"); 
			global::java.io.BufferedReader._BufferedReader11387 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "<init>", "(Ljava/io/Reader;)V"); 
		} 
	} 
} 
