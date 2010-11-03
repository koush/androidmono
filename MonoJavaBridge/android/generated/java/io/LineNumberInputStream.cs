namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LineNumberInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LineNumberInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getLineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.LineNumberInputStream.staticClass, "getLineNumber", "()I", ref global::java.io.LineNumberInputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.LineNumberInputStream.staticClass, "mark", "(I)V", ref global::java.io.LineNumberInputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.LineNumberInputStream.staticClass, "reset", "()V", ref global::java.io.LineNumberInputStream._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.LineNumberInputStream.staticClass, "read", "([BII)I", ref global::java.io.LineNumberInputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.LineNumberInputStream.staticClass, "read", "()I", ref global::java.io.LineNumberInputStream._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.LineNumberInputStream.staticClass, "skip", "(J)J", ref global::java.io.LineNumberInputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.LineNumberInputStream.staticClass, "available", "()I", ref global::java.io.LineNumberInputStream._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setLineNumber(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.LineNumberInputStream.staticClass, "setLineNumber", "(I)V", ref global::java.io.LineNumberInputStream._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public LineNumberInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.LineNumberInputStream._m8.native == global::System.IntPtr.Zero)
				global::java.io.LineNumberInputStream._m8 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static LineNumberInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.LineNumberInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/LineNumberInputStream"));
		}
	}
}
