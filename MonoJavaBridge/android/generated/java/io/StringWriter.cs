namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StringWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.StringWriter.staticClass, "toString", "()Ljava/lang/String;", ref global::java.io.StringWriter._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.io.StringWriter append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.StringWriter.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/io/StringWriter;", ref global::java.io.StringWriter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.io.StringWriter;
		}
		public java.io.StringWriter append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.io.StringWriter append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.StringWriter.staticClass, "append", "(C)Ljava/io/StringWriter;", ref global::java.io.StringWriter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.StringWriter;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.io.StringWriter append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.StringWriter.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/io/StringWriter;", ref global::java.io.StringWriter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.StringWriter;
		}
		public java.io.StringWriter append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void write(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StringWriter.staticClass, "write", "([CII)V", ref global::java.io.StringWriter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void write(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StringWriter.staticClass, "write", "(Ljava/lang/String;)V", ref global::java.io.StringWriter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void write(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StringWriter.staticClass, "write", "(Ljava/lang/String;II)V", ref global::java.io.StringWriter._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StringWriter.staticClass, "write", "(I)V", ref global::java.io.StringWriter._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StringWriter.staticClass, "flush", "()V", ref global::java.io.StringWriter._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StringWriter.staticClass, "close", "()V", ref global::java.io.StringWriter._m9);
		}
		public new global::java.lang.StringBuffer Buffer
		{
			get
			{
				return getBuffer();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.StringBuffer getBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.io.StringWriter.staticClass, "getBuffer", "()Ljava/lang/StringBuffer;", ref global::java.io.StringWriter._m10) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public StringWriter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StringWriter._m11.native == global::System.IntPtr.Zero)
				global::java.io.StringWriter._m11 = @__env.GetMethodIDNoThrow(global::java.io.StringWriter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StringWriter.staticClass, global::java.io.StringWriter._m11);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public StringWriter(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StringWriter._m12.native == global::System.IntPtr.Zero)
				global::java.io.StringWriter._m12 = @__env.GetMethodIDNoThrow(global::java.io.StringWriter.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StringWriter.staticClass, global::java.io.StringWriter._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StringWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StringWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StringWriter"));
		}
	}
}
