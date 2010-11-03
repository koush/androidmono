namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LineNumberReader : java.io.BufferedReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LineNumberReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.LineNumberReader.staticClass, "readLine", "()Ljava/lang/String;", ref global::java.io.LineNumberReader._m0) as java.lang.String;
		}
		public new int LineNumber
		{
			get
			{
				return getLineNumber();
			}
			set
			{
				setLineNumber(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getLineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.LineNumberReader.staticClass, "getLineNumber", "()I", ref global::java.io.LineNumberReader._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.LineNumberReader.staticClass, "mark", "(I)V", ref global::java.io.LineNumberReader._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.LineNumberReader.staticClass, "reset", "()V", ref global::java.io.LineNumberReader._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.LineNumberReader.staticClass, "read", "([CII)I", ref global::java.io.LineNumberReader._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.LineNumberReader.staticClass, "read", "()I", ref global::java.io.LineNumberReader._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.LineNumberReader.staticClass, "skip", "(J)J", ref global::java.io.LineNumberReader._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setLineNumber(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.LineNumberReader.staticClass, "setLineNumber", "(I)V", ref global::java.io.LineNumberReader._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public LineNumberReader(java.io.Reader arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.LineNumberReader._m8.native == global::System.IntPtr.Zero)
				global::java.io.LineNumberReader._m8 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "<init>", "(Ljava/io/Reader;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public LineNumberReader(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.LineNumberReader._m9.native == global::System.IntPtr.Zero)
				global::java.io.LineNumberReader._m9 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static LineNumberReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.LineNumberReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/LineNumberReader"));
		}
	}
}
