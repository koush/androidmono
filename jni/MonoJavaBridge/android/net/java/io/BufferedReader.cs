namespace java.io 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class BufferedReader : java.io.Reader
	{ 
		internal new static global::java.lang.Class staticClass; 
		static BufferedReader() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.io.BufferedReader), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _readLine10556; 
		public virtual java.lang.String readLine() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.BufferedReader)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _readLine10556)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.io.BufferedReader.staticClass, _readLine10556)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close10557; 
		public override void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.BufferedReader)) 
				@__env.CallVoidMethod(this, _close10557); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.BufferedReader.staticClass, _close10557); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mark10558; 
		public override void mark(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.BufferedReader)) 
				@__env.CallVoidMethod(this, _mark10558, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.BufferedReader.staticClass, _mark10558, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset10559; 
		public override void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.BufferedReader)) 
				@__env.CallVoidMethod(this, _reset10559); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.BufferedReader.staticClass, _reset10559); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read10560; 
		public override int read(char[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.BufferedReader)) 
				return @__env.CallIntMethod(this, _read10560, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.io.BufferedReader.staticClass, _read10560, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read10561; 
		public override int read() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.BufferedReader)) 
				return @__env.CallIntMethod(this, _read10561); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.io.BufferedReader.staticClass, _read10561); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _skip10562; 
		public override long skip(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.BufferedReader)) 
				return @__env.CallLongMethod(this, _skip10562, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.io.BufferedReader.staticClass, _skip10562, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _markSupported10563; 
		public override bool markSupported() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.BufferedReader)) 
				return @__env.CallBooleanMethod(this, _markSupported10563); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.io.BufferedReader.staticClass, _markSupported10563); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ready10564; 
		public override bool ready() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.BufferedReader)) 
				return @__env.CallBooleanMethod(this, _ready10564); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.io.BufferedReader.staticClass, _ready10564); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BufferedReader10565; 
		public BufferedReader(java.io.Reader arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.BufferedReader.staticClass, _BufferedReader10565, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BufferedReader10566; 
		public BufferedReader(java.io.Reader arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.BufferedReader.staticClass, _BufferedReader10566, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.io.BufferedReader.staticClass = @__class; 
			global::java.io.BufferedReader._readLine10556 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "readLine", "()Ljava/lang/String;"); 
			global::java.io.BufferedReader._close10557 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "close", "()V"); 
			global::java.io.BufferedReader._mark10558 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "mark", "(I)V"); 
			global::java.io.BufferedReader._reset10559 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "reset", "()V"); 
			global::java.io.BufferedReader._read10560 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "read", "([CII)I"); 
			global::java.io.BufferedReader._read10561 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "read", "()I"); 
			global::java.io.BufferedReader._skip10562 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "skip", "(J)J"); 
			global::java.io.BufferedReader._markSupported10563 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "markSupported", "()Z"); 
			global::java.io.BufferedReader._ready10564 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "ready", "()Z"); 
			global::java.io.BufferedReader._BufferedReader10565 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "<init>", "(Ljava/io/Reader;I)V"); 
			global::java.io.BufferedReader._BufferedReader10566 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "<init>", "(Ljava/io/Reader;)V"); 
		} 
	} 
} 
