namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.Writer_))]
	public abstract partial class Writer : java.lang.Object, java.lang.Appendable, Closeable, Flushable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Writer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.io.Writer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", ref global::java.io.Writer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.io.Writer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", ref global::java.io.Writer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.Appendable append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.io.Writer.staticClass, "append", "(C)Ljava/lang/Appendable;", ref global::java.io.Writer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract void write(char[] arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.Writer.staticClass, "write", "(I)V", ref global::java.io.Writer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void write(char[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.Writer.staticClass, "write", "([C)V", ref global::java.io.Writer._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void write(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.Writer.staticClass, "write", "(Ljava/lang/String;)V", ref global::java.io.Writer._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void write(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.Writer.staticClass, "write", "(Ljava/lang/String;II)V", ref global::java.io.Writer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract void flush();
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract void close();
		private static global::MonoJavaBridge.MethodId _m10;
		protected Writer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.Writer._m10.native == global::System.IntPtr.Zero)
				global::java.io.Writer._m10 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Writer.staticClass, global::java.io.Writer._m10);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected Writer(java.lang.Object arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.Writer._m11.native == global::System.IntPtr.Zero)
				global::java.io.Writer._m11 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Writer.staticClass, global::java.io.Writer._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Writer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Writer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Writer"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.Writer))]
	internal sealed partial class Writer_ : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Writer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void write(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.Writer_.staticClass, "write", "([CII)V", ref global::java.io.Writer_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.Writer_.staticClass, "flush", "()V", ref global::java.io.Writer_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.Writer_.staticClass, "close", "()V", ref global::java.io.Writer_._m2);
		}
		static Writer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Writer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Writer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
