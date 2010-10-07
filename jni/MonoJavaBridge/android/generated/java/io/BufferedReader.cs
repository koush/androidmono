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
		internal static global::net.sf.jni4net.jni.MethodId _readLine12096;
		public virtual global::java.lang.String readLine() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.BufferedReader._readLine12096));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._readLine12096));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close12097;
		public override void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.BufferedReader._close12097);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._close12097);
		}
		internal static global::net.sf.jni4net.jni.MethodId _mark12098;
		public override void mark(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.BufferedReader._mark12098, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._mark12098, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset12099;
		public override void reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.BufferedReader._reset12099);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._reset12099);
		}
		internal static global::net.sf.jni4net.jni.MethodId _read12100;
		public override int read(char[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.io.BufferedReader._read12100, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._read12100, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _read12101;
		public override int read() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.io.BufferedReader._read12101);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._read12101);
		}
		internal static global::net.sf.jni4net.jni.MethodId _skip12102;
		public override long skip(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.io.BufferedReader._skip12102, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._skip12102, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _markSupported12103;
		public override bool markSupported() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.io.BufferedReader._markSupported12103);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._markSupported12103);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ready12104;
		public override bool ready() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.io.BufferedReader._ready12104);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.io.BufferedReader.staticClass, global::java.io.BufferedReader._ready12104);
		}
		internal static global::net.sf.jni4net.jni.MethodId _BufferedReader12105;
		public BufferedReader(java.io.Reader arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.BufferedReader.staticClass, global::java.io.BufferedReader._BufferedReader12105, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BufferedReader12106;
		public BufferedReader(java.io.Reader arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.BufferedReader.staticClass, global::java.io.BufferedReader._BufferedReader12106, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.io.BufferedReader.staticClass = @__class;
			global::java.io.BufferedReader._readLine12096 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.BufferedReader._close12097 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "close", "()V");
			global::java.io.BufferedReader._mark12098 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "mark", "(I)V");
			global::java.io.BufferedReader._reset12099 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "reset", "()V");
			global::java.io.BufferedReader._read12100 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "read", "([CII)I");
			global::java.io.BufferedReader._read12101 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "read", "()I");
			global::java.io.BufferedReader._skip12102 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "skip", "(J)J");
			global::java.io.BufferedReader._markSupported12103 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "markSupported", "()Z");
			global::java.io.BufferedReader._ready12104 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "ready", "()Z");
			global::java.io.BufferedReader._BufferedReader12105 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "<init>", "(Ljava/io/Reader;I)V");
			global::java.io.BufferedReader._BufferedReader12106 = @__env.GetMethodID(global::java.io.BufferedReader.staticClass, "<init>", "(Ljava/io/Reader;)V");
		}
	}
}
