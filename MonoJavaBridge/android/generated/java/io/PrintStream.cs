namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PrintStream : java.io.FilterOutputStream, java.lang.Appendable, Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PrintStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void println(char arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "println", "(C)V", ref global::java.io.PrintStream._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void println()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "println", "()V", ref global::java.io.PrintStream._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void println(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "println", "(Z)V", ref global::java.io.PrintStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void println(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "println", "(Ljava/lang/Object;)V", ref global::java.io.PrintStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void println(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "println", "(Ljava/lang/String;)V", ref global::java.io.PrintStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void println(char[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "println", "([C)V", ref global::java.io.PrintStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void println(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "println", "(D)V", ref global::java.io.PrintStream._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void println(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "println", "(F)V", ref global::java.io.PrintStream._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void println(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "println", "(J)V", ref global::java.io.PrintStream._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void println(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "println", "(I)V", ref global::java.io.PrintStream._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.io.PrintStream.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", ref global::java.io.PrintStream._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.io.PrintStream.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", ref global::java.io.PrintStream._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.lang.Appendable append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.io.PrintStream.staticClass, "append", "(C)Ljava/lang/Appendable;", ref global::java.io.PrintStream._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.io.PrintStream format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.PrintStream.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;", ref global::java.io.PrintStream._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.io.PrintStream;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.io.PrintStream format(java.lang.String arg0, java.lang.Object[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.PrintStream.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;", ref global::java.io.PrintStream._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.PrintStream;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "write", "([BII)V", ref global::java.io.PrintStream._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "write", "(I)V", ref global::java.io.PrintStream._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void print(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "print", "(F)V", ref global::java.io.PrintStream._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void print(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "print", "(D)V", ref global::java.io.PrintStream._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void print(char[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "print", "([C)V", ref global::java.io.PrintStream._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void print(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "print", "(Ljava/lang/String;)V", ref global::java.io.PrintStream._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void print(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "print", "(Ljava/lang/Object;)V", ref global::java.io.PrintStream._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void print(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "print", "(Z)V", ref global::java.io.PrintStream._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void print(char arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "print", "(C)V", ref global::java.io.PrintStream._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void print(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "print", "(I)V", ref global::java.io.PrintStream._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void print(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "print", "(J)V", ref global::java.io.PrintStream._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "flush", "()V", ref global::java.io.PrintStream._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "close", "()V", ref global::java.io.PrintStream._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual bool checkError()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.PrintStream.staticClass, "checkError", "()Z", ref global::java.io.PrintStream._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		protected virtual void setError()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "setError", "()V", ref global::java.io.PrintStream._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		protected virtual void clearError()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintStream.staticClass, "clearError", "()V", ref global::java.io.PrintStream._m30);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual global::java.io.PrintStream printf(java.lang.String arg0, java.lang.Object[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.PrintStream.staticClass, "printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;", ref global::java.io.PrintStream._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.PrintStream;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual global::java.io.PrintStream printf(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.PrintStream.staticClass, "printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;", ref global::java.io.PrintStream._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.io.PrintStream;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public PrintStream(java.io.OutputStream arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PrintStream._m33.native == global::System.IntPtr.Zero)
				global::java.io.PrintStream._m33 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/OutputStream;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public PrintStream(java.io.OutputStream arg0, bool arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PrintStream._m34.native == global::System.IntPtr.Zero)
				global::java.io.PrintStream._m34 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/OutputStream;ZLjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public PrintStream(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PrintStream._m35.native == global::System.IntPtr.Zero)
				global::java.io.PrintStream._m35 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public PrintStream(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PrintStream._m36.native == global::System.IntPtr.Zero)
				global::java.io.PrintStream._m36 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public PrintStream(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PrintStream._m37.native == global::System.IntPtr.Zero)
				global::java.io.PrintStream._m37 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public PrintStream(java.io.File arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PrintStream._m38.native == global::System.IntPtr.Zero)
				global::java.io.PrintStream._m38 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public PrintStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PrintStream._m39.native == global::System.IntPtr.Zero)
				global::java.io.PrintStream._m39 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PrintStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PrintStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PrintStream"));
		}
	}
}
