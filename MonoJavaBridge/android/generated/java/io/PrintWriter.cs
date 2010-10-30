namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PrintWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PrintWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void println(char arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "println", "(C)V", ref global::java.io.PrintWriter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void println()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "println", "()V", ref global::java.io.PrintWriter._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void println(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "println", "(Z)V", ref global::java.io.PrintWriter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void println(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "println", "(Ljava/lang/Object;)V", ref global::java.io.PrintWriter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void println(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "println", "(Ljava/lang/String;)V", ref global::java.io.PrintWriter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void println(char[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "println", "([C)V", ref global::java.io.PrintWriter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void println(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "println", "(D)V", ref global::java.io.PrintWriter._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void println(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "println", "(F)V", ref global::java.io.PrintWriter._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void println(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "println", "(J)V", ref global::java.io.PrintWriter._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void println(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "println", "(I)V", ref global::java.io.PrintWriter._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.io.PrintWriter append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.PrintWriter.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/io/PrintWriter;", ref global::java.io.PrintWriter._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.PrintWriter;
		}
		public java.io.PrintWriter append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.io.PrintWriter append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.PrintWriter.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/io/PrintWriter;", ref global::java.io.PrintWriter._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.io.PrintWriter;
		}
		public java.io.PrintWriter append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.io.PrintWriter append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.PrintWriter.staticClass, "append", "(C)Ljava/io/PrintWriter;", ref global::java.io.PrintWriter._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.PrintWriter;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.io.PrintWriter format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.PrintWriter.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", ref global::java.io.PrintWriter._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.io.PrintWriter;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.io.PrintWriter format(java.lang.String arg0, java.lang.Object[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.PrintWriter.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", ref global::java.io.PrintWriter._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.PrintWriter;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override void write(char[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "write", "([C)V", ref global::java.io.PrintWriter._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override void write(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "write", "([CII)V", ref global::java.io.PrintWriter._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "write", "(I)V", ref global::java.io.PrintWriter._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override void write(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "write", "(Ljava/lang/String;II)V", ref global::java.io.PrintWriter._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override void write(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "write", "(Ljava/lang/String;)V", ref global::java.io.PrintWriter._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void print(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "print", "(Ljava/lang/String;)V", ref global::java.io.PrintWriter._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void print(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "print", "(Ljava/lang/Object;)V", ref global::java.io.PrintWriter._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void print(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "print", "(Z)V", ref global::java.io.PrintWriter._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void print(char arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "print", "(C)V", ref global::java.io.PrintWriter._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void print(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "print", "(I)V", ref global::java.io.PrintWriter._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void print(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "print", "(J)V", ref global::java.io.PrintWriter._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void print(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "print", "(F)V", ref global::java.io.PrintWriter._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void print(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "print", "(D)V", ref global::java.io.PrintWriter._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void print(char[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "print", "([C)V", ref global::java.io.PrintWriter._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "flush", "()V", ref global::java.io.PrintWriter._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "close", "()V", ref global::java.io.PrintWriter._m30);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual bool checkError()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.PrintWriter.staticClass, "checkError", "()Z", ref global::java.io.PrintWriter._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		protected virtual void setError()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "setError", "()V", ref global::java.io.PrintWriter._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		protected virtual void clearError()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PrintWriter.staticClass, "clearError", "()V", ref global::java.io.PrintWriter._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual global::java.io.PrintWriter printf(java.lang.String arg0, java.lang.Object[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.PrintWriter.staticClass, "printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", ref global::java.io.PrintWriter._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.PrintWriter;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual global::java.io.PrintWriter printf(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.PrintWriter.staticClass, "printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", ref global::java.io.PrintWriter._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.io.PrintWriter;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public PrintWriter(java.io.Writer arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PrintWriter._m36.native == global::System.IntPtr.Zero)
				global::java.io.PrintWriter._m36 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/Writer;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public PrintWriter(java.io.OutputStream arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PrintWriter._m37.native == global::System.IntPtr.Zero)
				global::java.io.PrintWriter._m37 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public PrintWriter(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PrintWriter._m38.native == global::System.IntPtr.Zero)
				global::java.io.PrintWriter._m38 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public PrintWriter(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PrintWriter._m39.native == global::System.IntPtr.Zero)
				global::java.io.PrintWriter._m39 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public PrintWriter(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PrintWriter._m40.native == global::System.IntPtr.Zero)
				global::java.io.PrintWriter._m40 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public PrintWriter(java.io.File arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PrintWriter._m41.native == global::System.IntPtr.Zero)
				global::java.io.PrintWriter._m41 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public PrintWriter(java.io.Writer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PrintWriter._m42.native == global::System.IntPtr.Zero)
				global::java.io.PrintWriter._m42 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/Writer;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public PrintWriter(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PrintWriter._m43.native == global::System.IntPtr.Zero)
				global::java.io.PrintWriter._m43 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PrintWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PrintWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PrintWriter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
